/*namespace PollosHermanosRP
{
    partial class Cuentallevar
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
            dtgfactura = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            btnsalir = new Button();
            btnagregar = new Button();
            btneliminar = new Button();
            btnimprimir = new Button();
            lbltotal = new Label();
            label3 = new Label();
            cmbmetododepago = new ComboBox();
            dtgelementos = new DataGridView();
            txtbuscar = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dtgfactura).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgelementos).BeginInit();
            SuspendLayout();
            // 
            // dtgfactura
            // 
            dtgfactura.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgfactura.Columns.AddRange(new DataGridViewColumn[] { Nombre, Precio });
            dtgfactura.Location = new Point(20, 46);
            dtgfactura.Margin = new Padding(3, 2, 3, 2);
            dtgfactura.Name = "dtgfactura";
            dtgfactura.RowHeadersWidth = 51;
            dtgfactura.Size = new Size(344, 141);
            dtgfactura.TabIndex = 1;
            dtgfactura.CellContentClick += dtgfactura_CellContentClick;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.Width = 200;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.MinimumWidth = 6;
            Precio.Name = "Precio";
            Precio.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei", 20F, FontStyle.Bold);
            label1.Location = new Point(20, 10);
            label1.Name = "label1";
            label1.Size = new Size(100, 36);
            label1.TabIndex = 24;
            label1.Text = "Orden";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei", 20F, FontStyle.Bold);
            label2.Location = new Point(20, 206);
            label2.Name = "label2";
            label2.Size = new Size(95, 36);
            label2.TabIndex = 25;
            label2.Text = "Menu";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.los_pollos_hermanos_logo_E4DCC13511_seeklogo_com;
            pictureBox1.Location = new Point(765, 9);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(207, 190);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // btnsalir
            // 
            btnsalir.BackColor = Color.FromArgb(209, 50, 50);
            btnsalir.Font = new Font("Microsoft YaHei", 11.25F, FontStyle.Bold);
            btnsalir.Location = new Point(901, 560);
            btnsalir.Margin = new Padding(3, 2, 3, 2);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(132, 28);
            btnsalir.TabIndex = 31;
            btnsalir.Text = "Salir";
            btnsalir.UseVisualStyleBackColor = false;
            btnsalir.Click += btnsalir_Click;
            // 
            // btnagregar
            // 
            btnagregar.BackColor = Color.Black;
            btnagregar.Font = new Font("Microsoft YaHei", 8.25F, FontStyle.Bold);
            btnagregar.ForeColor = Color.White;
            btnagregar.Location = new Point(741, 526);
            btnagregar.Margin = new Padding(3, 2, 3, 2);
            btnagregar.Name = "btnagregar";
            btnagregar.Size = new Size(132, 30);
            btnagregar.TabIndex = 28;
            btnagregar.Text = "Agregar";
            btnagregar.UseVisualStyleBackColor = false;
            btnagregar.Click += btnagregar_Click;
            // 
            // btneliminar
            // 
            btneliminar.BackColor = Color.Black;
            btneliminar.Font = new Font("Microsoft YaHei", 8.25F, FontStyle.Bold);
            btneliminar.ForeColor = Color.White;
            btneliminar.Location = new Point(592, 46);
            btneliminar.Margin = new Padding(3, 2, 3, 2);
            btneliminar.Name = "btneliminar";
            btneliminar.Size = new Size(132, 30);
            btneliminar.TabIndex = 32;
            btneliminar.Text = "Eliminar";
            btneliminar.UseVisualStyleBackColor = false;
            btneliminar.Click += btneliminar_Click;
            // 
            // btnimprimir
            // 
            btnimprimir.BackColor = Color.FromArgb(209, 50, 50);
            btnimprimir.Font = new Font("Microsoft YaHei", 11.25F, FontStyle.Bold);
            btnimprimir.Location = new Point(592, 159);
            btnimprimir.Margin = new Padding(3, 2, 3, 2);
            btnimprimir.Name = "btnimprimir";
            btnimprimir.Size = new Size(132, 28);
            btnimprimir.TabIndex = 33;
            btnimprimir.Text = "Imprimir";
            btnimprimir.UseVisualStyleBackColor = false;
            btnimprimir.Click += btnimprimir_Click;
            // 
            // lbltotal
            // 
            lbltotal.AutoSize = true;
            lbltotal.Font = new Font("Microsoft YaHei", 20F, FontStyle.Bold);
            lbltotal.Location = new Point(369, 152);
            lbltotal.Name = "lbltotal";
            lbltotal.Size = new Size(100, 36);
            lbltotal.TabIndex = 34;
            lbltotal.Text = "Orden";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei", 10F, FontStyle.Bold);
            label3.Location = new Point(377, 22);
            label3.Name = "label3";
            label3.Size = new Size(124, 19);
            label3.TabIndex = 36;
            label3.Text = "Metodo de pago";
            // 
            // cmbmetododepago
            // 
            cmbmetododepago.FormattingEnabled = true;
            cmbmetododepago.Items.AddRange(new object[] { "Tarjeta", "Efectivo" });
            cmbmetododepago.Location = new Point(385, 46);
            cmbmetododepago.Margin = new Padding(3, 2, 3, 2);
            cmbmetododepago.Name = "cmbmetododepago";
            cmbmetododepago.Size = new Size(133, 23);
            cmbmetododepago.TabIndex = 37;
            // 
            // dtgelementos
            // 
            dtgelementos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgelementos.Location = new Point(20, 258);
            dtgelementos.Name = "dtgelementos";
            dtgelementos.Size = new Size(704, 319);
            dtgelementos.TabIndex = 38;
            // 
            // txtbuscar
            // 
            txtbuscar.Location = new Point(741, 560);
            txtbuscar.Name = "txtbuscar";
            txtbuscar.Size = new Size(132, 23);
            txtbuscar.TabIndex = 39;
            // 
            // Cuentallevar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(1037, 599);
            Controls.Add(txtbuscar);
            Controls.Add(dtgelementos);
            Controls.Add(cmbmetododepago);
            Controls.Add(label3);
            Controls.Add(lbltotal);
            Controls.Add(btnimprimir);
            Controls.Add(btneliminar);
            Controls.Add(btnsalir);
            Controls.Add(btnagregar);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtgfactura);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Cuentallevar";
            Text = " ";
            Load += Cuentallevar_Load;
            ((System.ComponentModel.ISupportInitialize)dtgfactura).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgelementos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dtgfactura;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Button btnsalir;
        private Button btnagregar;
        private Button btneliminar;
        private Button btnimprimir;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Precio;
        private Label lbltotal;
        private Label label3;
        private ComboBox cmbmetododepago;
        private DataGridView dtgelementos;
        private TextBox txtbuscar;
    }
}*/