namespace PollosHermanosRP
{
    partial class Tipodepago
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
            btnpagoefectivo = new Button();
            btnpagotarjeta = new Button();
            label4 = new Label();
            button1 = new Button();
            lblTotal = new Label();
            button6 = new Button();
            SuspendLayout();
            // 
            // btnpagoefectivo
            // 
            btnpagoefectivo.BackColor = Color.FromArgb(33, 30, 30);
            btnpagoefectivo.FlatAppearance.BorderColor = Color.White;
            btnpagoefectivo.FlatAppearance.BorderSize = 2;
            btnpagoefectivo.FlatAppearance.CheckedBackColor = Color.FromArgb(0, 0, 0, 0);
            btnpagoefectivo.FlatStyle = FlatStyle.Flat;
            btnpagoefectivo.Font = new Font("Microsoft Sans Serif", 14.25F);
            btnpagoefectivo.ForeColor = SystemColors.Control;
            btnpagoefectivo.Location = new Point(294, 198);
            btnpagoefectivo.Name = "btnpagoefectivo";
            btnpagoefectivo.Size = new Size(224, 90);
            btnpagoefectivo.TabIndex = 17;
            btnpagoefectivo.Text = "Pago Efectivo";
            btnpagoefectivo.UseVisualStyleBackColor = false;
            btnpagoefectivo.Click += btnpagoefectivo_Click;
            // 
            // btnpagotarjeta
            // 
            btnpagotarjeta.BackColor = Color.FromArgb(33, 30, 30);
            btnpagotarjeta.FlatAppearance.BorderColor = Color.White;
            btnpagotarjeta.FlatAppearance.BorderSize = 2;
            btnpagotarjeta.FlatAppearance.CheckedBackColor = Color.FromArgb(0, 0, 0, 0);
            btnpagotarjeta.FlatStyle = FlatStyle.Flat;
            btnpagotarjeta.Font = new Font("Microsoft Sans Serif", 14.25F);
            btnpagotarjeta.ForeColor = SystemColors.Control;
            btnpagotarjeta.Location = new Point(294, 104);
            btnpagotarjeta.Name = "btnpagotarjeta";
            btnpagotarjeta.Size = new Size(224, 90);
            btnpagotarjeta.TabIndex = 16;
            btnpagotarjeta.Text = "Pago Tarjeta";
            btnpagotarjeta.UseVisualStyleBackColor = false;
            btnpagotarjeta.Click += btnCuentaExistente_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft YaHei", 14F, FontStyle.Bold);
            label4.Location = new Point(241, 32);
            label4.Name = "label4";
            label4.Size = new Size(337, 31);
            label4.TabIndex = 31;
            label4.Text = "Escoja un metodo de pago";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(33, 30, 30);
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatAppearance.CheckedBackColor = Color.FromArgb(0, 0, 0, 0);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 14.25F);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(294, 294);
            button1.Name = "button1";
            button1.Size = new Size(224, 90);
            button1.TabIndex = 32;
            button1.Text = "Pago Mixto";
            button1.UseVisualStyleBackColor = false;
            // 
            // lblTotal
            // 
            lblTotal.AccessibleRole = AccessibleRole.Grip;
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Microsoft YaHei", 14F, FontStyle.Bold);
            lblTotal.Location = new Point(56, 391);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(174, 31);
            lblTotal.TabIndex = 33;
            lblTotal.Text = "Total a pagar";
            lblTotal.Click += lblTotal_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(209, 50, 50);
            button6.FlatAppearance.BorderColor = Color.Black;
            button6.FlatAppearance.BorderSize = 2;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            button6.Location = new Point(695, 439);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(118, 42);
            button6.TabIndex = 36;
            button6.Text = "Salir";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // Tipodepago
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(825, 494);
            Controls.Add(button6);
            Controls.Add(lblTotal);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(btnpagoefectivo);
            Controls.Add(btnpagotarjeta);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Tipodepago";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tipodepago";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnpagoefectivo;
        private Button btnpagotarjeta;
        private Label label4;
        private Button button1;
        private Label lblTotal;
        private Button button6;
    }
}