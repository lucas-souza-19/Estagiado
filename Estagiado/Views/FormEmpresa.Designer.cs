namespace Estagiado.Views
{
    partial class FormEmpresa
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
            this.labelNomeEmpresa = new System.Windows.Forms.Label();
            this.labelCnpjEmpresa = new System.Windows.Forms.Label();
            this.labelEnderecoEmpresa = new System.Windows.Forms.Label();
            this.labelCidadeEmpresa = new System.Windows.Forms.Label();
            this.labelEmailEmpresa = new System.Windows.Forms.Label();
            this.labelWhatsappEmpresa = new System.Windows.Forms.Label();
            this.labelLinkEmpresa = new System.Windows.Forms.Label();
            this.labelSenhaEmpresa = new System.Windows.Forms.Label();
            this.txtNomeEmpresa = new System.Windows.Forms.TextBox();
            this.txtEnderecoEmpresa = new System.Windows.Forms.TextBox();
            this.txtCidadeEmpresa = new System.Windows.Forms.TextBox();
            this.txtWhatsappEmpresa = new System.Windows.Forms.TextBox();
            this.txtLinkEmpresa = new System.Windows.Forms.TextBox();
            this.txtEmailEmpresa = new System.Windows.Forms.TextBox();
            this.txtSenhaEmpresa = new System.Windows.Forms.TextBox();
            this.btncadastrarempresa = new System.Windows.Forms.Button();
            this.txtCnpjEmpresa = new System.Windows.Forms.MaskedTextBox();
            this.btnProximaEtapa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbEstadoEmpresa = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelNomeEmpresa
            // 
            this.labelNomeEmpresa.AutoSize = true;
            this.labelNomeEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeEmpresa.Location = new System.Drawing.Point(393, 85);
            this.labelNomeEmpresa.Name = "labelNomeEmpresa";
            this.labelNomeEmpresa.Size = new System.Drawing.Size(51, 20);
            this.labelNomeEmpresa.TabIndex = 0;
            this.labelNomeEmpresa.Text = "Nome";
            // 
            // labelCnpjEmpresa
            // 
            this.labelCnpjEmpresa.AutoSize = true;
            this.labelCnpjEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCnpjEmpresa.Location = new System.Drawing.Point(393, 133);
            this.labelCnpjEmpresa.Name = "labelCnpjEmpresa";
            this.labelCnpjEmpresa.Size = new System.Drawing.Size(49, 20);
            this.labelCnpjEmpresa.TabIndex = 1;
            this.labelCnpjEmpresa.Text = "CNPJ";
            this.labelCnpjEmpresa.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelEnderecoEmpresa
            // 
            this.labelEnderecoEmpresa.AutoSize = true;
            this.labelEnderecoEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnderecoEmpresa.Location = new System.Drawing.Point(392, 273);
            this.labelEnderecoEmpresa.Name = "labelEnderecoEmpresa";
            this.labelEnderecoEmpresa.Size = new System.Drawing.Size(78, 20);
            this.labelEnderecoEmpresa.TabIndex = 2;
            this.labelEnderecoEmpresa.Text = "Endereço";
            // 
            // labelCidadeEmpresa
            // 
            this.labelCidadeEmpresa.AutoSize = true;
            this.labelCidadeEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCidadeEmpresa.Location = new System.Drawing.Point(392, 322);
            this.labelCidadeEmpresa.Name = "labelCidadeEmpresa";
            this.labelCidadeEmpresa.Size = new System.Drawing.Size(59, 20);
            this.labelCidadeEmpresa.TabIndex = 3;
            this.labelCidadeEmpresa.Text = "Cidade";
            // 
            // labelEmailEmpresa
            // 
            this.labelEmailEmpresa.AutoSize = true;
            this.labelEmailEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmailEmpresa.Location = new System.Drawing.Point(393, 181);
            this.labelEmailEmpresa.Name = "labelEmailEmpresa";
            this.labelEmailEmpresa.Size = new System.Drawing.Size(52, 20);
            this.labelEmailEmpresa.TabIndex = 4;
            this.labelEmailEmpresa.Text = "Email ";
            // 
            // labelWhatsappEmpresa
            // 
            this.labelWhatsappEmpresa.AutoSize = true;
            this.labelWhatsappEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWhatsappEmpresa.Location = new System.Drawing.Point(670, 133);
            this.labelWhatsappEmpresa.Name = "labelWhatsappEmpresa";
            this.labelWhatsappEmpresa.Size = new System.Drawing.Size(84, 20);
            this.labelWhatsappEmpresa.TabIndex = 5;
            this.labelWhatsappEmpresa.Text = "WhatsApp";
            // 
            // labelLinkEmpresa
            // 
            this.labelLinkEmpresa.AutoSize = true;
            this.labelLinkEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLinkEmpresa.Location = new System.Drawing.Point(392, 227);
            this.labelLinkEmpresa.Name = "labelLinkEmpresa";
            this.labelLinkEmpresa.Size = new System.Drawing.Size(38, 20);
            this.labelLinkEmpresa.TabIndex = 6;
            this.labelLinkEmpresa.Text = "Link";
            // 
            // labelSenhaEmpresa
            // 
            this.labelSenhaEmpresa.AutoSize = true;
            this.labelSenhaEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSenhaEmpresa.Location = new System.Drawing.Point(670, 181);
            this.labelSenhaEmpresa.Name = "labelSenhaEmpresa";
            this.labelSenhaEmpresa.Size = new System.Drawing.Size(56, 20);
            this.labelSenhaEmpresa.TabIndex = 7;
            this.labelSenhaEmpresa.Text = "Senha";
            // 
            // txtNomeEmpresa
            // 
            this.txtNomeEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeEmpresa.Location = new System.Drawing.Point(396, 103);
            this.txtNomeEmpresa.Name = "txtNomeEmpresa";
            this.txtNomeEmpresa.Size = new System.Drawing.Size(508, 24);
            this.txtNomeEmpresa.TabIndex = 8;
            // 
            // txtEnderecoEmpresa
            // 
            this.txtEnderecoEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnderecoEmpresa.Location = new System.Drawing.Point(396, 291);
            this.txtEnderecoEmpresa.Name = "txtEnderecoEmpresa";
            this.txtEnderecoEmpresa.Size = new System.Drawing.Size(508, 24);
            this.txtEnderecoEmpresa.TabIndex = 10;
            // 
            // txtCidadeEmpresa
            // 
            this.txtCidadeEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidadeEmpresa.Location = new System.Drawing.Point(395, 340);
            this.txtCidadeEmpresa.Name = "txtCidadeEmpresa";
            this.txtCidadeEmpresa.Size = new System.Drawing.Size(231, 24);
            this.txtCidadeEmpresa.TabIndex = 11;
            // 
            // txtWhatsappEmpresa
            // 
            this.txtWhatsappEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWhatsappEmpresa.Location = new System.Drawing.Point(673, 151);
            this.txtWhatsappEmpresa.Name = "txtWhatsappEmpresa";
            this.txtWhatsappEmpresa.Size = new System.Drawing.Size(231, 24);
            this.txtWhatsappEmpresa.TabIndex = 12;
            // 
            // txtLinkEmpresa
            // 
            this.txtLinkEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLinkEmpresa.Location = new System.Drawing.Point(395, 245);
            this.txtLinkEmpresa.Name = "txtLinkEmpresa";
            this.txtLinkEmpresa.Size = new System.Drawing.Size(509, 24);
            this.txtLinkEmpresa.TabIndex = 13;
            // 
            // txtEmailEmpresa
            // 
            this.txtEmailEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailEmpresa.Location = new System.Drawing.Point(396, 199);
            this.txtEmailEmpresa.Name = "txtEmailEmpresa";
            this.txtEmailEmpresa.Size = new System.Drawing.Size(231, 24);
            this.txtEmailEmpresa.TabIndex = 14;
            // 
            // txtSenhaEmpresa
            // 
            this.txtSenhaEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaEmpresa.Location = new System.Drawing.Point(673, 199);
            this.txtSenhaEmpresa.Name = "txtSenhaEmpresa";
            this.txtSenhaEmpresa.PasswordChar = '*';
            this.txtSenhaEmpresa.Size = new System.Drawing.Size(231, 24);
            this.txtSenhaEmpresa.TabIndex = 15;
            this.txtSenhaEmpresa.TextChanged += new System.EventHandler(this.txtSenhaEmpresa_TextChanged);
            // 
            // btncadastrarempresa
            // 
            this.btncadastrarempresa.BackColor = System.Drawing.Color.DodgerBlue;
            this.btncadastrarempresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncadastrarempresa.Location = new System.Drawing.Point(673, 417);
            this.btncadastrarempresa.Name = "btncadastrarempresa";
            this.btncadastrarempresa.Size = new System.Drawing.Size(96, 46);
            this.btncadastrarempresa.TabIndex = 17;
            this.btncadastrarempresa.Text = "Cadastrar";
            this.btncadastrarempresa.UseVisualStyleBackColor = false;
            this.btncadastrarempresa.Click += new System.EventHandler(this.btncadastrarempresa_Click);
            // 
            // txtCnpjEmpresa
            // 
            this.txtCnpjEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCnpjEmpresa.Location = new System.Drawing.Point(395, 151);
            this.txtCnpjEmpresa.Mask = "00,000,000/0000-00";
            this.txtCnpjEmpresa.Name = "txtCnpjEmpresa";
            this.txtCnpjEmpresa.Size = new System.Drawing.Size(231, 24);
            this.txtCnpjEmpresa.TabIndex = 22;
            // 
            // btnProximaEtapa
            // 
            this.btnProximaEtapa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProximaEtapa.Location = new System.Drawing.Point(818, 429);
            this.btnProximaEtapa.Name = "btnProximaEtapa";
            this.btnProximaEtapa.Size = new System.Drawing.Size(85, 34);
            this.btnProximaEtapa.TabIndex = 31;
            this.btnProximaEtapa.Text = "Próximo...";
            this.btnProximaEtapa.UseVisualStyleBackColor = true;
            this.btnProximaEtapa.Click += new System.EventHandler(this.btnProximaEtapa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(670, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "Estado";
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
            this.cbEstadoEmpresa.Location = new System.Drawing.Point(673, 340);
            this.cbEstadoEmpresa.Name = "cbEstadoEmpresa";
            this.cbEstadoEmpresa.Size = new System.Drawing.Size(230, 26);
            this.cbEstadoEmpresa.TabIndex = 33;
            // 
            // FormEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 679);
            this.Controls.Add(this.cbEstadoEmpresa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnProximaEtapa);
            this.Controls.Add(this.txtCnpjEmpresa);
            this.Controls.Add(this.btncadastrarempresa);
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
            this.Name = "FormEmpresa";
            this.Text = "Formulário de Cadastro de Empresas";
            this.Load += new System.EventHandler(this.FormEmpresa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNomeEmpresa;
        private System.Windows.Forms.Label labelCnpjEmpresa;
        private System.Windows.Forms.Label labelEnderecoEmpresa;
        private System.Windows.Forms.Label labelCidadeEmpresa;
        private System.Windows.Forms.Label labelEmailEmpresa;
        private System.Windows.Forms.Label labelWhatsappEmpresa;
        private System.Windows.Forms.Label labelLinkEmpresa;
        private System.Windows.Forms.Label labelSenhaEmpresa;
        private System.Windows.Forms.TextBox txtNomeEmpresa;
        private System.Windows.Forms.TextBox txtEnderecoEmpresa;
        private System.Windows.Forms.TextBox txtCidadeEmpresa;
        private System.Windows.Forms.TextBox txtWhatsappEmpresa;
        private System.Windows.Forms.TextBox txtLinkEmpresa;
        private System.Windows.Forms.TextBox txtEmailEmpresa;
        private System.Windows.Forms.TextBox txtSenhaEmpresa;
        private System.Windows.Forms.Button btncadastrarempresa;
        private System.Windows.Forms.MaskedTextBox txtCnpjEmpresa;
        private System.Windows.Forms.Button btnProximaEtapa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbEstadoEmpresa;
    }
}