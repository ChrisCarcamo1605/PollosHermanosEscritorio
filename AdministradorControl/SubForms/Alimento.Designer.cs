namespace PollosHermanosRP
{
    partial class Alimento
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
            chkentrada = new CheckBox();
            label3 = new Label();
            chkpostre = new CheckBox();
            chkplatofuerte = new CheckBox();
            SuspendLayout();
            // 
            // chkentrada
            // 
            chkentrada.AutoSize = true;
            chkentrada.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold);
            chkentrada.Location = new Point(10, 32);
            chkentrada.Margin = new Padding(3, 2, 3, 2);
            chkentrada.Name = "chkentrada";
            chkentrada.Size = new Size(91, 26);
            chkentrada.TabIndex = 0;
            chkentrada.Text = "Entrada";
            chkentrada.UseVisualStyleBackColor = true;
            chkentrada.CheckedChanged += chkentrada_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold);
            label3.Location = new Point(10, 7);
            label3.Name = "label3";
            label3.Size = new Size(149, 22);
            label3.TabIndex = 27;
            label3.Text = "Tipo de alimento";
            // 
            // chkpostre
            // 
            chkpostre.AutoSize = true;
            chkpostre.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkpostre.Location = new Point(10, 75);
            chkpostre.Margin = new Padding(3, 2, 3, 2);
            chkpostre.Name = "chkpostre";
            chkpostre.Size = new Size(82, 26);
            chkpostre.TabIndex = 28;
            chkpostre.Text = "Postre";
            chkpostre.UseVisualStyleBackColor = true;
            chkpostre.CheckedChanged += chkpostre_CheckedChanged;
            // 
            // chkplatofuerte
            // 
            chkplatofuerte.AutoSize = true;
            chkplatofuerte.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold);
            chkplatofuerte.Location = new Point(10, 53);
            chkplatofuerte.Margin = new Padding(3, 2, 3, 2);
            chkplatofuerte.Name = "chkplatofuerte";
            chkplatofuerte.Size = new Size(125, 26);
            chkplatofuerte.TabIndex = 29;
            chkplatofuerte.Text = "Plato fuerte";
            chkplatofuerte.UseVisualStyleBackColor = true;
            chkplatofuerte.CheckedChanged += chkplatofuerte_CheckedChanged;
            // 
            // Alimento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightYellow;
            ClientSize = new Size(189, 98);
            Controls.Add(chkplatofuerte);
            Controls.Add(chkpostre);
            Controls.Add(label3);
            Controls.Add(chkentrada);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Alimento";
            Text = "Alimento";
            Load += Alimento_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        public CheckBox chkentrada;
        public CheckBox chkpostre;
        public CheckBox chkplatofuerte;
    }
}