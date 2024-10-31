namespace PollosHermanosRP
{
    partial class OrdenForm
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnPlatosFuertes = new Button();
            btnEntradas = new Button();
            btnPostres = new Button();
            btnBebidasCalientes = new Button();
            btnBebidasFrias = new Button();
            button6 = new Button();
            pictureBox1 = new PictureBox();
            btneliminar = new Button();
            btnenviarorden = new Button();
            lblTotal = new Label();
            label1 = new Label();
            dtgProductos = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            SubTotal = new DataGridViewTextBoxColumn();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblMesero = new Label();
            lblMesa = new Label();
            lblCliente = new Label();
            lblPedido = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgProductos).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.Khaki;
            flowLayoutPanel1.Location = new Point(234, 108);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(618, 439);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // btnPlatosFuertes
            // 
            btnPlatosFuertes.BackColor = Color.White;
            btnPlatosFuertes.FlatAppearance.BorderColor = Color.Black;
            btnPlatosFuertes.FlatAppearance.BorderSize = 2;
            btnPlatosFuertes.FlatStyle = FlatStyle.Flat;
            btnPlatosFuertes.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnPlatosFuertes.ForeColor = Color.Black;
            btnPlatosFuertes.Location = new Point(25, 183);
            btnPlatosFuertes.Name = "btnPlatosFuertes";
            btnPlatosFuertes.Size = new Size(188, 68);
            btnPlatosFuertes.TabIndex = 0;
            btnPlatosFuertes.Text = "Platos Fuertes";
            btnPlatosFuertes.UseVisualStyleBackColor = false;
            btnPlatosFuertes.Click += btnPlatosFuertes_Click_1;
            // 
            // btnEntradas
            // 
            btnEntradas.BackColor = Color.White;
            btnEntradas.FlatAppearance.BorderColor = Color.Black;
            btnEntradas.FlatAppearance.BorderSize = 2;
            btnEntradas.FlatStyle = FlatStyle.Flat;
            btnEntradas.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnEntradas.ForeColor = Color.Black;
            btnEntradas.Location = new Point(25, 257);
            btnEntradas.Name = "btnEntradas";
            btnEntradas.Size = new Size(188, 68);
            btnEntradas.TabIndex = 2;
            btnEntradas.Text = "Entradas";
            btnEntradas.UseVisualStyleBackColor = false;
            btnEntradas.Click += btnEntradas_Click;
            // 
            // btnPostres
            // 
            btnPostres.BackColor = Color.White;
            btnPostres.FlatAppearance.BorderColor = Color.Black;
            btnPostres.FlatAppearance.BorderSize = 2;
            btnPostres.FlatStyle = FlatStyle.Flat;
            btnPostres.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnPostres.ForeColor = Color.Black;
            btnPostres.Location = new Point(25, 331);
            btnPostres.Name = "btnPostres";
            btnPostres.Size = new Size(188, 68);
            btnPostres.TabIndex = 3;
            btnPostres.Text = "Postres";
            btnPostres.UseVisualStyleBackColor = false;
            btnPostres.Click += btnPostres_Click;
            // 
            // btnBebidasCalientes
            // 
            btnBebidasCalientes.BackColor = Color.White;
            btnBebidasCalientes.FlatAppearance.BorderColor = Color.Black;
            btnBebidasCalientes.FlatAppearance.BorderSize = 2;
            btnBebidasCalientes.FlatStyle = FlatStyle.Flat;
            btnBebidasCalientes.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnBebidasCalientes.ForeColor = Color.Black;
            btnBebidasCalientes.Location = new Point(25, 405);
            btnBebidasCalientes.Name = "btnBebidasCalientes";
            btnBebidasCalientes.Size = new Size(188, 68);
            btnBebidasCalientes.TabIndex = 4;
            btnBebidasCalientes.Text = "Bebidas Calientes";
            btnBebidasCalientes.UseVisualStyleBackColor = false;
            btnBebidasCalientes.Click += btnBebidasCalientes_Click;
            // 
            // btnBebidasFrias
            // 
            btnBebidasFrias.BackColor = Color.White;
            btnBebidasFrias.FlatAppearance.BorderColor = Color.Black;
            btnBebidasFrias.FlatAppearance.BorderSize = 2;
            btnBebidasFrias.FlatStyle = FlatStyle.Flat;
            btnBebidasFrias.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnBebidasFrias.ForeColor = Color.Black;
            btnBebidasFrias.Location = new Point(25, 479);
            btnBebidasFrias.Name = "btnBebidasFrias";
            btnBebidasFrias.Size = new Size(188, 68);
            btnBebidasFrias.TabIndex = 5;
            btnBebidasFrias.Text = "Bebidas Frias";
            btnBebidasFrias.UseVisualStyleBackColor = false;
            btnBebidasFrias.Click += btnBebidasFrias_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(209, 50, 50);
            button6.FlatAppearance.BorderColor = Color.Black;
            button6.FlatAppearance.BorderSize = 2;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            button6.Location = new Point(25, 582);
            button6.Name = "button6";
            button6.Size = new Size(188, 68);
            button6.TabIndex = 6;
            button6.Text = "Salir";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.los_pollos_hermanos_logo_E4DCC13511_seeklogo_com;
            pictureBox1.Location = new Point(38, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(155, 154);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // btneliminar
            // 
            btneliminar.Location = new Point(575, 583);
            btneliminar.Name = "btneliminar";
            btneliminar.Size = new Size(124, 68);
            btneliminar.TabIndex = 8;
            btneliminar.Text = "Eliminar";
            btneliminar.UseVisualStyleBackColor = true;
            btneliminar.Click += btneliminar_Click;
            // 
            // btnenviarorden
            // 
            btnenviarorden.Location = new Point(728, 583);
            btnenviarorden.Name = "btnenviarorden";
            btnenviarorden.Size = new Size(124, 68);
            btnenviarorden.TabIndex = 11;
            btnenviarorden.Text = "Enviar Orden";
            btnenviarorden.UseVisualStyleBackColor = true;
            btnenviarorden.Click += btnenviarorden_Click;
            // 
            // lblTotal
            // 
            lblTotal.AccessibleRole = AccessibleRole.Grip;
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Microsoft YaHei", 14F, FontStyle.Bold);
            lblTotal.Location = new Point(996, 55);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(24, 26);
            lblTotal.TabIndex = 32;
            lblTotal.Text = "0";
            lblTotal.Click += lblTotal_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei", 14F, FontStyle.Bold);
            label1.Location = new Point(914, 55);
            label1.Name = "label1";
            label1.Size = new Size(76, 26);
            label1.TabIndex = 33;
            label1.Text = "TOTAL";
            // 
            // dtgProductos
            // 
            dtgProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dtgProductos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtgProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgProductos.Columns.AddRange(new DataGridViewColumn[] { ID, Nombre, Precio, Cantidad, SubTotal });
            dtgProductos.Location = new Point(884, 98);
            dtgProductos.Name = "dtgProductos";
            dtgProductos.RowHeadersVisible = false;
            dtgProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgProductos.Size = new Size(300, 552);
            dtgProductos.TabIndex = 34;
            dtgProductos.CellContentClick += dtgElementos_CellContentClick;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.Visible = false;
            ID.Width = 24;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.Width = 76;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            Precio.Width = 65;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            Cantidad.Width = 80;
            // 
            // SubTotal
            // 
            SubTotal.HeaderText = "Subtotal";
            SubTotal.Name = "SubTotal";
            SubTotal.Width = 76;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(234, 54);
            label2.Name = "label2";
            label2.Size = new Size(80, 22);
            label2.TabIndex = 35;
            label2.Text = "Mesero: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(395, 55);
            label3.Name = "label3";
            label3.Size = new Size(57, 22);
            label3.TabIndex = 36;
            label3.Text = "Mesa:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(524, 55);
            label4.Name = "label4";
            label4.Size = new Size(71, 22);
            label4.TabIndex = 37;
            label4.Text = "Cliente:";
            // 
            // lblMesero
            // 
            lblMesero.AutoSize = true;
            lblMesero.Font = new Font("Microsoft YaHei", 12F);
            lblMesero.Location = new Point(306, 54);
            lblMesero.Name = "lblMesero";
            lblMesero.Size = new Size(41, 21);
            lblMesero.TabIndex = 38;
            lblMesero.Text = "N/A";
            lblMesero.Click += lblMesero_Click;
            // 
            // lblMesa
            // 
            lblMesa.AutoSize = true;
            lblMesa.Font = new Font("Microsoft YaHei", 12F);
            lblMesa.Location = new Point(444, 55);
            lblMesa.Name = "lblMesa";
            lblMesa.Size = new Size(41, 21);
            lblMesa.TabIndex = 39;
            lblMesa.Text = "N/A";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Microsoft YaHei", 12F);
            lblCliente.Location = new Point(591, 55);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(41, 21);
            lblCliente.TabIndex = 40;
            lblCliente.Text = "N/A";
            // 
            // lblPedido
            // 
            lblPedido.AutoSize = true;
            lblPedido.Font = new Font("Microsoft YaHei", 12F);
            lblPedido.Location = new Point(784, 55);
            lblPedido.Name = "lblPedido";
            lblPedido.Size = new Size(41, 21);
            lblPedido.TabIndex = 42;
            lblPedido.Text = "N/A";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(691, 55);
            label6.Name = "label6";
            label6.Size = new Size(96, 22);
            label6.TabIndex = 41;
            label6.Text = "ID pedido:";
            // 
            // OrdenForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightYellow;
            ClientSize = new Size(1216, 689);
            Controls.Add(lblPedido);
            Controls.Add(label6);
            Controls.Add(lblCliente);
            Controls.Add(lblMesa);
            Controls.Add(lblMesero);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dtgProductos);
            Controls.Add(label1);
            Controls.Add(lblTotal);
            Controls.Add(btnenviarorden);
            Controls.Add(btneliminar);
            Controls.Add(pictureBox1);
            Controls.Add(button6);
            Controls.Add(btnBebidasFrias);
            Controls.Add(btnBebidasCalientes);
            Controls.Add(btnPostres);
            Controls.Add(btnEntradas);
            Controls.Add(btnPlatosFuertes);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "OrdenForm";
            StartPosition = FormStartPosition.CenterParent;
            Load += OrdenForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnPlatosFuertes;
        private Button btnEntradas;
        private Button btnPostres;
        private Button btnBebidasCalientes;
        private Button btnBebidasFrias;
        private Button button6;
        private PictureBox pictureBox1;
        private Button btneliminar;
        private Button btnenviarorden;
        private Label label1;
        public Label lblTotal;
        public DataGridView dtgProductos;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn SubTotal;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblMesero;
        private Label lblMesa;
        private Label lblCliente;
        private Label lblPedido;
        private Label label6;
    }
}