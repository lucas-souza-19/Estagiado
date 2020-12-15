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
            this.labelFoneEmpresa = new System.Windows.Forms.Label();
            this.labelRamalEmpresa = new System.Windows.Forms.Label();
            this.labelEmailEmpresa = new System.Windows.Forms.Label();
            this.labelWhatsappEmpresa = new System.Windows.Forms.Label();
            this.labelLinkEmpresa = new System.Windows.Forms.Label();
            this.labelSenhaEmpresa = new System.Windows.Forms.Label();
            this.txtNomeEmpresa = new System.Windows.Forms.TextBox();
            this.txtFoneEmpresa = new System.Windows.Forms.TextBox();
            this.txtRamalEmpresa = new System.Windows.Forms.TextBox();
            this.txtWhatsappEmpresa = new System.Windows.Forms.TextBox();
            this.txtLinkEmpresa = new System.Windows.Forms.TextBox();
            this.txtEmailEmpresa = new System.Windows.Forms.TextBox();
            this.txtSenhaEmpresa = new System.Windows.Forms.TextBox();
            this.dgvEmpresa = new System.Windows.Forms.DataGridView();
            this.btncadastrarempresa = new System.Windows.Forms.Button();
            this.btnAlterarEmpresa = new System.Windows.Forms.Button();
            this.btnExcluirEmpresa = new System.Windows.Forms.Button();
            this.labelIdEmpresa = new System.Windows.Forms.Label();
            this.txtIdEmpresa = new System.Windows.Forms.TextBox();
            this.txtCnpjEmpresa = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpresa)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNomeEmpresa
            // 
            this.labelNomeEmpresa.AutoSize = true;
            this.labelNomeEmpresa.Location = new System.Drawing.Point(39, 33);
            this.labelNomeEmpresa.Name = "labelNomeEmpresa";
            this.labelNomeEmpresa.Size = new System.Drawing.Size(41, 15);
            this.labelNomeEmpresa.TabIndex = 0;
            this.labelNomeEmpresa.Text = "Nome";
            // 
            // labelCnpjEmpresa
            // 
            this.labelCnpjEmpresa.AutoSize = true;
            this.labelCnpjEmpresa.Location = new System.Drawing.Point(39, 75);
            this.labelCnpjEmpresa.Name = "labelCnpjEmpresa";
            this.labelCnpjEmpresa.Size = new System.Drawing.Size(38, 15);
            this.labelCnpjEmpresa.TabIndex = 1;
            this.labelCnpjEmpresa.Text = "CNPJ";
            this.labelCnpjEmpresa.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelFoneEmpresa
            // 
            this.labelFoneEmpresa.AutoSize = true;
            this.labelFoneEmpresa.Location = new System.Drawing.Point(39, 116);
            this.labelFoneEmpresa.Name = "labelFoneEmpresa";
            this.labelFoneEmpresa.Size = new System.Drawing.Size(55, 15);
            this.labelFoneEmpresa.TabIndex = 2;
            this.labelFoneEmpresa.Text = "Telefone";
            // 
            // labelRamalEmpresa
            // 
            this.labelRamalEmpresa.AutoSize = true;
            this.labelRamalEmpresa.Location = new System.Drawing.Point(39, 157);
            this.labelRamalEmpresa.Name = "labelRamalEmpresa";
            this.labelRamalEmpresa.Size = new System.Drawing.Size(44, 15);
            this.labelRamalEmpresa.TabIndex = 3;
            this.labelRamalEmpresa.Text = "Ramal";
            // 
            // labelEmailEmpresa
            // 
            this.labelEmailEmpresa.AutoSize = true;
            this.labelEmailEmpresa.Location = new System.Drawing.Point(39, 296);
            this.labelEmailEmpresa.Name = "labelEmailEmpresa";
            this.labelEmailEmpresa.Size = new System.Drawing.Size(42, 15);
            this.labelEmailEmpresa.TabIndex = 4;
            this.labelEmailEmpresa.Text = "Email ";
            // 
            // labelWhatsappEmpresa
            // 
            this.labelWhatsappEmpresa.AutoSize = true;
            this.labelWhatsappEmpresa.Location = new System.Drawing.Point(39, 202);
            this.labelWhatsappEmpresa.Name = "labelWhatsappEmpresa";
            this.labelWhatsappEmpresa.Size = new System.Drawing.Size(62, 15);
            this.labelWhatsappEmpresa.TabIndex = 5;
            this.labelWhatsappEmpresa.Text = "WhatsApp";
            // 
            // labelLinkEmpresa
            // 
            this.labelLinkEmpresa.AutoSize = true;
            this.labelLinkEmpresa.Location = new System.Drawing.Point(39, 247);
            this.labelLinkEmpresa.Name = "labelLinkEmpresa";
            this.labelLinkEmpresa.Size = new System.Drawing.Size(30, 15);
            this.labelLinkEmpresa.TabIndex = 6;
            this.labelLinkEmpresa.Text = "Link";
            // 
            // labelSenhaEmpresa
            // 
            this.labelSenhaEmpresa.AutoSize = true;
            this.labelSenhaEmpresa.Location = new System.Drawing.Point(42, 347);
            this.labelSenhaEmpresa.Name = "labelSenhaEmpresa";
            this.labelSenhaEmpresa.Size = new System.Drawing.Size(43, 15);
            this.labelSenhaEmpresa.TabIndex = 7;
            this.labelSenhaEmpresa.Text = "Senha";
            // 
            // txtNomeEmpresa
            // 
            this.txtNomeEmpresa.Location = new System.Drawing.Point(105, 31);
            this.txtNomeEmpresa.Name = "txtNomeEmpresa";
            this.txtNomeEmpresa.Size = new System.Drawing.Size(231, 20);
            this.txtNomeEmpresa.TabIndex = 8;
            // 
            // txtFoneEmpresa
            // 
            this.txtFoneEmpresa.Location = new System.Drawing.Point(105, 116);
            this.txtFoneEmpresa.Name = "txtFoneEmpresa";
            this.txtFoneEmpresa.Size = new System.Drawing.Size(231, 20);
            this.txtFoneEmpresa.TabIndex = 10;
            // 
            // txtRamalEmpresa
            // 
            this.txtRamalEmpresa.Location = new System.Drawing.Point(105, 157);
            this.txtRamalEmpresa.Name = "txtRamalEmpresa";
            this.txtRamalEmpresa.Size = new System.Drawing.Size(231, 20);
            this.txtRamalEmpresa.TabIndex = 11;
            // 
            // txtWhatsappEmpresa
            // 
            this.txtWhatsappEmpresa.Location = new System.Drawing.Point(105, 201);
            this.txtWhatsappEmpresa.Name = "txtWhatsappEmpresa";
            this.txtWhatsappEmpresa.Size = new System.Drawing.Size(231, 20);
            this.txtWhatsappEmpresa.TabIndex = 12;
            // 
            // txtLinkEmpresa
            // 
            this.txtLinkEmpresa.Location = new System.Drawing.Point(105, 247);
            this.txtLinkEmpresa.Name = "txtLinkEmpresa";
            this.txtLinkEmpresa.Size = new System.Drawing.Size(231, 20);
            this.txtLinkEmpresa.TabIndex = 13;
            // 
            // txtEmailEmpresa
            // 
            this.txtEmailEmpresa.Location = new System.Drawing.Point(105, 296);
            this.txtEmailEmpresa.Name = "txtEmailEmpresa";
            this.txtEmailEmpresa.Size = new System.Drawing.Size(231, 20);
            this.txtEmailEmpresa.TabIndex = 14;
            // 
            // txtSenhaEmpresa
            // 
            this.txtSenhaEmpresa.Location = new System.Drawing.Point(105, 347);
            this.txtSenhaEmpresa.Name = "txtSenhaEmpresa";
            this.txtSenhaEmpresa.PasswordChar = '*';
            this.txtSenhaEmpresa.Size = new System.Drawing.Size(231, 20);
            this.txtSenhaEmpresa.TabIndex = 15;
            // 
            // dgvEmpresa
            // 
            this.dgvEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpresa.Location = new System.Drawing.Point(372, 31);
            this.dgvEmpresa.Name = "dgvEmpresa";
            this.dgvEmpresa.RowHeadersWidth = 45;
            this.dgvEmpresa.Size = new System.Drawing.Size(375, 336);
            this.dgvEmpresa.TabIndex = 16;
            this.dgvEmpresa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpresa_CellClick);
            // 
            // btncadastrarempresa
            // 
            this.btncadastrarempresa.Location = new System.Drawing.Point(260, 390);
            this.btncadastrarempresa.Name = "btncadastrarempresa";
            this.btncadastrarempresa.Size = new System.Drawing.Size(75, 23);
            this.btncadastrarempresa.TabIndex = 17;
            this.btncadastrarempresa.Text = "Cadastrar";
            this.btncadastrarempresa.UseVisualStyleBackColor = true;
            this.btncadastrarempresa.Click += new System.EventHandler(this.btncadastrarempresa_Click);
            // 
            // btnAlterarEmpresa
            // 
            this.btnAlterarEmpresa.Location = new System.Drawing.Point(374, 390);
            this.btnAlterarEmpresa.Name = "btnAlterarEmpresa";
            this.btnAlterarEmpresa.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarEmpresa.TabIndex = 18;
            this.btnAlterarEmpresa.Text = "Alterar";
            this.btnAlterarEmpresa.UseVisualStyleBackColor = true;
            this.btnAlterarEmpresa.Click += new System.EventHandler(this.btnAlterarEmpresa_Click);
            // 
            // btnExcluirEmpresa
            // 
            this.btnExcluirEmpresa.Location = new System.Drawing.Point(493, 390);
            this.btnExcluirEmpresa.Name = "btnExcluirEmpresa";
            this.btnExcluirEmpresa.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirEmpresa.TabIndex = 19;
            this.btnExcluirEmpresa.Text = "Excluir";
            this.btnExcluirEmpresa.UseVisualStyleBackColor = true;
            this.btnExcluirEmpresa.Click += new System.EventHandler(this.btnExcluirEmpresa_Click);
            // 
            // labelIdEmpresa
            // 
            this.labelIdEmpresa.AutoSize = true;
            this.labelIdEmpresa.Location = new System.Drawing.Point(42, 397);
            this.labelIdEmpresa.Name = "labelIdEmpresa";
            this.labelIdEmpresa.Size = new System.Drawing.Size(17, 15);
            this.labelIdEmpresa.TabIndex = 20;
            this.labelIdEmpresa.Text = "Id";
            this.labelIdEmpresa.Visible = false;
            // 
            // txtIdEmpresa
            // 
            this.txtIdEmpresa.Location = new System.Drawing.Point(65, 394);
            this.txtIdEmpresa.Name = "txtIdEmpresa";
            this.txtIdEmpresa.Size = new System.Drawing.Size(43, 20);
            this.txtIdEmpresa.TabIndex = 21;
            this.txtIdEmpresa.Visible = false;
            // 
            // txtCnpjEmpresa
            // 
            this.txtCnpjEmpresa.Location = new System.Drawing.Point(104, 75);
            this.txtCnpjEmpresa.Mask = "00,000,000/0000-00";
            this.txtCnpjEmpresa.Name = "txtCnpjEmpresa";
            this.txtCnpjEmpresa.Size = new System.Drawing.Size(231, 20);
            this.txtCnpjEmpresa.TabIndex = 22;
            // 
            // FormEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCnpjEmpresa);
            this.Controls.Add(this.txtIdEmpresa);
            this.Controls.Add(this.labelIdEmpresa);
            this.Controls.Add(this.btnExcluirEmpresa);
            this.Controls.Add(this.btnAlterarEmpresa);
            this.Controls.Add(this.btncadastrarempresa);
            this.Controls.Add(this.dgvEmpresa);
            this.Controls.Add(this.txtSenhaEmpresa);
            this.Controls.Add(this.txtEmailEmpresa);
            this.Controls.Add(this.txtLinkEmpresa);
            this.Controls.Add(this.txtWhatsappEmpresa);
            this.Controls.Add(this.txtRamalEmpresa);
            this.Controls.Add(this.txtFoneEmpresa);
            this.Controls.Add(this.txtNomeEmpresa);
            this.Controls.Add(this.labelSenhaEmpresa);
            this.Controls.Add(this.labelLinkEmpresa);
            this.Controls.Add(this.labelWhatsappEmpresa);
            this.Controls.Add(this.labelEmailEmpresa);
            this.Controls.Add(this.labelRamalEmpresa);
            this.Controls.Add(this.labelFoneEmpresa);
            this.Controls.Add(this.labelCnpjEmpresa);
            this.Controls.Add(this.labelNomeEmpresa);
            this.Name = "FormEmpresa";
            this.Text = "Formulário de Cadastro de Empresas";
            this.Load += new System.EventHandler(this.FormEmpresa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpresa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNomeEmpresa;
        private System.Windows.Forms.Label labelCnpjEmpresa;
        private System.Windows.Forms.Label labelFoneEmpresa;
        private System.Windows.Forms.Label labelRamalEmpresa;
        private System.Windows.Forms.Label labelEmailEmpresa;
        private System.Windows.Forms.Label labelWhatsappEmpresa;
        private System.Windows.Forms.Label labelLinkEmpresa;
        private System.Windows.Forms.Label labelSenhaEmpresa;
        private System.Windows.Forms.TextBox txtNomeEmpresa;
        private System.Windows.Forms.TextBox txtFoneEmpresa;
        private System.Windows.Forms.TextBox txtRamalEmpresa;
        private System.Windows.Forms.TextBox txtWhatsappEmpresa;
        private System.Windows.Forms.TextBox txtLinkEmpresa;
        private System.Windows.Forms.TextBox txtEmailEmpresa;
        private System.Windows.Forms.TextBox txtSenhaEmpresa;
        private System.Windows.Forms.DataGridView dgvEmpresa;
        private System.Windows.Forms.Button btncadastrarempresa;
        private System.Windows.Forms.Button btnAlterarEmpresa;
        private System.Windows.Forms.Button btnExcluirEmpresa;
        private System.Windows.Forms.Label labelIdEmpresa;
        private System.Windows.Forms.TextBox txtIdEmpresa;
        private System.Windows.Forms.MaskedTextBox txtCnpjEmpresa;
    }
}