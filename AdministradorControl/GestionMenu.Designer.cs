namespace PollosHermanosRP
{
    partial class GestionMenu
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
            dtgelementos = new DataGridView();
            pictureBox1 = new PictureBox();
            btnagregar = new Button();
            btneliminar = new Button();
            btnactualizar = new Button();
            btnsalir = new Button();
            txtbuscar = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtnombreelemento = new TextBox();
            txtprecio = new TextBox();
            label3 = new Label();
            chkbebida = new CheckBox();
            chkalimento = new CheckBox();
            panel1 = new Panel();
            label4 = new Label();
            txtdescripcion = new TextBox();
            btncambiaractivo = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgelementos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dtgelementos
            // 
            dtgelementos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dtgelementos.ColumnHeadersHeight = 29;
            dtgelementos.Location = new Point(14, 324);
            dtgelementos.MultiSelect = false;
            dtgelementos.Name = "dtgelementos";
            dtgelementos.ReadOnly = true;
            dtgelementos.RowHeadersWidth = 51;
            dtgelementos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgelementos.Size = new Size(830, 253);
            dtgelementos.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.los_pollos_hermanos_logo_E4DCC13511_seeklogo_com;
            pictureBox1.Location = new Point(850, 309);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(258, 265);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btnagregar
            // 
            btnagregar.BackColor = Color.Black;
            btnagregar.Font = new Font("Microsoft YaHei", 11.25F, FontStyle.Bold);
            btnagregar.ForeColor = Color.White;
            btnagregar.Location = new Point(917, 27);
            btnagregar.Name = "btnagregar";
            btnagregar.Size = new Size(182, 59);
            btnagregar.TabIndex = 17;
            btnagregar.Text = "Agregar";
            btnagregar.UseVisualStyleBackColor = false;
            btnagregar.Click += btnagregar_Click;
            // 
            // btneliminar
            // 
            btneliminar.BackColor = Color.Black;
            btneliminar.Font = new Font("Microsoft YaHei", 11.25F, FontStyle.Bold);
            btneliminar.ForeColor = Color.White;
            btneliminar.Location = new Point(917, 141);
            btneliminar.Name = "btneliminar";
            btneliminar.Size = new Size(182, 59);
            btneliminar.TabIndex = 18;
            btneliminar.Text = "Eliminar";
            btneliminar.UseVisualStyleBackColor = false;
            btneliminar.Click += btneliminar_Click;
            // 
            // btnactualizar
            // 
            btnactualizar.BackColor = Color.Black;
            btnactualizar.Font = new Font("Microsoft YaHei", 11.25F, FontStyle.Bold);
            btnactualizar.ForeColor = Color.White;
            btnactualizar.Location = new Point(917, 84);
            btnactualizar.Name = "btnactualizar";
            btnactualizar.Size = new Size(182, 59);
            btnactualizar.TabIndex = 19;
            btnactualizar.Text = "Actualizar";
            btnactualizar.UseVisualStyleBackColor = false;
            btnactualizar.Click += btnactualizar_Click;
            // 
            // btnsalir
            // 
            btnsalir.BackColor = Color.FromArgb(209, 50, 50);
            btnsalir.Font = new Font("Microsoft YaHei", 11.25F, FontStyle.Bold);
            btnsalir.Location = new Point(917, 203);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(182, 53);
            btnsalir.TabIndex = 20;
            btnsalir.Text = "Salir";
            btnsalir.UseVisualStyleBackColor = false;
            btnsalir.Click += btnsalir_Click;
            // 
            // txtbuscar
            // 
            txtbuscar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbuscar.ForeColor = Color.Black;
            txtbuscar.Location = new Point(568, 285);
            txtbuscar.Name = "txtbuscar";
            txtbuscar.Size = new Size(177, 27);
            txtbuscar.TabIndex = 22;
            txtbuscar.TextChanged += txtbuscar_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei", 20F, FontStyle.Bold);
            label1.Location = new Point(267, 12);
            label1.Name = "label1";
            label1.Size = new Size(306, 45);
            label1.TabIndex = 23;
            label1.Text = "Edicion de Menu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold);
            label2.Location = new Point(14, 73);
            label2.Name = "label2";
            label2.Size = new Size(228, 27);
            label2.TabIndex = 24;
            label2.Text = "Nombre de elemento";
            // 
            // txtnombreelemento
            // 
            txtnombreelemento.Location = new Point(248, 75);
            txtnombreelemento.Name = "txtnombreelemento";
            txtnombreelemento.Size = new Size(231, 27);
            txtnombreelemento.TabIndex = 25;
            txtnombreelemento.TextChanged += txtnombreelemento_TextChanged;
            txtnombreelemento.KeyPress += txtnombreelemento_KeyPress;
            // 
            // txtprecio
            // 
            txtprecio.Location = new Point(248, 112);
            txtprecio.Name = "txtprecio";
            txtprecio.Size = new Size(231, 27);
            txtprecio.TabIndex = 27;
            txtprecio.KeyPress += txtprecio_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold);
            label3.Location = new Point(168, 112);
            label3.Name = "label3";
            label3.Size = new Size(74, 27);
            label3.TabIndex = 26;
            label3.Text = "Precio";
            // 
            // chkbebida
            // 
            chkbebida.AutoSize = true;
            chkbebida.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold);
            chkbebida.Location = new Point(537, 77);
            chkbebida.Name = "chkbebida";
            chkbebida.Size = new Size(104, 31);
            chkbebida.TabIndex = 28;
            chkbebida.Text = "Bebida";
            chkbebida.UseVisualStyleBackColor = true;
            chkbebida.CheckedChanged += chkbebida_CheckedChanged;
            // 
            // chkalimento
            // 
            chkalimento.AutoSize = true;
            chkalimento.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold);
            chkalimento.Location = new Point(537, 108);
            chkalimento.Name = "chkalimento";
            chkalimento.Size = new Size(127, 31);
            chkalimento.TabIndex = 29;
            chkalimento.Text = "Alimento";
            chkalimento.UseVisualStyleBackColor = true;
            chkalimento.CheckedChanged += chkalimento_CheckedChanged;
            // 
            // panel1
            // 
            panel1.Location = new Point(663, 57);
            panel1.Name = "panel1";
            panel1.Size = new Size(216, 131);
            panel1.TabIndex = 30;
            panel1.Paint += panel1_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold);
            label4.Location = new Point(14, 136);
            label4.Name = "label4";
            label4.Size = new Size(129, 27);
            label4.TabIndex = 31;
            label4.Text = "Descripcion";
            // 
            // txtdescripcion
            // 
            txtdescripcion.Location = new Point(11, 165);
            txtdescripcion.Multiline = true;
            txtdescripcion.Name = "txtdescripcion";
            txtdescripcion.Size = new Size(534, 149);
            txtdescripcion.TabIndex = 32;
            txtdescripcion.KeyPress += txtdescripcion_KeyPress;
            // 
            // btncambiaractivo
            // 
            btncambiaractivo.BackColor = Color.Black;
            btncambiaractivo.Font = new Font("Microsoft YaHei", 11.25F, FontStyle.Bold);
            btncambiaractivo.ForeColor = Color.White;
            btncambiaractivo.Location = new Point(557, 220);
            btncambiaractivo.Name = "btncambiaractivo";
            btncambiaractivo.Size = new Size(287, 59);
            btncambiaractivo.TabIndex = 33;
            btncambiaractivo.Text = "Cambiar estado de activo";
            btncambiaractivo.UseVisualStyleBackColor = false;
            btncambiaractivo.Click += btncambiaractivo_Click;
            // 
            // GestionMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightYellow;
            ClientSize = new Size(1136, 589);
            Controls.Add(btncambiaractivo);
            Controls.Add(txtdescripcion);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(chkalimento);
            Controls.Add(chkbebida);
            Controls.Add(txtprecio);
            Controls.Add(label3);
            Controls.Add(txtnombreelemento);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtbuscar);
            Controls.Add(btnsalir);
            Controls.Add(btnactualizar);
            Controls.Add(btneliminar);
            Controls.Add(btnagregar);
            Controls.Add(pictureBox1);
            Controls.Add(dtgelementos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GestionMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Addelement";
            Load += Addelement_Load;
            ((System.ComponentModel.ISupportInitialize)dtgelementos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgelementos;
        private PictureBox pictureBox1;
        private Button btnagregar;
        private Button btneliminar;
        private Button btnactualizar;
        private Button btnsalir;
        private TextBox txtbuscar;
        private Label label1;
        private Label label2;
        private TextBox txtnombreelemento;
        private TextBox txtprecio;
        private Label label3;
        private CheckBox chkbebida;
        private CheckBox chkalimento;
        private Panel panel1;
        private Label label4;
        private TextBox txtdescripcion;
        private Button btncambiaractivo;
    }
}