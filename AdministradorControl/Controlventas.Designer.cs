namespace PollosHermanosRP
{
    partial class Controlventas
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
            dtgventas = new DataGridView();
            lbltotal = new Label();
            label1 = new Label();
            btncerrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgventas).BeginInit();
            SuspendLayout();
            // 
            // dtgventas
            // 
            dtgventas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgventas.Location = new Point(12, 98);
            dtgventas.Name = "dtgventas";
            dtgventas.RowHeadersWidth = 51;
            dtgventas.Size = new Size(757, 256);
            dtgventas.TabIndex = 0;
            // 
            // lbltotal
            // 
            lbltotal.AutoSize = true;
            lbltotal.Font = new Font("Microsoft YaHei", 20F, FontStyle.Bold);
            lbltotal.Location = new Point(12, 385);
            lbltotal.Name = "lbltotal";
            lbltotal.Size = new Size(135, 45);
            lbltotal.TabIndex = 25;
            lbltotal.Text = "TOTAL";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei", 20F, FontStyle.Bold);
            label1.Location = new Point(12, 39);
            label1.Name = "label1";
            label1.Size = new Size(581, 45);
            label1.TabIndex = 26;
            label1.Text = "TABLA CON TODAS LAS VENTAS";
            // 
            // btncerrar
            // 
            btncerrar.BackColor = Color.FromArgb(209, 50, 50);
            btncerrar.Font = new Font("Microsoft YaHei", 11.25F, FontStyle.Bold);
            btncerrar.Location = new Point(587, 385);
            btncerrar.Name = "btncerrar";
            btncerrar.Size = new Size(182, 53);
            btncerrar.TabIndex = 27;
            btncerrar.Text = "Salir";
            btncerrar.UseVisualStyleBackColor = false;
            btncerrar.Click += btncerrar_Click;
            // 
            // Controlventas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(btncerrar);
            Controls.Add(label1);
            Controls.Add(lbltotal);
            Controls.Add(dtgventas);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Controlventas";
            Text = "Controlventas";
            ((System.ComponentModel.ISupportInitialize)dtgventas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgventas;
        private Label lbltotal;
        private Label label1;
        private Button btncerrar;
    }
}