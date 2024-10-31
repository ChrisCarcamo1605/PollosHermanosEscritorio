namespace PollosHermanosRP.AdministradorControl
{
    partial class GestionMesas
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
            btnAgregarMesa = new Button();
            cbAreas = new ComboBox();
            label1 = new Label();
            txtNoMesa = new TextBox();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            btnEliminarMesa = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnAgregarMesa
            // 
            btnAgregarMesa.BackColor = Color.White;
            btnAgregarMesa.FlatAppearance.BorderColor = Color.Black;
            btnAgregarMesa.FlatAppearance.BorderSize = 2;
            btnAgregarMesa.FlatStyle = FlatStyle.Flat;
            btnAgregarMesa.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnAgregarMesa.Location = new Point(530, 61);
            btnAgregarMesa.Name = "btnAgregarMesa";
            btnAgregarMesa.Size = new Size(135, 56);
            btnAgregarMesa.TabIndex = 1;
            btnAgregarMesa.Text = "Agregar Mesa";
            btnAgregarMesa.UseVisualStyleBackColor = false;
            btnAgregarMesa.Click += btnAgregarMesa_Click;
            // 
            // cbAreas
            // 
            cbAreas.DropDownStyle = ComboBoxStyle.DropDownList;
            cbAreas.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbAreas.FormattingEnabled = true;
            cbAreas.ImeMode = ImeMode.NoControl;
            cbAreas.Items.AddRange(new object[] { "A", "B", "C", "D", "E" });
            cbAreas.Location = new Point(185, 78);
            cbAreas.Name = "cbAreas";
            cbAreas.Size = new Size(91, 31);
            cbAreas.TabIndex = 3;
            cbAreas.SelectedIndexChanged += cbAreas_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F);
            label1.Location = new Point(43, 73);
            label1.Name = "label1";
            label1.Size = new Size(128, 24);
            label1.TabIndex = 4;
            label1.Text = "Area de Mesa";
            // 
            // txtNoMesa
            // 
            txtNoMesa.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNoMesa.Location = new Point(419, 73);
            txtNoMesa.Name = "txtNoMesa";
            txtNoMesa.Size = new Size(91, 33);
            txtNoMesa.TabIndex = 5;
            txtNoMesa.TextChanged += txtNoMesa_TextChanged;
            txtNoMesa.KeyPress += txtNoMesa_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14.25F);
            label2.Location = new Point(283, 73);
            label2.Name = "label2";
            label2.Size = new Size(130, 24);
            label2.TabIndex = 6;
            label2.Text = "Numero Mesa";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei", 20F, FontStyle.Bold);
            label3.Location = new Point(207, 19);
            label3.Name = "label3";
            label3.Size = new Size(285, 36);
            label3.TabIndex = 7;
            label3.Text = "GESTION DE MESAS";
            label3.Click += label3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(209, 50, 50);
            button1.FlatAppearance.BorderColor = Color.Black;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(530, 247);
            button1.Name = "button1";
            button1.Size = new Size(135, 56);
            button1.TabIndex = 8;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(43, 115);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(467, 192);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnEliminarMesa
            // 
            btnEliminarMesa.BackColor = Color.White;
            btnEliminarMesa.FlatAppearance.BorderColor = Color.Black;
            btnEliminarMesa.FlatAppearance.BorderSize = 2;
            btnEliminarMesa.FlatStyle = FlatStyle.Flat;
            btnEliminarMesa.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnEliminarMesa.Location = new Point(530, 123);
            btnEliminarMesa.Name = "btnEliminarMesa";
            btnEliminarMesa.Size = new Size(135, 56);
            btnEliminarMesa.TabIndex = 2;
            btnEliminarMesa.Text = "Eliminar Mesa";
            btnEliminarMesa.UseVisualStyleBackColor = false;
            btnEliminarMesa.Click += btnEliminarMesa_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.FlatAppearance.BorderColor = Color.Black;
            button2.FlatAppearance.BorderSize = 2;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(530, 185);
            button2.Name = "button2";
            button2.Size = new Size(135, 56);
            button2.TabIndex = 10;
            button2.Text = "Activar/Desactivar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // GestionMesas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightYellow;
            ClientSize = new Size(714, 336);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtNoMesa);
            Controls.Add(label1);
            Controls.Add(cbAreas);
            Controls.Add(btnEliminarMesa);
            Controls.Add(btnAgregarMesa);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GestionMesas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GestionMesas";
            Load += GestionMesas_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAgregarMesa;
        private ComboBox cbAreas;
        private Label label1;
        private TextBox txtNoMesa;
        private Label label2;
        private Label label3;
        private Button button1;
        private DataGridView dataGridView1;
        private Button btnEliminarMesa;
        private Button button2;
    }
}