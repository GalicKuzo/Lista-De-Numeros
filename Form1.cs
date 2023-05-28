using System.Windows.Forms;
using System.Xml.Linq;

namespace Lista_De_Numeros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Funcion para solo permitir numeros
        private void txt_insertar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        //Funcion para solo permitir numeros
        private void txt_eliminar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        //Funcion para solo permitir numeros
        private void txt_buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        //Lista de numeros

        List<int> numeros = new List<int>();

        //Funcion para añadir numeros a la lista
        private void btn_Insertar_Click(object sender, EventArgs e)
        {
            string num = txt_insertar.Text;
            int x;

            if (int.TryParse(num, out x))
            {
                if (!numeros.Contains(x))
                {
                    numeros.Add(x);
                    list_Numeros.Items.Add(num);
                } else
                {
                    MessageBox.Show("¡El numero que ha ingresado ya existe en la lista!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            txt_insertar.Text = string.Empty;
        }
        //Funcion para buscar un numero en la lista
        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            int i = numeros.Count-1;
            int num = Convert.ToInt32((string)txt_buscar.Text);
            BuscarNumero(num, i);
            txt_buscar.Text = string.Empty;
        }
        //Funcion para eliminar un numero de la lista
        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            string num = (string)txt_eliminar.Text;
            numeros.Remove(Convert.ToInt32(num));
            if (list_Numeros.Items.Contains(num))
            {
                list_Numeros.Items.Remove(num);
                MessageBox.Show("¡Numero eliminado con exito!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
                MessageBox.Show("¡El numero que ha ingresado no existe en la lista!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txt_eliminar.Text = string.Empty;
        }

        //Funcion de busqueda usando el metodo de recursividad
        private void BuscarNumero(int num, int i)
        {
            if (num == numeros[i])
            {
                MessageBox.Show("¡El numero que ha ingresado si existe!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (i != 0)
                {
                    BuscarNumero(num, i - 1);
                }
                else
                    MessageBox.Show("¡El numero que ha ingresado no existe en la lista!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}