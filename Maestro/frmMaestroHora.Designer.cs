namespace Maestro
{
    partial class frmMaestroHora
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
            btnAgregar = new Button();
            lstDetalle = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            txtHoras = new TextBox();
            txtCodigo = new TextBox();
            txtEdad = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            label6 = new Label();
            label5 = new Label();
            cboSexo = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label7 = new Label();
            txtSalarioxHora = new TextBox();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(755, 145);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(150, 46);
            btnAgregar.TabIndex = 41;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // lstDetalle
            // 
            lstDetalle.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7 });
            lstDetalle.GridLines = true;
            lstDetalle.Location = new Point(30, 354);
            lstDetalle.Name = "lstDetalle";
            lstDetalle.Size = new Size(976, 405);
            lstDetalle.TabIndex = 40;
            lstDetalle.UseCompatibleStateImageBehavior = false;
            lstDetalle.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Nombre";
            columnHeader1.Width = 180;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Apellido";
            columnHeader2.Width = 180;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Sexo";
            columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Edad";
            columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Codigo";
            columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Salario";
            columnHeader6.Width = 120;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Inss";
            columnHeader7.Width = 120;
            // 
            // txtHoras
            // 
            txtHoras.Location = new Point(544, 288);
            txtHoras.Name = "txtHoras";
            txtHoras.Size = new Size(146, 39);
            txtHoras.TabIndex = 39;
            txtHoras.KeyPress += txtHoras_KeyPress;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(290, 288);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(158, 39);
            txtCodigo.TabIndex = 38;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(92, 288);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(124, 39);
            txtEdad.TabIndex = 37;
            txtEdad.KeyPress += txtEdad_KeyPress;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(299, 164);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(149, 39);
            txtApellido.TabIndex = 36;
            txtApellido.KeyPress += txtApellido_KeyPress;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(92, 164);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(155, 39);
            txtNombre.TabIndex = 35;
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(559, 231);
            label6.Name = "label6";
            label6.Size = new Size(127, 32);
            label6.TabIndex = 34;
            label6.Text = "Horas Trab";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(316, 231);
            label5.Name = "label5";
            label5.Size = new Size(103, 32);
            label5.TabIndex = 33;
            label5.Text = "CODIGO";
            // 
            // cboSexo
            // 
            cboSexo.FormattingEnabled = true;
            cboSexo.Location = new Point(544, 151);
            cboSexo.Name = "cboSexo";
            cboSexo.Size = new Size(146, 40);
            cboSexo.TabIndex = 32;
            cboSexo.Text = "SEXO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(115, 231);
            label4.Name = "label4";
            label4.Size = new Size(74, 32);
            label4.TabIndex = 31;
            label4.Text = "EDAD";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(316, 102);
            label3.Name = "label3";
            label3.Size = new Size(117, 32);
            label3.TabIndex = 30;
            label3.Text = "APELLIDO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(115, 102);
            label2.Name = "label2";
            label2.Size = new Size(112, 32);
            label2.TabIndex = 29;
            label2.Text = "NOMBRE";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(421, 27);
            label1.Name = "label1";
            label1.Size = new Size(212, 32);
            label1.TabIndex = 28;
            label1.Text = "MAESTRO PLANTA";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(747, 231);
            label7.Name = "label7";
            label7.Size = new Size(158, 32);
            label7.TabIndex = 42;
            label7.Text = "Salario x hora";
            // 
            // txtSalarioxHora
            // 
            txtSalarioxHora.Location = new Point(755, 288);
            txtSalarioxHora.Name = "txtSalarioxHora";
            txtSalarioxHora.Size = new Size(142, 39);
            txtSalarioxHora.TabIndex = 43;
            txtSalarioxHora.KeyPress += txtSalarioxHora_KeyPress;
            // 
            // frmMaestroHora
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1018, 797);
            Controls.Add(txtSalarioxHora);
            Controls.Add(label7);
            Controls.Add(btnAgregar);
            Controls.Add(lstDetalle);
            Controls.Add(txtHoras);
            Controls.Add(txtCodigo);
            Controls.Add(txtEdad);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(cboSexo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmMaestroHora";
            Text = "frmMaestroHora";
            Load += frmMaestroHora_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private ListView lstDetalle;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private TextBox txtHoras;
        private TextBox txtCodigo;
        private TextBox txtEdad;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Label label6;
        private Label label5;
        private ComboBox cboSexo;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label7;
        private TextBox txtSalarioxHora;
        private ColumnHeader columnHeader7;
    }
}