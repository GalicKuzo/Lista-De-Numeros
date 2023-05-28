namespace Lista_De_Numeros
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.list_Numeros = new System.Windows.Forms.ListBox();
            this.btn_Insertar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.btn_Ascendente = new System.Windows.Forms.Button();
            this.btn_Descendente = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_insertar = new System.Windows.Forms.TextBox();
            this.txt_eliminar = new System.Windows.Forms.TextBox();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_insertar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_Insertar);
            this.groupBox1.Location = new System.Drawing.Point(432, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 149);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Insertar";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_eliminar);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btn_Eliminar);
            this.groupBox2.Location = new System.Drawing.Point(432, 179);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(361, 149);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Eliminar";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_buscar);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.btn_Buscar);
            this.groupBox3.Location = new System.Drawing.Point(432, 335);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(361, 149);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Buscar";
            // 
            // list_Numeros
            // 
            this.list_Numeros.FormattingEnabled = true;
            this.list_Numeros.ItemHeight = 20;
            this.list_Numeros.Location = new System.Drawing.Point(12, 12);
            this.list_Numeros.Name = "list_Numeros";
            this.list_Numeros.Size = new System.Drawing.Size(414, 404);
            this.list_Numeros.TabIndex = 3;
            // 
            // btn_Insertar
            // 
            this.btn_Insertar.Location = new System.Drawing.Point(31, 90);
            this.btn_Insertar.Name = "btn_Insertar";
            this.btn_Insertar.Size = new System.Drawing.Size(290, 36);
            this.btn_Insertar.TabIndex = 0;
            this.btn_Insertar.Text = "Insertar";
            this.btn_Insertar.UseVisualStyleBackColor = true;
            this.btn_Insertar.Click += new System.EventHandler(this.btn_Insertar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(31, 94);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(290, 36);
            this.btn_Eliminar.TabIndex = 1;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(31, 95);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(290, 36);
            this.btn_Buscar.TabIndex = 2;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            // 
            // btn_Ascendente
            // 
            this.btn_Ascendente.Location = new System.Drawing.Point(6, 26);
            this.btn_Ascendente.Name = "btn_Ascendente";
            this.btn_Ascendente.Size = new System.Drawing.Size(185, 38);
            this.btn_Ascendente.TabIndex = 4;
            this.btn_Ascendente.Text = "Ascendente";
            this.btn_Ascendente.UseVisualStyleBackColor = true;
            // 
            // btn_Descendente
            // 
            this.btn_Descendente.Location = new System.Drawing.Point(207, 26);
            this.btn_Descendente.Name = "btn_Descendente";
            this.btn_Descendente.Size = new System.Drawing.Size(185, 38);
            this.btn_Descendente.TabIndex = 5;
            this.btn_Descendente.Text = "Descendete";
            this.btn_Descendente.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_Descendente);
            this.groupBox4.Controls.Add(this.btn_Ascendente);
            this.groupBox4.Location = new System.Drawing.Point(9, 427);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(403, 76);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ordenar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Numero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Numero";
            // 
            // txt_insertar
            // 
            this.txt_insertar.Location = new System.Drawing.Point(85, 45);
            this.txt_insertar.Name = "txt_insertar";
            this.txt_insertar.Size = new System.Drawing.Size(255, 27);
            this.txt_insertar.TabIndex = 2;
            this.txt_insertar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_insertar_KeyPress);
            // 
            // txt_eliminar
            // 
            this.txt_eliminar.Location = new System.Drawing.Point(85, 46);
            this.txt_eliminar.Name = "txt_eliminar";
            this.txt_eliminar.Size = new System.Drawing.Size(255, 27);
            this.txt_eliminar.TabIndex = 3;
            this.txt_eliminar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_eliminar_KeyPress);
            // 
            // txt_buscar
            // 
            this.txt_buscar.Location = new System.Drawing.Point(85, 46);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(255, 27);
            this.txt_buscar.TabIndex = 4;
            this.txt_buscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_buscar_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 509);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.list_Numeros);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Numeros";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txt_insertar;
        private Label label1;
        private Button btn_Insertar;
        private GroupBox groupBox2;
        private TextBox txt_eliminar;
        private Label label2;
        private Button btn_Eliminar;
        private GroupBox groupBox3;
        private TextBox txt_buscar;
        private Label label3;
        private Button btn_Buscar;
        private ListBox list_Numeros;
        private Button btn_Ascendente;
        private Button btn_Descendente;
        private GroupBox groupBox4;
    }
}