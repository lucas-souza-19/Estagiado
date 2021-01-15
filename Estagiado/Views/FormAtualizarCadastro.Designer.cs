namespace Estagiado.Views
{
    partial class FormAtualizarCadastro
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
            this.cbIdUniversidade = new System.Windows.Forms.ComboBox();
            this.dgvEstudante = new System.Windows.Forms.DataGridView();
            this.txtCidadeEstudante = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelCodUniversidade = new System.Windows.Forms.Label();
            this.cbEstadoEstudante = new System.Windows.Forms.ComboBox();
            this.labelEstadoEstudante = new System.Windows.Forms.Label();
            this.txtEnderecoEstudante = new System.Windows.Forms.TextBox();
            this.labelEnderecoEstudante = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.txtWhatsApp = new System.Windows.Forms.TextBox();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.labelSenha = new System.Windows.Forms.Label();
            this.txtFone = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.labelWhatsApp = new System.Windows.Forms.Label();
            this.labelFone = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelSexo = new System.Windows.Forms.Label();
            this.labelCpf = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.cbIdCandidato = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudante)).BeginInit();
            this.SuspendLayout();
            // 
            // cbIdUniversidade
            // 
            this.cbIdUniversidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIdUniversidade.FormattingEnabled = true;
            this.cbIdUniversidade.Location = new System.Drawing.Point(151, 532);
            this.cbIdUniversidade.Name = "cbIdUniversidade";
            this.cbIdUniversidade.Size = new System.Drawing.Size(261, 26);
            this.cbIdUniversidade.TabIndex = 58;
            // 
            // dgvEstudante
            // 
            this.dgvEstudante.AllowUserToAddRows = false;
            this.dgvEstudante.AllowUserToDeleteRows = false;
            this.dgvEstudante.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvEstudante.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvEstudante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstudante.Location = new System.Drawing.Point(153, 128);
            this.dgvEstudante.Name = "dgvEstudante";
            this.dgvEstudante.ReadOnly = true;
            this.dgvEstudante.RowHeadersWidth = 45;
            this.dgvEstudante.Size = new System.Drawing.Size(951, 91);
            this.dgvEstudante.TabIndex = 57;
            this.dgvEstudante.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUniversidades_CellContentClick);
            // 
            // txtCidadeEstudante
            // 
            this.txtCidadeEstudante.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidadeEstudante.Location = new System.Drawing.Point(843, 422);
            this.txtCidadeEstudante.Name = "txtCidadeEstudante";
            this.txtCidadeEstudante.Size = new System.Drawing.Size(261, 24);
            this.txtCidadeEstudante.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(840, 404);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 55;
            this.label2.Text = "Cidade";
            // 
            // labelCodUniversidade
            // 
            this.labelCodUniversidade.AutoSize = true;
            this.labelCodUniversidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodUniversidade.Location = new System.Drawing.Point(148, 514);
            this.labelCodUniversidade.Name = "labelCodUniversidade";
            this.labelCodUniversidade.Size = new System.Drawing.Size(229, 20);
            this.labelCodUniversidade.TabIndex = 54;
            this.labelCodUniversidade.Text = "ID da Universidade e do Curso ";
            // 
            // cbEstadoEstudante
            // 
            this.cbEstadoEstudante.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstadoEstudante.FormattingEnabled = true;
            this.cbEstadoEstudante.Items.AddRange(new object[] {
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
            this.cbEstadoEstudante.Location = new System.Drawing.Point(843, 477);
            this.cbEstadoEstudante.Name = "cbEstadoEstudante";
            this.cbEstadoEstudante.Size = new System.Drawing.Size(134, 26);
            this.cbEstadoEstudante.TabIndex = 53;
            // 
            // labelEstadoEstudante
            // 
            this.labelEstadoEstudante.AutoSize = true;
            this.labelEstadoEstudante.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstadoEstudante.Location = new System.Drawing.Point(840, 459);
            this.labelEstadoEstudante.Name = "labelEstadoEstudante";
            this.labelEstadoEstudante.Size = new System.Drawing.Size(60, 20);
            this.labelEstadoEstudante.TabIndex = 52;
            this.labelEstadoEstudante.Text = "Estado";
            // 
            // txtEnderecoEstudante
            // 
            this.txtEnderecoEstudante.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnderecoEstudante.Location = new System.Drawing.Point(843, 366);
            this.txtEnderecoEstudante.Name = "txtEnderecoEstudante";
            this.txtEnderecoEstudante.Size = new System.Drawing.Size(261, 24);
            this.txtEnderecoEstudante.TabIndex = 51;
            // 
            // labelEnderecoEstudante
            // 
            this.labelEnderecoEstudante.AutoSize = true;
            this.labelEnderecoEstudante.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnderecoEstudante.Location = new System.Drawing.Point(840, 348);
            this.labelEnderecoEstudante.Name = "labelEnderecoEstudante";
            this.labelEnderecoEstudante.Size = new System.Drawing.Size(78, 20);
            this.labelEnderecoEstudante.TabIndex = 50;
            this.labelEnderecoEstudante.Text = "Endereço";
            // 
            // txtCpf
            // 
            this.txtCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpf.Location = new System.Drawing.Point(153, 312);
            this.txtCpf.Mask = "000,000,000-00";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(261, 24);
            this.txtCpf.TabIndex = 49;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Location = new System.Drawing.Point(1019, 512);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(86, 46);
            this.btnAtualizar.TabIndex = 48;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // txtWhatsApp
            // 
            this.txtWhatsApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWhatsApp.Location = new System.Drawing.Point(844, 258);
            this.txtWhatsApp.Name = "txtWhatsApp";
            this.txtWhatsApp.Size = new System.Drawing.Size(261, 24);
            this.txtWhatsApp.TabIndex = 47;
            // 
            // cbSexo
            // 
            this.cbSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "F",
            "M"});
            this.cbSexo.Location = new System.Drawing.Point(153, 366);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(261, 26);
            this.cbSexo.TabIndex = 46;
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(843, 312);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(261, 24);
            this.txtSenha.TabIndex = 45;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(153, 422);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(261, 24);
            this.txtEmail.TabIndex = 44;
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSenha.Location = new System.Drawing.Point(840, 294);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(56, 20);
            this.labelSenha.TabIndex = 43;
            this.labelSenha.Text = "Senha";
            // 
            // txtFone
            // 
            this.txtFone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFone.Location = new System.Drawing.Point(153, 477);
            this.txtFone.Name = "txtFone";
            this.txtFone.Size = new System.Drawing.Size(261, 24);
            this.txtFone.TabIndex = 42;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(153, 258);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(261, 24);
            this.txtNome.TabIndex = 41;
            // 
            // labelWhatsApp
            // 
            this.labelWhatsApp.AutoSize = true;
            this.labelWhatsApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWhatsApp.Location = new System.Drawing.Point(841, 240);
            this.labelWhatsApp.Name = "labelWhatsApp";
            this.labelWhatsApp.Size = new System.Drawing.Size(84, 20);
            this.labelWhatsApp.TabIndex = 40;
            this.labelWhatsApp.Text = "WhatsApp";
            // 
            // labelFone
            // 
            this.labelFone.AutoSize = true;
            this.labelFone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFone.Location = new System.Drawing.Point(150, 459);
            this.labelFone.Name = "labelFone";
            this.labelFone.Size = new System.Drawing.Size(71, 20);
            this.labelFone.TabIndex = 39;
            this.labelFone.Text = "Telefone";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(150, 404);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(48, 20);
            this.labelEmail.TabIndex = 38;
            this.labelEmail.Text = "Email";
            // 
            // labelSexo
            // 
            this.labelSexo.AutoSize = true;
            this.labelSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSexo.Location = new System.Drawing.Point(150, 347);
            this.labelSexo.Name = "labelSexo";
            this.labelSexo.Size = new System.Drawing.Size(45, 20);
            this.labelSexo.TabIndex = 37;
            this.labelSexo.Text = "Sexo";
            // 
            // labelCpf
            // 
            this.labelCpf.AutoSize = true;
            this.labelCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCpf.Location = new System.Drawing.Point(150, 292);
            this.labelCpf.Name = "labelCpf";
            this.labelCpf.Size = new System.Drawing.Size(40, 20);
            this.labelCpf.TabIndex = 36;
            this.labelCpf.Text = "CPF";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(150, 240);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(51, 20);
            this.labelNome.TabIndex = 35;
            this.labelNome.Text = "Nome";
            // 
            // cbIdCandidato
            // 
            this.cbIdCandidato.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIdCandidato.FormattingEnabled = true;
            this.cbIdCandidato.Location = new System.Drawing.Point(153, 96);
            this.cbIdCandidato.Name = "cbIdCandidato";
            this.cbIdCandidato.Size = new System.Drawing.Size(37, 26);
            this.cbIdCandidato.TabIndex = 73;
            // 
            // FormAtualizarCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 679);
            this.Controls.Add(this.cbIdCandidato);
            this.Controls.Add(this.cbIdUniversidade);
            this.Controls.Add(this.dgvEstudante);
            this.Controls.Add(this.txtCidadeEstudante);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelCodUniversidade);
            this.Controls.Add(this.cbEstadoEstudante);
            this.Controls.Add(this.labelEstadoEstudante);
            this.Controls.Add(this.txtEnderecoEstudante);
            this.Controls.Add(this.labelEnderecoEstudante);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.txtWhatsApp);
            this.Controls.Add(this.cbSexo);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.labelSenha);
            this.Controls.Add(this.txtFone);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.labelWhatsApp);
            this.Controls.Add(this.labelFone);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelSexo);
            this.Controls.Add(this.labelCpf);
            this.Controls.Add(this.labelNome);
            this.Name = "FormAtualizarCadastro";
            this.Text = "Formulário de Atualização de Cadastro";
            this.Load += new System.EventHandler(this.FormAtualizarCadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudante)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbIdUniversidade;
        private System.Windows.Forms.DataGridView dgvEstudante;
        private System.Windows.Forms.TextBox txtCidadeEstudante;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelCodUniversidade;
        private System.Windows.Forms.ComboBox cbEstadoEstudante;
        private System.Windows.Forms.Label labelEstadoEstudante;
        private System.Windows.Forms.TextBox txtEnderecoEstudante;
        private System.Windows.Forms.Label labelEnderecoEstudante;
        private System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.TextBox txtWhatsApp;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label labelSenha;
        private System.Windows.Forms.TextBox txtFone;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label labelWhatsApp;
        private System.Windows.Forms.Label labelFone;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelSexo;
        private System.Windows.Forms.Label labelCpf;
        private System.Windows.Forms.Label labelNome;
        public System.Windows.Forms.ComboBox cbIdCandidato;
    }
}