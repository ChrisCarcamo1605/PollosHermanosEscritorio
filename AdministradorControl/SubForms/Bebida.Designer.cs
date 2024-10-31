namespace PollosHermanosRP
{
    partial class Bebida
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
            chkcaliente = new CheckBox();
            label3 = new Label();
            chkfria = new CheckBox();
            SuspendLayout();
            // 
            // chkcaliente
            // 
            chkcaliente.AutoSize = true;
            chkcaliente.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold);
            chkcaliente.Location = new Point(11, 76);
            chkcaliente.Name = "chkcaliente";
            chkcaliente.Size = new Size(116, 31);
            chkcaliente.TabIndex = 33;
            chkcaliente.Text = "Caliente";
            chkcaliente.UseVisualStyleBackColor = true;
            chkcaliente.CheckedChanged += chkcaliente_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold);
            label3.Location = new Point(11, 13);
            label3.Name = "label3";
            label3.Size = new Size(163, 27);
            label3.TabIndex = 31;
            label3.Text = "Tipo de bebida";
            // 
            // chkfria
            // 
            chkfria.AutoSize = true;
            chkfria.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold);
            chkfria.Location = new Point(11, 47);
            chkfria.Name = "chkfria";
            chkfria.Size = new Size(71, 31);
            chkfria.TabIndex = 30;
            chkfria.Text = "Fria";
            chkfria.UseVisualStyleBackColor = true;
            chkfria.CheckedChanged += chkfria_CheckedChanged;
            // 
            // Bebida
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightYellow;
            ClientSize = new Size(181, 105);
            Controls.Add(chkcaliente);
            Controls.Add(label3);
            Controls.Add(chkfria);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Bebida";
            Text = "Bebida";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        public CheckBox chkcaliente;
        public CheckBox chkfria;
    }
}