namespace Estagiado
{
    partial class FormMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAreaEmpresa = new System.Windows.Forms.Button();
            this.btnAreaEstudante = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18.33962F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(252, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bem-vindo ao Sistema ";
            // 
            // btnAreaEmpresa
            // 
            this.btnAreaEmpresa.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAreaEmpresa.Font = new System.Drawing.Font("Segoe UI", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAreaEmpresa.Location = new System.Drawing.Point(57, 171);
            this.btnAreaEmpresa.Name = "btnAreaEmpresa";
            this.btnAreaEmpresa.Size = new System.Drawing.Size(305, 112);
            this.btnAreaEmpresa.TabIndex = 1;
            this.btnAreaEmpresa.Text = "Área da Empresa";
            this.btnAreaEmpresa.UseVisualStyleBackColor = false;
            this.btnAreaEmpresa.Click += new System.EventHandler(this.btnAreaEmpresa_Click);
            // 
            // btnAreaEstudante
            // 
            this.btnAreaEstudante.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAreaEstudante.Font = new System.Drawing.Font("Segoe UI", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAreaEstudante.Location = new System.Drawing.Point(436, 171);
            this.btnAreaEstudante.Name = "btnAreaEstudante";
            this.btnAreaEstudante.Size = new System.Drawing.Size(305, 112);
            this.btnAreaEstudante.TabIndex = 2;
            this.btnAreaEstudante.Text = "Área do Estudante";
            this.btnAreaEstudante.UseVisualStyleBackColor = false;
            this.btnAreaEstudante.Click += new System.EventHandler(this.btnAreaEstudante_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAreaEstudante);
            this.Controls.Add(this.btnAreaEmpresa);
            this.Controls.Add(this.label1);
            this.Name = "FormMain";
            this.Text = "Estagiado";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAreaEmpresa;
        private System.Windows.Forms.Button btnAreaEstudante;
    }
}