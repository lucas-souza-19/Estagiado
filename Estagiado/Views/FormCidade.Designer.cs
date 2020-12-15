namespace Estagiado.Views
{
    partial class FormCidade
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
            this.txtNomeCidade = new System.Windows.Forms.TextBox();
            this.labelNomeCidade = new System.Windows.Forms.Label();
            this.labelEnderecoCidade = new System.Windows.Forms.Label();
            this.txtEnderecoCidade = new System.Windows.Forms.TextBox();
            this.txtNumeroCidade = new System.Windows.Forms.TextBox();
            this.labelNumeroCidade = new System.Windows.Forms.Label();
            this.labelBairroCidade = new System.Windows.Forms.Label();
            this.txtBairroCidade = new System.Windows.Forms.TextBox();
            this.labelRuaCidade = new System.Windows.Forms.Label();
            this.txtRuaCidade = new System.Windows.Forms.TextBox();
            this.labelEstadoCidade = new System.Windows.Forms.Label();
            this.cbEstadoCidade = new System.Windows.Forms.ComboBox();
            this.labelNacaoCidade = new System.Windows.Forms.Label();
            this.txtNacaoCidade = new System.Windows.Forms.TextBox();
            this.txtIdCidade = new System.Windows.Forms.TextBox();
            this.labelIdCidade = new System.Windows.Forms.Label();
            this.btnExcluirCidade = new System.Windows.Forms.Button();
            this.btnAlterarCidade = new System.Windows.Forms.Button();
            this.btnCadastrarCidade = new System.Windows.Forms.Button();
            this.dgvCidade = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCidade)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNomeCidade
            // 
            this.txtNomeCidade.Location = new System.Drawing.Point(120, 48);
            this.txtNomeCidade.Name = "txtNomeCidade";
            this.txtNomeCidade.Size = new System.Drawing.Size(269, 20);
            this.txtNomeCidade.TabIndex = 0;
            // 
            // labelNomeCidade
            // 
            this.labelNomeCidade.AutoSize = true;
            this.labelNomeCidade.Location = new System.Drawing.Point(47, 51);
            this.labelNomeCidade.Name = "labelNomeCidade";
            this.labelNomeCidade.Size = new System.Drawing.Size(46, 15);
            this.labelNomeCidade.TabIndex = 1;
            this.labelNomeCidade.Text = "Cidade";
            // 
            // labelEnderecoCidade
            // 
            this.labelEnderecoCidade.AutoSize = true;
            this.labelEnderecoCidade.Location = new System.Drawing.Point(50, 99);
            this.labelEnderecoCidade.Name = "labelEnderecoCidade";
            this.labelEnderecoCidade.Size = new System.Drawing.Size(60, 15);
            this.labelEnderecoCidade.TabIndex = 2;
            this.labelEnderecoCidade.Text = "Endereço";
            // 
            // txtEnderecoCidade
            // 
            this.txtEnderecoCidade.Location = new System.Drawing.Point(120, 94);
            this.txtEnderecoCidade.Name = "txtEnderecoCidade";
            this.txtEnderecoCidade.Size = new System.Drawing.Size(269, 20);
            this.txtEnderecoCidade.TabIndex = 3;
            // 
            // txtNumeroCidade
            // 
            this.txtNumeroCidade.Location = new System.Drawing.Point(120, 139);
            this.txtNumeroCidade.Name = "txtNumeroCidade";
            this.txtNumeroCidade.Size = new System.Drawing.Size(269, 20);
            this.txtNumeroCidade.TabIndex = 4;
            // 
            // labelNumeroCidade
            // 
            this.labelNumeroCidade.AutoSize = true;
            this.labelNumeroCidade.Location = new System.Drawing.Point(50, 144);
            this.labelNumeroCidade.Name = "labelNumeroCidade";
            this.labelNumeroCidade.Size = new System.Drawing.Size(52, 15);
            this.labelNumeroCidade.TabIndex = 5;
            this.labelNumeroCidade.Text = "Número";
            // 
            // labelBairroCidade
            // 
            this.labelBairroCidade.AutoSize = true;
            this.labelBairroCidade.Location = new System.Drawing.Point(50, 192);
            this.labelBairroCidade.Name = "labelBairroCidade";
            this.labelBairroCidade.Size = new System.Drawing.Size(40, 15);
            this.labelBairroCidade.TabIndex = 7;
            this.labelBairroCidade.Text = "Bairro";
            // 
            // txtBairroCidade
            // 
            this.txtBairroCidade.Location = new System.Drawing.Point(120, 187);
            this.txtBairroCidade.Name = "txtBairroCidade";
            this.txtBairroCidade.Size = new System.Drawing.Size(269, 20);
            this.txtBairroCidade.TabIndex = 6;
            // 
            // labelRuaCidade
            // 
            this.labelRuaCidade.AutoSize = true;
            this.labelRuaCidade.Location = new System.Drawing.Point(50, 241);
            this.labelRuaCidade.Name = "labelRuaCidade";
            this.labelRuaCidade.Size = new System.Drawing.Size(30, 15);
            this.labelRuaCidade.TabIndex = 9;
            this.labelRuaCidade.Text = "Rua";
            // 
            // txtRuaCidade
            // 
            this.txtRuaCidade.Location = new System.Drawing.Point(120, 236);
            this.txtRuaCidade.Name = "txtRuaCidade";
            this.txtRuaCidade.Size = new System.Drawing.Size(269, 20);
            this.txtRuaCidade.TabIndex = 8;
            // 
            // labelEstadoCidade
            // 
            this.labelEstadoCidade.AutoSize = true;
            this.labelEstadoCidade.Location = new System.Drawing.Point(50, 288);
            this.labelEstadoCidade.Name = "labelEstadoCidade";
            this.labelEstadoCidade.Size = new System.Drawing.Size(45, 15);
            this.labelEstadoCidade.TabIndex = 11;
            this.labelEstadoCidade.Text = "Estado";
            // 
            // cbEstadoCidade
            // 
            this.cbEstadoCidade.FormattingEnabled = true;
            this.cbEstadoCidade.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cbEstadoCidade.Location = new System.Drawing.Point(120, 285);
            this.cbEstadoCidade.Name = "cbEstadoCidade";
            this.cbEstadoCidade.Size = new System.Drawing.Size(269, 21);
            this.cbEstadoCidade.TabIndex = 12;
            // 
            // labelNacaoCidade
            // 
            this.labelNacaoCidade.AutoSize = true;
            this.labelNacaoCidade.Location = new System.Drawing.Point(50, 342);
            this.labelNacaoCidade.Name = "labelNacaoCidade";
            this.labelNacaoCidade.Size = new System.Drawing.Size(31, 15);
            this.labelNacaoCidade.TabIndex = 13;
            this.labelNacaoCidade.Text = "País";
            // 
            // txtNacaoCidade
            // 
            this.txtNacaoCidade.Location = new System.Drawing.Point(120, 338);
            this.txtNacaoCidade.Name = "txtNacaoCidade";
            this.txtNacaoCidade.Size = new System.Drawing.Size(269, 20);
            this.txtNacaoCidade.TabIndex = 14;
            // 
            // txtIdCidade
            // 
            this.txtIdCidade.Location = new System.Drawing.Point(71, 387);
            this.txtIdCidade.Name = "txtIdCidade";
            this.txtIdCidade.Size = new System.Drawing.Size(39, 20);
            this.txtIdCidade.TabIndex = 25;
            this.txtIdCidade.Visible = false;
            // 
            // labelIdCidade
            // 
            this.labelIdCidade.AutoSize = true;
            this.labelIdCidade.Location = new System.Drawing.Point(48, 390);
            this.labelIdCidade.Name = "labelIdCidade";
            this.labelIdCidade.Size = new System.Drawing.Size(17, 15);
            this.labelIdCidade.TabIndex = 24;
            this.labelIdCidade.Text = "Id";
            this.labelIdCidade.Visible = false;
            // 
            // btnExcluirCidade
            // 
            this.btnExcluirCidade.Location = new System.Drawing.Point(553, 387);
            this.btnExcluirCidade.Name = "btnExcluirCidade";
            this.btnExcluirCidade.Size = new System.Drawing.Size(103, 23);
            this.btnExcluirCidade.TabIndex = 23;
            this.btnExcluirCidade.Text = "Excluir";
            this.btnExcluirCidade.UseVisualStyleBackColor = true;
            // 
            // btnAlterarCidade
            // 
            this.btnAlterarCidade.Location = new System.Drawing.Point(412, 387);
            this.btnAlterarCidade.Name = "btnAlterarCidade";
            this.btnAlterarCidade.Size = new System.Drawing.Size(103, 23);
            this.btnAlterarCidade.TabIndex = 22;
            this.btnAlterarCidade.Text = "Alterar";
            this.btnAlterarCidade.UseVisualStyleBackColor = true;
            // 
            // btnCadastrarCidade
            // 
            this.btnCadastrarCidade.Location = new System.Drawing.Point(273, 387);
            this.btnCadastrarCidade.Name = "btnCadastrarCidade";
            this.btnCadastrarCidade.Size = new System.Drawing.Size(103, 23);
            this.btnCadastrarCidade.TabIndex = 21;
            this.btnCadastrarCidade.Text = "Cadastrar";
            this.btnCadastrarCidade.UseVisualStyleBackColor = true;
            // 
            // dgvCidade
            // 
            this.dgvCidade.AllowUserToAddRows = false;
            this.dgvCidade.AllowUserToDeleteRows = false;
            this.dgvCidade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCidade.Location = new System.Drawing.Point(404, 48);
            this.dgvCidade.Name = "dgvCidade";
            this.dgvCidade.ReadOnly = true;
            this.dgvCidade.RowHeadersWidth = 45;
            this.dgvCidade.Size = new System.Drawing.Size(331, 309);
            this.dgvCidade.TabIndex = 20;
            // 
            // FormCidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtIdCidade);
            this.Controls.Add(this.labelIdCidade);
            this.Controls.Add(this.btnExcluirCidade);
            this.Controls.Add(this.btnAlterarCidade);
            this.Controls.Add(this.btnCadastrarCidade);
            this.Controls.Add(this.dgvCidade);
            this.Controls.Add(this.txtNacaoCidade);
            this.Controls.Add(this.labelNacaoCidade);
            this.Controls.Add(this.cbEstadoCidade);
            this.Controls.Add(this.labelEstadoCidade);
            this.Controls.Add(this.labelRuaCidade);
            this.Controls.Add(this.txtRuaCidade);
            this.Controls.Add(this.labelBairroCidade);
            this.Controls.Add(this.txtBairroCidade);
            this.Controls.Add(this.labelNumeroCidade);
            this.Controls.Add(this.txtNumeroCidade);
            this.Controls.Add(this.txtEnderecoCidade);
            this.Controls.Add(this.labelEnderecoCidade);
            this.Controls.Add(this.labelNomeCidade);
            this.Controls.Add(this.txtNomeCidade);
            this.Name = "FormCidade";
            this.Text = "Endereço do Estudante";
            this.Load += new System.EventHandler(this.FormCidade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomeCidade;
        private System.Windows.Forms.Label labelNomeCidade;
        private System.Windows.Forms.Label labelEnderecoCidade;
        private System.Windows.Forms.TextBox txtEnderecoCidade;
        private System.Windows.Forms.TextBox txtNumeroCidade;
        private System.Windows.Forms.Label labelNumeroCidade;
        private System.Windows.Forms.Label labelBairroCidade;
        private System.Windows.Forms.TextBox txtBairroCidade;
        private System.Windows.Forms.Label labelRuaCidade;
        private System.Windows.Forms.TextBox txtRuaCidade;
        private System.Windows.Forms.Label labelEstadoCidade;
        private System.Windows.Forms.ComboBox cbEstadoCidade;
        private System.Windows.Forms.Label labelNacaoCidade;
        private System.Windows.Forms.TextBox txtNacaoCidade;
        private System.Windows.Forms.TextBox txtIdCidade;
        private System.Windows.Forms.Label labelIdCidade;
        private System.Windows.Forms.Button btnExcluirCidade;
        private System.Windows.Forms.Button btnAlterarCidade;
        private System.Windows.Forms.Button btnCadastrarCidade;
        private System.Windows.Forms.DataGridView dgvCidade;
    }
}