namespace CapaVista
{
    partial class CRUD
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRUD));
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            groupBox1 = new GroupBox();
            txtFolio = new TextBox();
            label9 = new Label();
            btnGuardar = new Button();
            btnNuevo = new Button();
            txtColonia = new TextBox();
            txtCasa = new TextBox();
            txtCalle = new TextBox();
            txtMaterno = new TextBox();
            txtPaterno = new TextBox();
            txtNombre = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            tabPage2 = new TabPage();
            lblTotal = new Label();
            dataListado = new DataGridView();
            btnBuscar = new Button();
            txtBuscar = new TextBox();
            label8 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataListado).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(24, 20);
            label1.Name = "label1";
            label1.Size = new Size(175, 36);
            label1.TabIndex = 0;
            label1.Text = "Practica #2";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 73);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(807, 327);
            tabControl1.TabIndex = 2;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(799, 294);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Formulario";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtFolio);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Controls.Add(btnNuevo);
            groupBox1.Controls.Add(txtColonia);
            groupBox1.Controls.Add(txtCasa);
            groupBox1.Controls.Add(txtCalle);
            groupBox1.Controls.Add(txtMaterno);
            groupBox1.Controls.Add(txtPaterno);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(8, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(785, 282);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Registro";
            // 
            // txtFolio
            // 
            txtFolio.BackColor = SystemColors.Info;
            txtFolio.Enabled = false;
            txtFolio.Location = new Point(102, 26);
            txtFolio.Name = "txtFolio";
            txtFolio.Size = new Size(232, 27);
            txtFolio.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(46, 29);
            label9.Name = "label9";
            label9.Size = new Size(45, 20);
            label9.TabIndex = 15;
            label9.Text = "Folio:";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(283, 215);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 13;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(383, 215);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(94, 29);
            btnNuevo.TabIndex = 12;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // txtColonia
            // 
            txtColonia.Location = new Point(470, 147);
            txtColonia.Name = "txtColonia";
            txtColonia.Size = new Size(232, 27);
            txtColonia.TabIndex = 5;
            txtColonia.KeyDown += txtColonia_KeyDown;
            // 
            // txtCasa
            // 
            txtCasa.Location = new Point(470, 99);
            txtCasa.Name = "txtCasa";
            txtCasa.Size = new Size(232, 27);
            txtCasa.TabIndex = 4;
            txtCasa.KeyDown += txtCasa_KeyDown;
            // 
            // txtCalle
            // 
            txtCalle.Location = new Point(470, 63);
            txtCalle.Name = "txtCalle";
            txtCalle.Size = new Size(232, 27);
            txtCalle.TabIndex = 3;
            txtCalle.KeyDown += txtCalle_KeyDown;
            // 
            // txtMaterno
            // 
            txtMaterno.Location = new Point(102, 151);
            txtMaterno.Name = "txtMaterno";
            txtMaterno.Size = new Size(232, 27);
            txtMaterno.TabIndex = 2;
            txtMaterno.KeyDown += txtMaterno_KeyDown;
            // 
            // txtPaterno
            // 
            txtPaterno.Location = new Point(102, 105);
            txtPaterno.Name = "txtPaterno";
            txtPaterno.Size = new Size(232, 27);
            txtPaterno.TabIndex = 1;
            txtPaterno.KeyDown += txtPaterno_KeyDown;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(102, 66);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(232, 27);
            txtNombre.TabIndex = 0;
            txtNombre.KeyDown += txtNombre_KeyDown;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(401, 154);
            label7.Name = "label7";
            label7.Size = new Size(63, 20);
            label7.TabIndex = 5;
            label7.Text = "Colonia:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(351, 105);
            label6.Name = "label6";
            label6.Size = new Size(120, 20);
            label6.TabIndex = 4;
            label6.Text = "Número de casa:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(419, 66);
            label5.Name = "label5";
            label5.Size = new Size(45, 20);
            label5.TabIndex = 3;
            label5.Text = "Calle:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 154);
            label4.Name = "label4";
            label4.Size = new Size(94, 20);
            label4.TabIndex = 2;
            label4.Text = "Ap. Materno:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 105);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 1;
            label3.Text = "Ap. Paterno:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 66);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 0;
            label2.Text = "Nombre(s):";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(lblTotal);
            tabPage2.Controls.Add(dataListado);
            tabPage2.Controls.Add(btnBuscar);
            tabPage2.Controls.Add(txtBuscar);
            tabPage2.Controls.Add(label8);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(799, 294);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Reporte";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(567, 38);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(50, 20);
            lblTotal.TabIndex = 12;
            lblTotal.Text = "label9";
            // 
            // dataListado
            // 
            dataListado.AllowUserToAddRows = false;
            dataListado.AllowUserToDeleteRows = false;
            dataListado.AllowUserToOrderColumns = true;
            dataListado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataListado.Location = new Point(17, 69);
            dataListado.MultiSelect = false;
            dataListado.Name = "dataListado";
            dataListado.ReadOnly = true;
            dataListado.RowHeadersWidth = 51;
            dataListado.RowTemplate.Height = 29;
            dataListado.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataListado.Size = new Size(776, 188);
            dataListado.TabIndex = 11;
            dataListado.DoubleClick += dataListado_DoubleClick;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(379, 34);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 29);
            btnBuscar.TabIndex = 9;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(111, 33);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(232, 27);
            txtBuscar.TabIndex = 8;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(17, 33);
            label8.Name = "label8";
            label8.Size = new Size(83, 20);
            label8.TabIndex = 7;
            label8.Text = "Nombre(s):";
            // 
            // CRUD
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(831, 412);
            Controls.Add(tabControl1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "CRUD";
            StartPosition = FormStartPosition.CenterScreen;
            Load += CRUD_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataListado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private GroupBox groupBox1;
        private TextBox txtColonia;
        private TextBox txtCasa;
        private TextBox txtCalle;
        private TextBox txtMaterno;
        private TextBox txtPaterno;
        private TextBox txtNombre;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnGuardar;
        private Button btnNuevo;
        private Button btnBuscar;
        private TextBox txtBuscar;
        private Label label8;
        private DataGridView dataListado;
        private Label lblTotal;
        private TextBox txtFolio;
        private Label label9;
    }
}