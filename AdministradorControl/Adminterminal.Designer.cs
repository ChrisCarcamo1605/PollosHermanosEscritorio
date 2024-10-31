namespace PollosHermanosRP
{
    partial class Adminterminal
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
            btnabrirempleados = new Button();
            btnabrirmenu = new Button();
            btnSalir = new Button();
            label1 = new Label();
            btnVentas = new Button();
            btnMesas = new Button();
            btnCuentas = new Button();
            SuspendLayout();
            // 
            // btnabrirempleados
            // 
            btnabrirempleados.BackColor = Color.White;
            btnabrirempleados.FlatAppearance.BorderColor = Color.Black;
            btnabrirempleados.FlatAppearance.BorderSize = 2;
            btnabrirempleados.FlatStyle = FlatStyle.Flat;
            btnabrirempleados.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnabrirempleados.Location = new Point(51, 117);
            btnabrirempleados.Name = "btnabrirempleados";
            btnabrirempleados.Size = new Size(199, 103);
            btnabrirempleados.TabIndex = 19;
            btnabrirempleados.Text = "Gestionar Empleados";
            btnabrirempleados.UseVisualStyleBackColor = false;
            btnabrirempleados.Click += btnabrirempleados_Click;
            // 
            // btnabrirmenu
            // 
            btnabrirmenu.BackColor = Color.White;
            btnabrirmenu.FlatAppearance.BorderColor = Color.Black;
            btnabrirmenu.FlatAppearance.BorderSize = 2;
            btnabrirmenu.FlatStyle = FlatStyle.Flat;
            btnabrirmenu.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnabrirmenu.Location = new Point(51, 263);
            btnabrirmenu.Name = "btnabrirmenu";
            btnabrirmenu.Size = new Size(199, 103);
            btnabrirmenu.TabIndex = 20;
            btnabrirmenu.Text = "Gestionar Menu";
            btnabrirmenu.UseVisualStyleBackColor = false;
            btnabrirmenu.Click += btnabrirmenu_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(209, 50, 50);
            btnSalir.FlatAppearance.BorderColor = Color.Black;
            btnSalir.FlatAppearance.BorderSize = 2;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Microsoft YaHei", 11.25F, FontStyle.Bold);
            btnSalir.Location = new Point(545, 263);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(199, 103);
            btnSalir.TabIndex = 21;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei", 20F, FontStyle.Bold);
            label1.Location = new Point(254, 29);
            label1.Name = "label1";
            label1.Size = new Size(329, 45);
            label1.TabIndex = 24;
            label1.Text = "ADMINISTRADOR";
            // 
            // btnVentas
            // 
            btnVentas.BackColor = Color.White;
            btnVentas.FlatAppearance.BorderColor = Color.Black;
            btnVentas.FlatAppearance.BorderSize = 2;
            btnVentas.FlatStyle = FlatStyle.Flat;
            btnVentas.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold);
            btnVentas.Location = new Point(302, 117);
            btnVentas.Margin = new Padding(3, 4, 3, 4);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(199, 103);
            btnVentas.TabIndex = 26;
            btnVentas.Text = "Ventas";
            btnVentas.UseVisualStyleBackColor = false;
            btnVentas.Click += btnVentas_Click;
            // 
            // btnMesas
            // 
            btnMesas.BackColor = Color.White;
            btnMesas.FlatAppearance.BorderColor = Color.Black;
            btnMesas.FlatAppearance.BorderSize = 2;
            btnMesas.FlatStyle = FlatStyle.Flat;
            btnMesas.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold);
            btnMesas.Location = new Point(545, 117);
            btnMesas.Margin = new Padding(3, 4, 3, 4);
            btnMesas.Name = "btnMesas";
            btnMesas.Size = new Size(199, 103);
            btnMesas.TabIndex = 27;
            btnMesas.Text = "Mesas";
            btnMesas.UseVisualStyleBackColor = false;
            btnMesas.Click += button2_Click;
            // 
            // btnCuentas
            // 
            btnCuentas.BackColor = Color.White;
            btnCuentas.FlatAppearance.BorderColor = Color.Black;
            btnCuentas.FlatAppearance.BorderSize = 2;
            btnCuentas.FlatStyle = FlatStyle.Flat;
            btnCuentas.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold);
            btnCuentas.Location = new Point(302, 263);
            btnCuentas.Margin = new Padding(3, 4, 3, 4);
            btnCuentas.Name = "btnCuentas";
            btnCuentas.Size = new Size(199, 103);
            btnCuentas.TabIndex = 28;
            btnCuentas.Text = "Cuentas";
            btnCuentas.UseVisualStyleBackColor = false;
            btnCuentas.Click += btnCuentas_Click;
            // 
            // Adminterminal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightYellow;
            ClientSize = new Size(799, 437);
            Controls.Add(btnCuentas);
            Controls.Add(btnMesas);
            Controls.Add(btnVentas);
            Controls.Add(btnSalir);
            Controls.Add(btnabrirmenu);
            Controls.Add(btnabrirempleados);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Adminterminal";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Adminterminal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnabrirempleados;
        private Button btnabrirmenu;
        private Button btnSalir;
        private Label label1;
        private Button btnVentas;
        private Button btnMesas;
        private Button btnCuentas;
    }
}