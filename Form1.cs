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
                }
            }
            txt_insertar.Text = string.Empty;
        }
    }
}