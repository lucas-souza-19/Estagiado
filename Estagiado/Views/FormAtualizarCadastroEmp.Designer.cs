namespace Estagiado.Views
{
    partial class FormAtualizarCadastroEmp
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
            this.cbEstadoEmpresa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCnpjEmpresa = new System.Windows.Forms.MaskedTextBox();
            this.dgvEmpresa = new System.Windows.Forms.DataGridView();
            this.txtSenhaEmpresa = new System.Windows.Forms.TextBox();
            this.txtEmailEmpresa = new System.Windows.Forms.TextBox();
            this.txtLinkEmpresa = new System.Windows.Forms.TextBox();
            this.txtWhatsappEmpresa = new System.Windows.Forms.TextBox();
            this.txtCidadeEmpresa = new System.Windows.Forms.TextBox();
            this.txtEnderecoEmpresa = new System.Windows.Forms.TextBox();
            this.txtNomeEmpresa = new System.Windows.Forms.TextBox();
            this.labelSenhaEmpresa = new System.Windows.Forms.Label();
            this.labelLinkEmpresa = new System.Windows.Forms.Label();
            this.labelWhatsappEmpresa = new System.Windows.Forms.Label();
            this.labelEmailEmpresa = new System.Windows.Forms.Label();
            this.labelCidadeEmpresa = new System.Windows.Forms.Label();
            this.labelEnderecoEmpresa = new System.Windows.Forms.Label();
            this.labelCnpjEmpresa = new System.Windows.Forms.Label();
            this.labelNomeEmpresa = new System.Windows.Forms.Label();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.cbIdEmpresa = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpresa)).BeginInit();
            this.SuspendLayout();
            // 
            // cbEstadoEmpresa
            // 
            this.cbEstadoEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstadoEmpresa.FormattingEnabled = true;
            this.cbEstadoEmpresa.Items.AddRange(new object[] {
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
            this.cbEstadoEmpresa.Location = new System.Drawing.Point(828, 461);
            this.cbEstadoEmpresa.Name = "cbEstadoEmpresa";
            this.cbEstadoEmpresa.Size = new System.Drawing.Size(232, 26);
            this.cbEstadoEmpresa.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(827, 443);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 51;
            this.label1.Text = "Estado";
            // 
            // txtCnpjEmpresa
            // 
            this.txtCnpjEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCnpjEmpresa.Location = new System.Drawing.Point(221, 339);
            this.txtCnpjEmpresa.Mask = "00,000,000/0000-00";
            this.txtCnpjEmpresa.Name = "txtCnpjEmpresa";
            this.txtCnpjEmpresa.Size = new System.Drawing.Size(231, 24);
            this.txtCnpjEmpresa.TabIndex = 50;
            // 
            // dgvEmpresa
            // 
            this.dgvEmpresa.AllowUserToAddRows = false;
            this.dgvEmpresa.AllowUserToDeleteRows = false;
            this.dgvEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpresa.Location = new System.Drawing.Point(222, 148);
            this.dgvEmpresa.Name = "dgvEmpresa";
            this.dgvEmpresa.ReadOnly = true;
            this.dgvEmpresa.RowHeadersWidth = 45;
            this.dgvEmpresa.Size = new System.Drawing.Size(838, 91);
            this.dgvEmpresa.TabIndex = 49;
            this.dgvEmpresa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpresa_CellContentClick);
            // 
            // txtSenhaEmpresa
            // 
            this.txtSenhaEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaEmpresa.Location = new System.Drawing.Point(221, 455);
            this.txtSenhaEmpresa.Name = "txtSenhaEmpresa";
            this.txtSenhaEmpresa.PasswordChar = '*';
            this.txtSenhaEmpresa.Size = new System.Drawing.Size(231, 24);
            this.txtSenhaEmpresa.TabIndex = 48;
            // 
            // txtEmailEmpresa
            // 
            this.txtEmailEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailEmpresa.Location = new System.Drawing.Point(222, 397);
            this.txtEmailEmpresa.Name = "txtEmailEmpresa";
            this.txtEmailEmpresa.Size = new System.Drawing.Size(231, 24);
            this.txtEmailEmpresa.TabIndex = 47;
            // 
            // txtLinkEmpresa
            // 
            this.txtLinkEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLinkEmpresa.Location = new System.Drawing.Point(828, 288);
            this.txtLinkEmpresa.Name = "txtLinkEmpresa";
            this.txtLinkEmpresa.Size = new System.Drawing.Size(231, 24);
            this.txtLinkEmpresa.TabIndex = 46;
            // 
            // txtWhatsappEmpresa
            // 
            this.txtWhatsappEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWhatsappEmpresa.Location = new System.Drawing.Point(221, 514);
            this.txtWhatsappEmpresa.Name = "txtWhatsappEmpresa";
            this.txtWhatsappEmpresa.Size = new System.Drawing.Size(231, 24);
            this.txtWhatsappEmpresa.TabIndex = 45;
            // 
            // txtCidadeEmpresa
            // 
            this.txtCidadeEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidadeEmpresa.Location = new System.Drawing.Point(829, 400);
            this.txtCidadeEmpresa.Name = "txtCidadeEmpresa";
            this.txtCidadeEmpresa.Size = new System.Drawing.Size(231, 24);
            this.txtCidadeEmpresa.TabIndex = 44;
            // 
            // txtEnderecoEmpresa
            // 
            this.txtEnderecoEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnderecoEmpresa.Location = new System.Drawing.Point(829, 343);
            this.txtEnderecoEmpresa.Name = "txtEnderecoEmpresa";
            this.txtEnderecoEmpresa.Size = new System.Drawing.Size(231, 24);
            this.txtEnderecoEmpresa.TabIndex = 43;
            // 
            // txtNomeEmpresa
            // 
            this.txtNomeEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeEmpresa.Location = new System.Drawing.Point(222, 286);
            this.txtNomeEmpresa.Name = "txtNomeEmpresa";
            this.txtNomeEmpresa.Size = new System.Drawing.Size(231, 24);
            this.txtNomeEmpresa.TabIndex = 42;
            // 
            // labelSenhaEmpresa
            // 
            this.labelSenhaEmpresa.AutoSize = true;
            this.labelSenhaEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSenhaEmpresa.Location = new System.Drawing.Point(218, 437);
            this.labelSenhaEmpresa.Name = "labelSenhaEmpresa";
            this.labelSenhaEmpresa.Size = new System.Drawing.Size(56, 20);
            this.labelSenhaEmpresa.TabIndex = 41;
            this.labelSenhaEmpresa.Text = "Senha";
            // 
            // labelLinkEmpresa
            // 
            this.labelLinkEmpresa.AutoSize = true;
            this.labelLinkEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLinkEmpresa.Location = new System.Drawing.Point(824, 268);
            this.labelLinkEmpresa.Name = "labelLinkEmpresa";
            this.labelLinkEmpresa.Size = new System.Drawing.Size(38, 20);
            this.labelLinkEmpresa.TabIndex = 40;
            this.labelLinkEmpresa.Text = "Link";
            // 
            // labelWhatsappEmpresa
            // 
            this.labelWhatsappEmpresa.AutoSize = true;
            this.labelWhatsappEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWhatsappEmpresa.Location = new System.Drawing.Point(217, 496);
            this.labelWhatsappEmpresa.Name = "labelWhatsappEmpresa";
            this.labelWhatsappEmpresa.Size = new System.Drawing.Size(84, 20);
            this.labelWhatsappEmpresa.TabIndex = 39;
            this.labelWhatsappEmpresa.Text = "WhatsApp";
            // 
            // labelEmailEmpresa
            // 
            this.labelEmailEmpresa.AutoSize = true;
            this.labelEmailEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmailEmpresa.Location = new System.Drawing.Point(218, 379);
            this.labelEmailEmpresa.Name = "labelEmailEmpresa";
            this.labelEmailEmpresa.Size = new System.Drawing.Size(52, 20);
            this.labelEmailEmpresa.TabIndex = 38;
            this.labelEmailEmpresa.Text = "Email ";
            // 
            // labelCidadeEmpresa
            // 
            this.labelCidadeEmpresa.AutoSize = true;
            this.labelCidadeEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCidadeEmpresa.Location = new System.Drawing.Point(825, 382);
            this.labelCidadeEmpresa.Name = "labelCidadeEmpresa";
            this.labelCidadeEmpresa.Size = new System.Drawing.Size(59, 20);
            this.labelCidadeEmpresa.TabIndex = 37;
            this.labelCidadeEmpresa.Text = "Cidade";
            // 
            // labelEnderecoEmpresa
            // 
            this.labelEnderecoEmpresa.AutoSize = true;
            this.labelEnderecoEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnderecoEmpresa.Location = new System.Drawing.Point(825, 325);
            this.labelEnderecoEmpresa.Name = "labelEnderecoEmpresa";
            this.labelEnderecoEmpresa.Size = new System.Drawing.Size(78, 20);
            this.labelEnderecoEmpresa.TabIndex = 36;
            this.labelEnderecoEmpresa.Text = "Endereço";
            // 
            // labelCnpjEmpresa
            // 
            this.labelCnpjEmpresa.AutoSize = true;
            this.labelCnpjEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCnpjEmpresa.Location = new System.Drawing.Point(218, 321);
            this.labelCnpjEmpresa.Name = "labelCnpjEmpresa";
            this.labelCnpjEmpresa.Size = new System.Drawing.Size(49, 20);
            this.labelCnpjEmpresa.TabIndex = 35;
            this.labelCnpjEmpresa.Text = "CNPJ";
            // 
            // labelNomeEmpresa
            // 
            this.labelNomeEmpresa.AutoSize = true;
            this.labelNomeEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeEmpresa.Location = new System.Drawing.Point(218, 268);
            this.labelNomeEmpresa.Name = "labelNomeEmpresa";
            this.labelNomeEmpresa.Size = new System.Drawing.Size(51, 20);
            this.labelNomeEmpresa.TabIndex = 34;
            this.labelNomeEmpresa.Text = "Nome";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Location = new System.Drawing.Point(828, 514);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(86, 46);
            this.btnAtualizar.TabIndex = 53;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // cbIdEmpresa
            // 
            this.cbIdEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIdEmpresa.FormattingEnabled = true;
            this.cbIdEmpresa.Location = new System.Drawing.Point(222, 106);
            this.cbIdEmpresa.Name = "cbIdEmpresa";
            this.cbIdEmpresa.Size = new System.Drawing.Size(47, 26);
            this.cbIdEmpresa.TabIndex = 60;
            // 
            // FormAtualizarCadastroEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 679);
            this.Controls.Add(this.cbIdEmpresa);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.cbEstadoEmpresa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCnpjEmpresa);
            this.Controls.Add(this.dgvEmpresa);
            this.Controls.Add(this.txtSenhaEmpresa);
            this.Controls.Add(this.txtEmailEmpresa);
            this.Controls.Add(this.txtLinkEmpresa);
            this.Controls.Add(this.txtWhatsappEmpresa);
            this.Controls.Add(this.txtCidadeEmpresa);
            this.Controls.Add(this.txtEnderecoEmpresa);
            this.Controls.Add(this.txtNomeEmpresa);
            this.Controls.Add(this.labelSenhaEmpresa);
            this.Controls.Add(this.labelLinkEmpresa);
            this.Controls.Add(this.labelWhatsappEmpresa);
            this.Controls.Add(this.labelEmailEmpresa);
            this.Controls.Add(this.labelCidadeEmpresa);
            this.Controls.Add(this.labelEnderecoEmpresa);
            this.Controls.Add(this.labelCnpjEmpresa);
            this.Controls.Add(this.labelNomeEmpresa);
            this.Name = "FormAtualizarCadastroEmp";
            this.Text = "Formulário de Atualização de Cadastro";
            this.Load += new System.EventHandler(this.FormAtualizarCadastroEmp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpresa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbEstadoEmpresa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtCnpjEmpresa;
        private System.Windows.Forms.TextBox txtSenhaEmpresa;
        private System.Windows.Forms.TextBox txtEmailEmpresa;
        private System.Windows.Forms.TextBox txtLinkEmpresa;
        private System.Windows.Forms.TextBox txtWhatsappEmpresa;
        private System.Windows.Forms.TextBox txtCidadeEmpresa;
        private System.Windows.Forms.TextBox txtEnderecoEmpresa;
        private System.Windows.Forms.TextBox txtNomeEmpresa;
        private System.Windows.Forms.Label labelSenhaEmpresa;
        private System.Windows.Forms.Label labelLinkEmpresa;
        private System.Windows.Forms.Label labelWhatsappEmpresa;
        private System.Windows.Forms.Label labelEmailEmpresa;
        private System.Windows.Forms.Label labelCidadeEmpresa;
        private System.Windows.Forms.Label labelEnderecoEmpresa;
        private System.Windows.Forms.Label labelCnpjEmpresa;
        private System.Windows.Forms.Label labelNomeEmpresa;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.ComboBox cbIdEmpresa;
        public System.Windows.Forms.DataGridView dgvEmpresa;
    }
}