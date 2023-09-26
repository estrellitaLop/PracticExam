namespace Maestro
{
    partial class frmPrincipal
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
            btnPlanta = new Button();
            btnHora = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnPlanta
            // 
            btnPlanta.Location = new Point(136, 248);
            btnPlanta.Name = "btnPlanta";
            btnPlanta.Size = new Size(150, 46);
            btnPlanta.TabIndex = 0;
            btnPlanta.Text = "Planta";
            btnPlanta.UseVisualStyleBackColor = true;
            btnPlanta.Click += btnPlanta_Click;
            // 
            // btnHora
            // 
            btnHora.Location = new Point(504, 248);
            btnHora.Name = "btnHora";
            btnHora.Size = new Size(150, 46);
            btnHora.TabIndex = 1;
            btnHora.Text = "Hora";
            btnHora.UseVisualStyleBackColor = true;
            btnHora.Click += btnHora_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(293, 95);
            label1.Name = "label1";
            label1.Size = new Size(189, 32);
            label1.TabIndex = 2;
            label1.Text = "Tipo de Maestro";
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnHora);
            Controls.Add(btnPlanta);
            Name = "frmPrincipal";
            Text = "frmPrincipal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPlanta;
        private Button btnHora;
        private Label label1;
    }
}