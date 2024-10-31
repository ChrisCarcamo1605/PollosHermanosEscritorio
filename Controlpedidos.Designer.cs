namespace PollosHermanosRP
{
    partial class Controlpedidos
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
            dtgpedidos = new DataGridView();
            label1 = new Label();
            btnsalir = new Button();
            chkefectivo = new CheckBox();
            chktarjeta = new CheckBox();
            btncancelar = new Button();
            txtbuscar = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dtgpedidos).BeginInit();
            SuspendLayout();
            // 
            // dtgpedidos
            // 
            dtgpedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgpedidos.Location = new Point(60, 154);
            dtgpedidos.Name = "dtgpedidos";
            dtgpedidos.RowHeadersWidth = 51;
            dtgpedidos.Size = new Size(778, 277);
            dtgpedidos.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei", 20F, FontStyle.Bold);
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(412, 45);
            label1.TabIndex = 25;
            label1.Text = "CONTROL DE PEDIDOS";
            // 
            // btnsalir
            // 
            btnsalir.BackColor = Color.FromArgb(209, 50, 50);
            btnsalir.Font = new Font("Microsoft YaHei", 11.25F, FontStyle.Bold);
            btnsalir.Location = new Point(718, 459);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(182, 53);
            btnsalir.TabIndex = 26;
            btnsalir.Text = "Salir";
            btnsalir.UseVisualStyleBackColor = false;
            btnsalir.Click += btnsalir_Click;
            // 
            // chkefectivo
            // 
            chkefectivo.AutoSize = true;
            chkefectivo.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold);
            chkefectivo.Location = new Point(458, 65);
            chkefectivo.Name = "chkefectivo";
            chkefectivo.Size = new Size(114, 31);
            chkefectivo.TabIndex = 31;
            chkefectivo.Text = "Efectivo";
            chkefectivo.UseVisualStyleBackColor = true;
            chkefectivo.CheckedChanged += chkefectivo_CheckedChanged;
            // 
            // chktarjeta
            // 
            chktarjeta.AutoSize = true;
            chktarjeta.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold);
            chktarjeta.Location = new Point(458, 34);
            chktarjeta.Name = "chktarjeta";
            chktarjeta.Size = new Size(105, 31);
            chktarjeta.TabIndex = 30;
            chktarjeta.Text = "Tarjeta";
            chktarjeta.UseVisualStyleBackColor = true;
            chktarjeta.CheckedChanged += chktarjeta_CheckedChanged;
            // 
            // btncancelar
            // 
            btncancelar.BackColor = Color.FromArgb(128, 128, 255);
            btncancelar.Font = new Font("Microsoft YaHei", 11.25F, FontStyle.Bold);
            btncancelar.Location = new Point(31, 459);
            btncancelar.Name = "btncancelar";
            btncancelar.Size = new Size(182, 53);
            btncancelar.TabIndex = 32;
            btncancelar.Text = "Cancelar";
            btncancelar.UseVisualStyleBackColor = false;
            btncancelar.Click += btncancelar_Click;
            // 
            // txtbuscar
            // 
            txtbuscar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbuscar.ForeColor = Color.Black;
            txtbuscar.Location = new Point(60, 121);
            txtbuscar.Name = "txtbuscar";
            txtbuscar.Size = new Size(177, 27);
            txtbuscar.TabIndex = 33;
            txtbuscar.TextChanged += txtbuscar_TextChanged;
            // 
            // Controlpedidos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(912, 524);
            Controls.Add(txtbuscar);
            Controls.Add(btncancelar);
            Controls.Add(chkefectivo);
            Controls.Add(chktarjeta);
            Controls.Add(btnsalir);
            Controls.Add(label1);
            Controls.Add(dtgpedidos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Controlpedidos";
            Text = "Controlpedidos";
            ((System.ComponentModel.ISupportInitialize)dtgpedidos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgpedidos;
        private Label label1;
        private Button btnsalir;
        private Button btncancelar;
        private TextBox txtbuscar;
        public CheckBox chkefectivo;
        public CheckBox chktarjeta;
    }
}