namespace Estagiado.Views
{
    partial class FormExcluirContaEst
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
            this.cbIdCandidato = new System.Windows.Forms.ComboBox();
            this.btnEncontrarIdComCpf = new System.Windows.Forms.Button();
            this.txtCpfBusca = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvEstudante = new System.Windows.Forms.DataGridView();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.labelSenha = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudante)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.86792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(201, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(396, 40);
            this.label1.TabIndex = 104;
            this.label1.Text = "Tem certeza que deseja excluir sua conta?\r\nIsso apagará permanentemente os seus d" +
    "ados. \r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnExcluirConta
            // 
            this.btnExcluirConta.BackColor = System.Drawing.Color.Red;
            this.btnExcluirConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirConta.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnExcluirConta.Location = new System.Drawing.Point(347, 369);
            this.btnExcluirConta.Name = "btnExcluirConta";
            this.btnExcluirConta.Size = new System.Drawing.Size(113, 46);
            this.btnExcluirConta.TabIndex = 108;
            this.btnExcluirConta.Text = "Excluir Conta";
            this.btnExcluirConta.UseVisualStyleBackColor = false;
            this.btnExcluirConta.Click += new System.EventHandler(this.btnExcluirConta_Click);
            // 
            // cbIdCandidato
            // 
            this.cbIdCandidato.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIdCandidato.FormattingEnabled = true;
            this.cbIdCandidato.Location = new System.Drawing.Point(423, 213);
            this.cbIdCandidato.Name = "cbIdCandidato";
            this.cbIdCandidato.Size = new System.Drawing.Size(37, 26);
            this.cbIdCandidato.TabIndex = 113;
            // 
            // btnEncontrarIdComCpf
            // 
            this.btnEncontrarIdComCpf.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnEncontrarIdComCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncontrarIdComCpf.Location = new System.Drawing.Point(347, 211);
            this.btnEncontrarIdComCpf.Name = "btnEncontrarIdComCpf";
            this.btnEncontrarIdComCpf.Size = new System.Drawing.Size(72, 28);
            this.btnEncontrarIdComCpf.TabIndex = 112;
            this.btnEncontrarIdComCpf.Text = "Buscar";
            this.btnEncontrarIdComCpf.UseVisualStyleBackColor = false;
            this.btnEncontrarIdComCpf.Click += new System.EventHandler(this.btnEncontrarIdComCpf_Click);
            // 
            // txtCpfBusca
            // 
            this.txtCpfBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpfBusca.Location = new System.Drawing.Point(347, 151);
            this.txtCpfBusca.Mask = "000,000,000-00";
            this.txtCpfBusca.Name = "txtCpfBusca";
            this.txtCpfBusca.Size = new System.Drawing.Size(113, 24);
            this.txtCpfBusca.TabIndex = 111;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(346, 125);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 20);
            this.label11.TabIndex = 110;
            this.label11.Text = "Buscar dados";
            // 
            // dgvEstudante
            // 
            this.dgvEstudante.AllowUserToAddRows = false;
            this.dgvEstudante.AllowUserToDeleteRows = false;
            this.dgvEstudante.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvEstudante.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvEstudante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstudante.Location = new System.Drawing.Point(58, 257);
            this.dgvEstudante.Name = "dgvEstudante";
            this.dgvEstudante.ReadOnly = true;
            this.dgvEstudante.RowHeadersWidth = 45;
            this.dgvEstudante.Size = new System.Drawing.Size(691, 91);
            this.dgvEstudante.TabIndex = 109;
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(347, 181);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(113, 24);
            this.txtSenha.TabIndex = 115;
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSenha.Location = new System.Drawing.Point(294, 184);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(53, 21);
            this.labelSenha.TabIndex = 114;
            this.labelSenha.Text = "Senha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(294, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 116;
            this.label2.Text = "CPF";
            // 
            // FormExcluirContaEst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.labelSenha);
            this.Controls.Add(this.cbIdCandidato);
            this.Controls.Add(this.btnEncontrarIdComCpf);
            this.Controls.Add(this.txtCpfBusca);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dgvEstudante);
            this.Controls.Add(this.btnExcluirConta);
            this.Controls.Add(this.label1);
            this.Name = "FormExcluirContaEst";
            this.Text = "Formulário de Exclusão de Conta";
            this.Load += new System.EventHandler(this.FormExcluirContaEst_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudante)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExcluirConta;
        private System.Windows.Forms.Button btnEncontrarIdComCpf;
        private System.Windows.Forms.MaskedTextBox txtCpfBusca;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgvEstudante;
        private System.Windows.Forms.ComboBox cbIdCandidato;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label labelSenha;
        private System.Windows.Forms.Label label2;
    }
}