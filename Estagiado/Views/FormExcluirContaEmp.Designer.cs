namespace Estagiado.Views
{
    partial class FormExcluirContaEmp
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
            this.btnExcluirConta = new System.Windows.Forms.Button();
            this.btnExcluirVagasAntes = new System.Windows.Forms.Button();
            this.cbIdEmpresa = new System.Windows.Forms.ComboBox();
            this.dgvMinhasVagasEmp = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMinhasVagasEmp)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.86792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(216, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(396, 80);
            this.label1.TabIndex = 103;
            this.label1.Text = "Tem certeza que deseja excluir sua conta?\r\nIsso apagará permanentemente os seus d" +
    "ados. \r\nCaso ainda tenha vagas cadastradas, \r\nexclua-as antes.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnExcluirConta
            // 
            this.btnExcluirConta.BackColor = System.Drawing.Color.Red;
            this.btnExcluirConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirConta.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnExcluirConta.Location = new System.Drawing.Point(354, 368);
            this.btnExcluirConta.Name = "btnExcluirConta";
            this.btnExcluirConta.Size = new System.Drawing.Size(120, 46);
            this.btnExcluirConta.TabIndex = 107;
            this.btnExcluirConta.Text = "Excluir Conta";
            this.btnExcluirConta.UseVisualStyleBackColor = false;
            this.btnExcluirConta.Click += new System.EventHandler(this.btnExcluirConta_Click);
            // 
            // btnExcluirVagasAntes
            // 
            this.btnExcluirVagasAntes.BackColor = System.Drawing.SystemColors.Control;
            this.btnExcluirVagasAntes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F);
            this.btnExcluirVagasAntes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnExcluirVagasAntes.Location = new System.Drawing.Point(331, 260);
            this.btnExcluirVagasAntes.Name = "btnExcluirVagasAntes";
            this.btnExcluirVagasAntes.Size = new System.Drawing.Size(167, 46);
            this.btnExcluirVagasAntes.TabIndex = 108;
            this.btnExcluirVagasAntes.Text = "Excluir Vagas Antes";
            this.btnExcluirVagasAntes.UseVisualStyleBackColor = false;
            this.btnExcluirVagasAntes.Click += new System.EventHandler(this.btnExcluirVagasAntes_Click);
            // 
            // cbIdEmpresa
            // 
            this.cbIdEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F);
            this.cbIdEmpresa.FormattingEnabled = true;
            this.cbIdEmpresa.Location = new System.Drawing.Point(380, 323);
            this.cbIdEmpresa.Name = "cbIdEmpresa";
            this.cbIdEmpresa.Size = new System.Drawing.Size(68, 26);
            this.cbIdEmpresa.TabIndex = 112;
            // 
            // dgvMinhasVagasEmp
            // 
            this.dgvMinhasVagasEmp.AllowUserToAddRows = false;
            this.dgvMinhasVagasEmp.AllowUserToDeleteRows = false;
            this.dgvMinhasVagasEmp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvMinhasVagasEmp.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvMinhasVagasEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMinhasVagasEmp.Location = new System.Drawing.Point(27, 138);
            this.dgvMinhasVagasEmp.Name = "dgvMinhasVagasEmp";
            this.dgvMinhasVagasEmp.ReadOnly = true;
            this.dgvMinhasVagasEmp.RowHeadersWidth = 45;
            this.dgvMinhasVagasEmp.Size = new System.Drawing.Size(744, 101);
            this.dgvMinhasVagasEmp.TabIndex = 113;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 114;
            this.label2.Text = "Minhas Vagas\r\n";
            // 
            // FormExcluirContaEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvMinhasVagasEmp);
            this.Controls.Add(this.cbIdEmpresa);
            this.Controls.Add(this.btnExcluirVagasAntes);
            this.Controls.Add(this.btnExcluirConta);
            this.Controls.Add(this.label1);
            this.Name = "FormExcluirContaEmp";
            this.Text = "Formulário de Exclusão de Conta";
            this.Load += new System.EventHandler(this.FormExcluirContaEmp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMinhasVagasEmp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExcluirConta;
        private System.Windows.Forms.Button btnExcluirVagasAntes;
        private System.Windows.Forms.ComboBox cbIdEmpresa;
        public System.Windows.Forms.DataGridView dgvMinhasVagasEmp;
        private System.Windows.Forms.Label label2;
    }
}