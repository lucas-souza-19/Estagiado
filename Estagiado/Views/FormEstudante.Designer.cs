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
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.txtFone = new System.Windows.Forms.TextBox();
            this.labelSenha = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.cbsexo = new System.Windows.Forms.ComboBox();
            this.txtWhatsApp = new System.Windows.Forms.TextBox();
            this.dgvEstudante = new System.Windows.Forms.DataGridView();
            this.btncadastrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudante)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(62, 66);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(41, 15);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome";
            this.labelNome.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelCpf
            // 
            this.labelCpf.AutoSize = true;
            this.labelCpf.Location = new System.Drawing.Point(62, 106);
            this.labelCpf.Name = "labelCpf";
            this.labelCpf.Size = new System.Drawing.Size(30, 15);
            this.labelCpf.TabIndex = 1;
            this.labelCpf.Text = "CPF";
            this.labelCpf.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // labelSexo
            // 
            this.labelSexo.AutoSize = true;
            this.labelSexo.Location = new System.Drawing.Point(62, 142);
            this.labelSexo.Name = "labelSexo";
            this.labelSexo.Size = new System.Drawing.Size(35, 15);
            this.labelSexo.TabIndex = 2;
            this.labelSexo.Text = "Sexo";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(62, 184);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(39, 15);
            this.labelEmail.TabIndex = 3;
            this.labelEmail.Text = "Email";
            // 
            // labelFone
            // 
            this.labelFone.AutoSize = true;
            this.labelFone.Location = new System.Drawing.Point(62, 275);
            this.labelFone.Name = "labelFone";
            this.labelFone.Size = new System.Drawing.Size(55, 15);
            this.labelFone.TabIndex = 4;
            this.labelFone.Text = "Telefone";
            // 
            // labelWhatsApp
            // 
            this.labelWhatsApp.AutoSize = true;
            this.labelWhatsApp.Location = new System.Drawing.Point(62, 314);
            this.labelWhatsApp.Name = "labelWhatsApp";
            this.labelWhatsApp.Size = new System.Drawing.Size(62, 15);
            this.labelWhatsApp.TabIndex = 5;
            this.labelWhatsApp.Text = "WhatsApp";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(118, 66);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(261, 20);
            this.txtNome.TabIndex = 6;
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(118, 102);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(261, 20);
            this.txtCpf.TabIndex = 7;
            // 
            // txtFone
            // 
            this.txtFone.Location = new System.Drawing.Point(118, 275);
            this.txtFone.Name = "txtFone";
            this.txtFone.Size = new System.Drawing.Size(261, 20);
            this.txtFone.TabIndex = 8;
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.Location = new System.Drawing.Point(62, 229);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(43, 15);
            this.labelSenha.TabIndex = 9;
            this.labelSenha.Text = "Senha";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(118, 184);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(261, 20);
            this.txtEmail.TabIndex = 10;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(118, 229);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(261, 20);
            this.txtSenha.TabIndex = 11;
            // 
            // cbsexo
            // 
            this.cbsexo.FormattingEnabled = true;
            this.cbsexo.Items.AddRange(new object[] {
            "F",
            "M"});
            this.cbsexo.Location = new System.Drawing.Point(118, 142);
            this.cbsexo.Name = "cbsexo";
            this.cbsexo.Size = new System.Drawing.Size(261, 21);
            this.cbsexo.TabIndex = 12;
            this.cbsexo.SelectedIndexChanged += new System.EventHandler(this.cbsexo_SelectedIndexChanged);
            // 
            // txtWhatsApp
            // 
            this.txtWhatsApp.Location = new System.Drawing.Point(131, 314);
            this.txtWhatsApp.Name = "txtWhatsApp";
            this.txtWhatsApp.Size = new System.Drawing.Size(248, 20);
            this.txtWhatsApp.TabIndex = 13;
            // 
            // dgvEstudante
            // 
            this.dgvEstudante.AllowUserToAddRows = false;
            this.dgvEstudante.AllowUserToDeleteRows = false;
            this.dgvEstudante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstudante.Location = new System.Drawing.Point(400, 66);
            this.dgvEstudante.Name = "dgvEstudante";
            this.dgvEstudante.ReadOnly = true;
            this.dgvEstudante.RowHeadersWidth = 45;
            this.dgvEstudante.Size = new System.Drawing.Size(331, 268);
            this.dgvEstudante.TabIndex = 14;
            this.dgvEstudante.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEstudante_CellContentClick);
            // 
            // btncadastrar
            // 
            this.btncadastrar.Location = new System.Drawing.Point(276, 378);
            this.btncadastrar.Name = "btncadastrar";
            this.btncadastrar.Size = new System.Drawing.Size(103, 23);
            this.btncadastrar.TabIndex = 15;
            this.btncadastrar.Text = "Cadastrar";
            this.btncadastrar.UseVisualStyleBackColor = true;
            this.btncadastrar.Click += new System.EventHandler(this.btncadastrar_Click);
            // 
            // FormEstudante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btncadastrar);
            this.Controls.Add(this.dgvEstudante);
            this.Controls.Add(this.txtWhatsApp);
            this.Controls.Add(this.cbsexo);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.labelSenha);
            this.Controls.Add(this.txtFone);
            this.Controls.Add(this.txtCpf);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudante)).EndInit();
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
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.TextBox txtFone;
        private System.Windows.Forms.Label labelSenha;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.ComboBox cbsexo;
        private System.Windows.Forms.TextBox txtWhatsApp;
        private System.Windows.Forms.DataGridView dgvEstudante;
        private System.Windows.Forms.Button btncadastrar;
    }
}