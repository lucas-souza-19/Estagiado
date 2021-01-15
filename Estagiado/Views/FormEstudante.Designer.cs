namespace Estagiado.Views
{
    partial class FormEstudante
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
            this.labelNome = new System.Windows.Forms.Label();
            this.labelCpf = new System.Windows.Forms.Label();
            this.labelSexo = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelFone = new System.Windows.Forms.Label();
            this.labelWhatsApp = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtFone = new System.Windows.Forms.TextBox();
            this.labelSenha = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.cbsexo = new System.Windows.Forms.ComboBox();
            this.txtWhatsApp = new System.Windows.Forms.TextBox();
            this.btncadastrar = new System.Windows.Forms.Button();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.txtEnderecoEstudante = new System.Windows.Forms.TextBox();
            this.labelEnderecoEstudante = new System.Windows.Forms.Label();
            this.labelEstadoEstudante = new System.Windows.Forms.Label();
            this.cbEstadoEstudante = new System.Windows.Forms.ComboBox();
            this.labelCodUniversidade = new System.Windows.Forms.Label();
            this.btnProximaEtapa = new System.Windows.Forms.Button();
            this.txtCidadeEstudante = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvUniversidades = new System.Windows.Forms.DataGridView();
            this.cbIdUniversidade = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUniversidades)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(292, 315);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(51, 20);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome";
            this.labelNome.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelCpf
            // 
            this.labelCpf.AutoSize = true;
            this.labelCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCpf.Location = new System.Drawing.Point(292, 361);
            this.labelCpf.Name = "labelCpf";
            this.labelCpf.Size = new System.Drawing.Size(40, 20);
            this.labelCpf.TabIndex = 1;
            this.labelCpf.Text = "CPF";
            this.labelCpf.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // labelSexo
            // 
            this.labelSexo.AutoSize = true;
            this.labelSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSexo.Location = new System.Drawing.Point(292, 410);
            this.labelSexo.Name = "labelSexo";
            this.labelSexo.Size = new System.Drawing.Size(45, 20);
            this.labelSexo.TabIndex = 2;
            this.labelSexo.Text = "Sexo";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(292, 459);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(48, 20);
            this.labelEmail.TabIndex = 3;
            this.labelEmail.Text = "Email";
            // 
            // labelFone
            // 
            this.labelFone.AutoSize = true;
            this.labelFone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFone.Location = new System.Drawing.Point(292, 507);
            this.labelFone.Name = "labelFone";
            this.labelFone.Size = new System.Drawing.Size(71, 20);
            this.labelFone.TabIndex = 4;
            this.labelFone.Text = "Telefone";
            // 
            // labelWhatsApp
            // 
            this.labelWhatsApp.AutoSize = true;
            this.labelWhatsApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWhatsApp.Location = new System.Drawing.Point(713, 315);
            this.labelWhatsApp.Name = "labelWhatsApp";
            this.labelWhatsApp.Size = new System.Drawing.Size(84, 20);
            this.labelWhatsApp.TabIndex = 5;
            this.labelWhatsApp.Text = "WhatsApp";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(295, 333);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(261, 24);
            this.txtNome.TabIndex = 6;
            // 
            // txtFone
            // 
            this.txtFone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFone.Location = new System.Drawing.Point(295, 524);
            this.txtFone.Name = "txtFone";
            this.txtFone.Size = new System.Drawing.Size(261, 24);
            this.txtFone.TabIndex = 8;
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSenha.Location = new System.Drawing.Point(713, 363);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(56, 20);
            this.labelSenha.TabIndex = 9;
            this.labelSenha.Text = "Senha";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(295, 477);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(261, 24);
            this.txtEmail.TabIndex = 10;
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(716, 381);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(261, 24);
            this.txtSenha.TabIndex = 11;
            // 
            // cbsexo
            // 
            this.cbsexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbsexo.FormattingEnabled = true;
            this.cbsexo.Items.AddRange(new object[] {
            "F",
            "M"});
            this.cbsexo.Location = new System.Drawing.Point(295, 428);
            this.cbsexo.Name = "cbsexo";
            this.cbsexo.Size = new System.Drawing.Size(261, 26);
            this.cbsexo.TabIndex = 12;
            this.cbsexo.SelectedIndexChanged += new System.EventHandler(this.cbsexo_SelectedIndexChanged);
            // 
            // txtWhatsApp
            // 
            this.txtWhatsApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWhatsApp.Location = new System.Drawing.Point(716, 333);
            this.txtWhatsApp.Name = "txtWhatsApp";
            this.txtWhatsApp.Size = new System.Drawing.Size(261, 24);
            this.txtWhatsApp.TabIndex = 13;
            // 
            // btncadastrar
            // 
            this.btncadastrar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btncadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncadastrar.Location = new System.Drawing.Point(716, 567);
            this.btncadastrar.Name = "btncadastrar";
            this.btncadastrar.Size = new System.Drawing.Size(96, 46);
            this.btncadastrar.TabIndex = 15;
            this.btncadastrar.Text = "Cadastrar";
            this.btncadastrar.UseVisualStyleBackColor = false;
            this.btncadastrar.Click += new System.EventHandler(this.btncadastrar_Click);
            // 
            // txtCpf
            // 
            this.txtCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpf.Location = new System.Drawing.Point(295, 379);
            this.txtCpf.Mask = "000,000,000-00";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(261, 24);
            this.txtCpf.TabIndex = 20;
            // 
            // txtEnderecoEstudante
            // 
            this.txtEnderecoEstudante.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnderecoEstudante.Location = new System.Drawing.Point(716, 429);
            this.txtEnderecoEstudante.Name = "txtEnderecoEstudante";
            this.txtEnderecoEstudante.Size = new System.Drawing.Size(261, 24);
            this.txtEnderecoEstudante.TabIndex = 22;
            // 
            // labelEnderecoEstudante
            // 
            this.labelEnderecoEstudante.AutoSize = true;
            this.labelEnderecoEstudante.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnderecoEstudante.Location = new System.Drawing.Point(713, 411);
            this.labelEnderecoEstudante.Name = "labelEnderecoEstudante";
            this.labelEnderecoEstudante.Size = new System.Drawing.Size(78, 20);
            this.labelEnderecoEstudante.TabIndex = 21;
            this.labelEnderecoEstudante.Text = "Endereço";
            // 
            // labelEstadoEstudante
            // 
            this.labelEstadoEstudante.AutoSize = true;
            this.labelEstadoEstudante.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstadoEstudante.Location = new System.Drawing.Point(713, 505);
            this.labelEstadoEstudante.Name = "labelEstadoEstudante";
            this.labelEstadoEstudante.Size = new System.Drawing.Size(60, 20);
            this.labelEstadoEstudante.TabIndex = 23;
            this.labelEstadoEstudante.Text = "Estado";
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
            this.cbEstadoEstudante.Location = new System.Drawing.Point(716, 523);
            this.cbEstadoEstudante.Name = "cbEstadoEstudante";
            this.cbEstadoEstudante.Size = new System.Drawing.Size(261, 26);
            this.cbEstadoEstudante.TabIndex = 24;
            // 
            // labelCodUniversidade
            // 
            this.labelCodUniversidade.AutoSize = true;
            this.labelCodUniversidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodUniversidade.Location = new System.Drawing.Point(292, 557);
            this.labelCodUniversidade.Name = "labelCodUniversidade";
            this.labelCodUniversidade.Size = new System.Drawing.Size(229, 20);
            this.labelCodUniversidade.TabIndex = 25;
            this.labelCodUniversidade.Text = "ID da Universidade e do Curso ";
            this.labelCodUniversidade.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnProximaEtapa
            // 
            this.btnProximaEtapa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProximaEtapa.Location = new System.Drawing.Point(886, 579);
            this.btnProximaEtapa.Name = "btnProximaEtapa";
            this.btnProximaEtapa.Size = new System.Drawing.Size(91, 34);
            this.btnProximaEtapa.TabIndex = 30;
            this.btnProximaEtapa.Text = "Próximo...";
            this.btnProximaEtapa.UseVisualStyleBackColor = true;
            this.btnProximaEtapa.Click += new System.EventHandler(this.btnProximaEtapa_Click);
            // 
            // txtCidadeEstudante
            // 
            this.txtCidadeEstudante.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidadeEstudante.Location = new System.Drawing.Point(716, 477);
            this.txtCidadeEstudante.Name = "txtCidadeEstudante";
            this.txtCidadeEstudante.Size = new System.Drawing.Size(261, 24);
            this.txtCidadeEstudante.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(713, 459);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Cidade";
            // 
            // dgvUniversidades
            // 
            this.dgvUniversidades.AllowUserToAddRows = false;
            this.dgvUniversidades.AllowUserToDeleteRows = false;
            this.dgvUniversidades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvUniversidades.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvUniversidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUniversidades.Location = new System.Drawing.Point(295, 55);
            this.dgvUniversidades.Name = "dgvUniversidades";
            this.dgvUniversidades.ReadOnly = true;
            this.dgvUniversidades.RowHeadersWidth = 45;
            this.dgvUniversidades.Size = new System.Drawing.Size(682, 236);
            this.dgvUniversidades.TabIndex = 33;
            this.dgvUniversidades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUniversidades_CellContentClick);
            // 
            // cbIdUniversidade
            // 
            this.cbIdUniversidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIdUniversidade.FormattingEnabled = true;
            this.cbIdUniversidade.Location = new System.Drawing.Point(295, 575);
            this.cbIdUniversidade.Name = "cbIdUniversidade";
            this.cbIdUniversidade.Size = new System.Drawing.Size(261, 26);
            this.cbIdUniversidade.TabIndex = 34;
            // 
            // FormEstudante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 679);
            this.Controls.Add(this.cbIdUniversidade);
            this.Controls.Add(this.dgvUniversidades);
            this.Controls.Add(this.txtCidadeEstudante);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnProximaEtapa);
            this.Controls.Add(this.labelCodUniversidade);
            this.Controls.Add(this.cbEstadoEstudante);
            this.Controls.Add(this.labelEstadoEstudante);
            this.Controls.Add(this.txtEnderecoEstudante);
            this.Controls.Add(this.labelEnderecoEstudante);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.btncadastrar);
            this.Controls.Add(this.txtWhatsApp);
            this.Controls.Add(this.cbsexo);
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
            this.Name = "FormEstudante";
            this.Text = "Formulário de Cadastro de Estudantes";
            this.Load += new System.EventHandler(this.FormEstudante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUniversidades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelCpf;
        private System.Windows.Forms.Label labelSexo;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelFone;
        private System.Windows.Forms.Label labelWhatsApp;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtFone;
        private System.Windows.Forms.Label labelSenha;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.ComboBox cbsexo;
        private System.Windows.Forms.TextBox txtWhatsApp;
        private System.Windows.Forms.Button btncadastrar;
        private System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.TextBox txtEnderecoEstudante;
        private System.Windows.Forms.Label labelEnderecoEstudante;
        private System.Windows.Forms.Label labelEstadoEstudante;
        private System.Windows.Forms.ComboBox cbEstadoEstudante;
        private System.Windows.Forms.Label labelCodUniversidade;
        private System.Windows.Forms.Button btnProximaEtapa;
        private System.Windows.Forms.TextBox txtCidadeEstudante;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvUniversidades;
        private System.Windows.Forms.ComboBox cbIdUniversidade;
    }
}