namespace PollosHermanosRP
{
    partial class GestionEmpleados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dtgempleados = new DataGridView();
            txtnombre = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtsueldo = new TextBox();
            chkmesero = new CheckBox();
            chklimpieza = new CheckBox();
            chkcocinero = new CheckBox();
            txtbuscar = new TextBox();
            btnsalir = new Button();
            btnactualizar = new Button();
            btneliminar = new Button();
            btnagregar = new Button();
            chkcajero = new CheckBox();
            label6 = new Label();
            txtcontrasena = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dtgempleados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dtgempleados
            // 
            dtgempleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgempleados.Location = new Point(14, 304);
            dtgempleados.Name = "dtgempleados";
            dtgempleados.RowHeadersWidth = 51;
            dtgempleados.Size = new Size(693, 227);
            dtgempleados.TabIndex = 0;
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(96, 14);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(125, 27);
            txtnombre.TabIndex = 1;
            txtnombre.KeyPress += txtnombre_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei", 20F, FontStyle.Bold);
            label1.Location = new Point(427, 9);
            label1.Name = "label1";
            label1.Size = new Size(397, 45);
            label1.TabIndex = 25;
            label1.Text = "Control de Empleados";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.los_pollos_hermanos_logo_E4DCC13511_seeklogo_com;
            pictureBox1.Location = new Point(640, 69);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(184, 207);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei", 8F, FontStyle.Bold);
            label2.Location = new Point(23, 18);
            label2.Name = "label2";
            label2.Size = new Size(67, 19);
            label2.TabIndex = 27;
            label2.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft YaHei", 8F, FontStyle.Bold);
            label4.Location = new Point(251, 20);
            label4.Name = "label4";
            label4.Size = new Size(50, 19);
            label4.TabIndex = 29;
            label4.Text = "Cargo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft YaHei", 8F, FontStyle.Bold);
            label5.Location = new Point(31, 63);
            label5.Name = "label5";
            label5.Size = new Size(56, 19);
            label5.TabIndex = 31;
            label5.Text = "Sueldo";
            // 
            // txtsueldo
            // 
            txtsueldo.Location = new Point(96, 59);
            txtsueldo.Name = "txtsueldo";
            txtsueldo.Size = new Size(125, 27);
            txtsueldo.TabIndex = 30;
            txtsueldo.KeyPress += txtsueldo_KeyPress;
            // 
            // chkmesero
            // 
            chkmesero.AutoSize = true;
            chkmesero.Font = new Font("Microsoft YaHei", 8F, FontStyle.Bold);
            chkmesero.Location = new Point(251, 90);
            chkmesero.Name = "chkmesero";
            chkmesero.Size = new Size(83, 23);
            chkmesero.TabIndex = 34;
            chkmesero.Text = "Mesero";
            chkmesero.UseVisualStyleBackColor = true;
            chkmesero.CheckedChanged += chkmesero_CheckedChanged;
            // 
            // chklimpieza
            // 
            chklimpieza.AutoSize = true;
            chklimpieza.Font = new Font("Microsoft YaHei", 8F, FontStyle.Bold);
            chklimpieza.Location = new Point(251, 119);
            chklimpieza.Name = "chklimpieza";
            chklimpieza.Size = new Size(165, 23);
            chklimpieza.TabIndex = 33;
            chklimpieza.Text = "Agente de limpieza";
            chklimpieza.UseVisualStyleBackColor = true;
            chklimpieza.CheckedChanged += chklimpieza_CheckedChanged;
            // 
            // chkcocinero
            // 
            chkcocinero.AutoSize = true;
            chkcocinero.Font = new Font("Microsoft YaHei", 8F, FontStyle.Bold);
            chkcocinero.Location = new Point(251, 60);
            chkcocinero.Name = "chkcocinero";
            chkcocinero.Size = new Size(92, 23);
            chkcocinero.TabIndex = 32;
            chkcocinero.Text = "Cocinero";
            chkcocinero.UseVisualStyleBackColor = true;
            chkcocinero.CheckedChanged += chkcocinero_CheckedChanged;
            // 
            // txtbuscar
            // 
            txtbuscar.Location = new Point(24, 271);
            txtbuscar.Name = "txtbuscar";
            txtbuscar.Size = new Size(125, 27);
            txtbuscar.TabIndex = 40;
            txtbuscar.TextChanged += txtbuscar_TextChanged;
            // 
            // btnsalir
            // 
            btnsalir.BackColor = Color.FromArgb(209, 50, 50);
            btnsalir.Font = new Font("Microsoft YaHei", 11.25F, FontStyle.Bold);
            btnsalir.Location = new Point(731, 512);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(93, 35);
            btnsalir.TabIndex = 38;
            btnsalir.Text = "Salir";
            btnsalir.UseVisualStyleBackColor = false;
            btnsalir.Click += btnsalir_Click;
            // 
            // btnactualizar
            // 
            btnactualizar.BackColor = Color.FromArgb(106, 172, 230);
            btnactualizar.Font = new Font("Microsoft YaHei", 8.25F, FontStyle.Bold);
            btnactualizar.Location = new Point(731, 353);
            btnactualizar.Name = "btnactualizar";
            btnactualizar.Size = new Size(93, 43);
            btnactualizar.TabIndex = 37;
            btnactualizar.Text = "Actualizar";
            btnactualizar.UseVisualStyleBackColor = false;
            btnactualizar.Click += btnactualizar_Click;
            // 
            // btneliminar
            // 
            btneliminar.BackColor = Color.FromArgb(106, 172, 230);
            btneliminar.Font = new Font("Microsoft YaHei", 8.25F, FontStyle.Bold);
            btneliminar.Location = new Point(731, 402);
            btneliminar.Name = "btneliminar";
            btneliminar.Size = new Size(93, 43);
            btneliminar.TabIndex = 36;
            btneliminar.Text = "Eliminar";
            btneliminar.UseVisualStyleBackColor = false;
            btneliminar.Click += btneliminar_Click;
            // 
            // btnagregar
            // 
            btnagregar.BackColor = Color.FromArgb(106, 172, 230);
            btnagregar.Font = new Font("Microsoft YaHei", 8.25F, FontStyle.Bold);
            btnagregar.Location = new Point(731, 304);
            btnagregar.Name = "btnagregar";
            btnagregar.Size = new Size(93, 43);
            btnagregar.TabIndex = 35;
            btnagregar.Text = "Agregar";
            btnagregar.UseVisualStyleBackColor = false;
            btnagregar.Click += btnagregar_Click;
            // 
            // chkcajero
            // 
            chkcajero.AutoSize = true;
            chkcajero.Font = new Font("Microsoft YaHei", 8F, FontStyle.Bold);
            chkcajero.Location = new Point(251, 148);
            chkcajero.Name = "chkcajero";
            chkcajero.Size = new Size(75, 23);
            chkcajero.TabIndex = 41;
            chkcajero.Text = "Cajero";
            chkcajero.UseVisualStyleBackColor = true;
            chkcajero.CheckedChanged += chkcajero_CheckedChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft YaHei", 8F, FontStyle.Bold);
            label6.Location = new Point(2, 119);
            label6.Name = "label6";
            label6.Size = new Size(88, 19);
            label6.TabIndex = 43;
            label6.Text = "Contrasena";
            // 
            // txtcontrasena
            // 
            txtcontrasena.Location = new Point(96, 115);
            txtcontrasena.Name = "txtcontrasena";
            txtcontrasena.Size = new Size(125, 27);
            txtcontrasena.TabIndex = 42;
            txtcontrasena.KeyPress += txtcontrasena_KeyPress;
            // 
            // GestionEmpleados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightYellow;
            ClientSize = new Size(836, 559);
            Controls.Add(label6);
            Controls.Add(txtcontrasena);
            Controls.Add(chkcajero);
            Controls.Add(txtbuscar);
            Controls.Add(btnsalir);
            Controls.Add(btnactualizar);
            Controls.Add(btneliminar);
            Controls.Add(btnagregar);
            Controls.Add(chkmesero);
            Controls.Add(chklimpieza);
            Controls.Add(chkcocinero);
            Controls.Add(label5);
            Controls.Add(txtsueldo);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(txtnombre);
            Controls.Add(dtgempleados);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GestionEmpleados";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Añadirempleado";
            Load += Añadirempleado_Load;
            ((System.ComponentModel.ISupportInitialize)dtgempleados).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgempleados;
        private TextBox txtnombre;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label4;
        private Label label5;
        private TextBox txtsueldo;
        public CheckBox chkmesero;
        public CheckBox chklimpieza;
        public CheckBox chkcocinero;
        private TextBox txtbuscar;
        private Button btnsalir;
        private Button btnactualizar;
        private Button btneliminar;
        private Button btnagregar;
        public CheckBox chkcajero;
        private Label label6;
        private TextBox txtcontrasena;
    }
}