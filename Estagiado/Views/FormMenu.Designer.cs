namespace Estagiado.Views
{
    partial class FormMenu
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuEmpresas = new System.Windows.Forms.ToolStripMenuItem();
            this.novaVagaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VagasEmpresa = new System.Windows.Forms.ToolStripMenuItem();
            this.AtualizarCadastroEmpresa = new System.Windows.Forms.ToolStripMenuItem();
            this.ExcluirCadastroEmpresa = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEstudantes = new System.Windows.Forms.ToolStripMenuItem();
            this.AtualizarCadastroEstudante = new System.Windows.Forms.ToolStripMenuItem();
            this.AtualizarCurriculo = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirContaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dgvVagasOuEstudantes = new System.Windows.Forms.DataGridView();
            this.cbVaga = new System.Windows.Forms.ComboBox();
            this.btnCandidatar = new System.Windows.Forms.Button();
            this.labelRequisito1 = new System.Windows.Forms.Label();
            this.labelRequisito2 = new System.Windows.Forms.Label();
            this.labelRequisito3 = new System.Windows.Forms.Label();
            this.labelEscalaDominio = new System.Windows.Forms.Label();
            this.labelIdVaga = new System.Windows.Forms.Label();
            this.cbId = new System.Windows.Forms.ComboBox();
            this.labelMeuId = new System.Windows.Forms.Label();
            this.btnFecharPrograma = new System.Windows.Forms.Button();
            this.dgvMinhasVagas = new System.Windows.Forms.DataGridView();
            this.btnMaisIndicados = new System.Windows.Forms.Button();
            this.txtDomReq1 = new System.Windows.Forms.MaskedTextBox();
            this.txtDomReq2 = new System.Windows.Forms.MaskedTextBox();
            this.txtDomReq3 = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVagasOuEstudantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMinhasVagas)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuEmpresas,
            this.MenuEstudantes});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuEmpresas
            // 
            this.MenuEmpresas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaVagaToolStripMenuItem,
            this.VagasEmpresa,
            this.AtualizarCadastroEmpresa,
            this.ExcluirCadastroEmpresa});
            this.MenuEmpresas.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuEmpresas.Name = "MenuEmpresas";
            this.MenuEmpresas.Size = new System.Drawing.Size(82, 25);
            this.MenuEmpresas.Text = "Empresa";
            // 
            // novaVagaToolStripMenuItem
            // 
            this.novaVagaToolStripMenuItem.Name = "novaVagaToolStripMenuItem";
            this.novaVagaToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.novaVagaToolStripMenuItem.Text = "Nova Vaga";
            this.novaVagaToolStripMenuItem.Click += new System.EventHandler(this.novaVagaToolStripMenuItem_Click);
            // 
            // VagasEmpresa
            // 
            this.VagasEmpresa.Name = "VagasEmpresa";
            this.VagasEmpresa.Size = new System.Drawing.Size(213, 26);
            this.VagasEmpresa.Text = "Alterar Vagas";
            this.VagasEmpresa.Click += new System.EventHandler(this.VagasEmpresa_Click);
            // 
            // AtualizarCadastroEmpresa
            // 
            this.AtualizarCadastroEmpresa.Name = "AtualizarCadastroEmpresa";
            this.AtualizarCadastroEmpresa.Size = new System.Drawing.Size(213, 26);
            this.AtualizarCadastroEmpresa.Text = "Atualizar Cadastro";
            this.AtualizarCadastroEmpresa.Click += new System.EventHandler(this.alterarCadastroToolStripMenuItem_Click);
            // 
            // ExcluirCadastroEmpresa
            // 
            this.ExcluirCadastroEmpresa.Name = "ExcluirCadastroEmpresa";
            this.ExcluirCadastroEmpresa.Size = new System.Drawing.Size(213, 26);
            this.ExcluirCadastroEmpresa.Text = "Excluir Conta";
            this.ExcluirCadastroEmpresa.Click += new System.EventHandler(this.ExcluirCadastroEmpresa_Click);
            // 
            // MenuEstudantes
            // 
            this.MenuEstudantes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AtualizarCadastroEstudante,
            this.AtualizarCurriculo,
            this.excluirContaToolStripMenuItem});
            this.MenuEstudantes.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuEstudantes.Name = "MenuEstudantes";
            this.MenuEstudantes.Size = new System.Drawing.Size(90, 25);
            this.MenuEstudantes.Text = "Estudante";
            // 
            // AtualizarCadastroEstudante
            // 
            this.AtualizarCadastroEstudante.Name = "AtualizarCadastroEstudante";
            this.AtualizarCadastroEstudante.Size = new System.Drawing.Size(215, 26);
            this.AtualizarCadastroEstudante.Text = "Atualizar Cadastro";
            this.AtualizarCadastroEstudante.Click += new System.EventHandler(this.AtualizarCadastroEstudante_Click);
            // 
            // AtualizarCurriculo
            // 
            this.AtualizarCurriculo.Name = "AtualizarCurriculo";
            this.AtualizarCurriculo.Size = new System.Drawing.Size(215, 26);
            this.AtualizarCurriculo.Text = "Atualizar Currículo";
            this.AtualizarCurriculo.Click += new System.EventHandler(this.AtualizarCurriculo_Click);
            // 
            // excluirContaToolStripMenuItem
            // 
            this.excluirContaToolStripMenuItem.Name = "excluirContaToolStripMenuItem";
            this.excluirContaToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.excluirContaToolStripMenuItem.Text = "Excluir Conta";
            this.excluirContaToolStripMenuItem.Click += new System.EventHandler(this.excluirContaToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dgvVagasOuEstudantes
            // 
            this.dgvVagasOuEstudantes.AllowUserToAddRows = false;
            this.dgvVagasOuEstudantes.AllowUserToDeleteRows = false;
            this.dgvVagasOuEstudantes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvVagasOuEstudantes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvVagasOuEstudantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVagasOuEstudantes.Location = new System.Drawing.Point(142, 64);
            this.dgvVagasOuEstudantes.Name = "dgvVagasOuEstudantes";
            this.dgvVagasOuEstudantes.ReadOnly = true;
            this.dgvVagasOuEstudantes.RowHeadersWidth = 45;
            this.dgvVagasOuEstudantes.Size = new System.Drawing.Size(979, 181);
            this.dgvVagasOuEstudantes.TabIndex = 2;
            // 
            // cbVaga
            // 
            this.cbVaga.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVaga.FormattingEnabled = true;
            this.cbVaga.Location = new System.Drawing.Point(142, 495);
            this.cbVaga.Name = "cbVaga";
            this.cbVaga.Size = new System.Drawing.Size(102, 26);
            this.cbVaga.TabIndex = 3;
            // 
            // btnCandidatar
            // 
            this.btnCandidatar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCandidatar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCandidatar.Location = new System.Drawing.Point(465, 557);
            this.btnCandidatar.Name = "btnCandidatar";
            this.btnCandidatar.Size = new System.Drawing.Size(96, 46);
            this.btnCandidatar.TabIndex = 4;
            this.btnCandidatar.Text = "Candidatar";
            this.btnCandidatar.UseVisualStyleBackColor = false;
            this.btnCandidatar.Click += new System.EventHandler(this.btnCandidatar_Click);
            // 
            // labelRequisito1
            // 
            this.labelRequisito1.AutoSize = true;
            this.labelRequisito1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRequisito1.Location = new System.Drawing.Point(303, 494);
            this.labelRequisito1.Name = "labelRequisito1";
            this.labelRequisito1.Size = new System.Drawing.Size(89, 20);
            this.labelRequisito1.TabIndex = 5;
            this.labelRequisito1.Text = "Requisito 1";
            // 
            // labelRequisito2
            // 
            this.labelRequisito2.AutoSize = true;
            this.labelRequisito2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRequisito2.Location = new System.Drawing.Point(303, 537);
            this.labelRequisito2.Name = "labelRequisito2";
            this.labelRequisito2.Size = new System.Drawing.Size(89, 20);
            this.labelRequisito2.TabIndex = 6;
            this.labelRequisito2.Text = "Requisito 2";
            // 
            // labelRequisito3
            // 
            this.labelRequisito3.AutoSize = true;
            this.labelRequisito3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRequisito3.Location = new System.Drawing.Point(303, 581);
            this.labelRequisito3.Name = "labelRequisito3";
            this.labelRequisito3.Size = new System.Drawing.Size(89, 20);
            this.labelRequisito3.TabIndex = 7;
            this.labelRequisito3.Text = "Requisito 3";
            // 
            // labelEscalaDominio
            // 
            this.labelEscalaDominio.AutoSize = true;
            this.labelEscalaDominio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEscalaDominio.Location = new System.Drawing.Point(304, 443);
            this.labelEscalaDominio.Name = "labelEscalaDominio";
            this.labelEscalaDominio.Size = new System.Drawing.Size(260, 34);
            this.labelEscalaDominio.TabIndex = 59;
            this.labelEscalaDominio.Text = "Qua é o seu domínio de cada requisito?\r\nIndique de 0 (sem) a 9,99 (muito)";
            // 
            // labelIdVaga
            // 
            this.labelIdVaga.AutoSize = true;
            this.labelIdVaga.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdVaga.Location = new System.Drawing.Point(139, 474);
            this.labelIdVaga.Name = "labelIdVaga";
            this.labelIdVaga.Size = new System.Drawing.Size(90, 20);
            this.labelIdVaga.TabIndex = 60;
            this.labelIdVaga.Text = "ID da Vaga";
            // 
            // cbId
            // 
            this.cbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbId.FormattingEnabled = true;
            this.cbId.Location = new System.Drawing.Point(200, 438);
            this.cbId.Name = "cbId";
            this.cbId.Size = new System.Drawing.Size(44, 26);
            this.cbId.TabIndex = 61;
            // 
            // labelMeuId
            // 
            this.labelMeuId.AutoSize = true;
            this.labelMeuId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMeuId.Location = new System.Drawing.Point(138, 440);
            this.labelMeuId.Name = "labelMeuId";
            this.labelMeuId.Size = new System.Drawing.Size(61, 20);
            this.labelMeuId.TabIndex = 62;
            this.labelMeuId.Text = "Meu ID";
            // 
            // btnFecharPrograma
            // 
            this.btnFecharPrograma.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFecharPrograma.Location = new System.Drawing.Point(1027, 562);
            this.btnFecharPrograma.Name = "btnFecharPrograma";
            this.btnFecharPrograma.Size = new System.Drawing.Size(94, 41);
            this.btnFecharPrograma.TabIndex = 65;
            this.btnFecharPrograma.Text = "Fechar";
            this.btnFecharPrograma.UseVisualStyleBackColor = true;
            this.btnFecharPrograma.Click += new System.EventHandler(this.btnFecharPrograma_Click);
            // 
            // dgvMinhasVagas
            // 
            this.dgvMinhasVagas.AllowUserToAddRows = false;
            this.dgvMinhasVagas.AllowUserToDeleteRows = false;
            this.dgvMinhasVagas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvMinhasVagas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvMinhasVagas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMinhasVagas.Location = new System.Drawing.Point(142, 282);
            this.dgvMinhasVagas.Name = "dgvMinhasVagas";
            this.dgvMinhasVagas.ReadOnly = true;
            this.dgvMinhasVagas.RowHeadersWidth = 45;
            this.dgvMinhasVagas.Size = new System.Drawing.Size(979, 148);
            this.dgvMinhasVagas.TabIndex = 67;
            // 
            // btnMaisIndicados
            // 
            this.btnMaisIndicados.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnMaisIndicados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaisIndicados.Location = new System.Drawing.Point(142, 537);
            this.btnMaisIndicados.Name = "btnMaisIndicados";
            this.btnMaisIndicados.Size = new System.Drawing.Size(102, 73);
            this.btnMaisIndicados.TabIndex = 68;
            this.btnMaisIndicados.Text = "Candidatos Mais Indicados";
            this.btnMaisIndicados.UseVisualStyleBackColor = false;
            this.btnMaisIndicados.Click += new System.EventHandler(this.btnMaisIndicados_Click);
            // 
            // txtDomReq1
            // 
            this.txtDomReq1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDomReq1.Location = new System.Drawing.Point(398, 490);
            this.txtDomReq1.Mask = "0.00";
            this.txtDomReq1.Name = "txtDomReq1";
            this.txtDomReq1.Size = new System.Drawing.Size(47, 24);
            this.txtDomReq1.TabIndex = 69;
            // 
            // txtDomReq2
            // 
            this.txtDomReq2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDomReq2.Location = new System.Drawing.Point(398, 533);
            this.txtDomReq2.Mask = "0.00";
            this.txtDomReq2.Name = "txtDomReq2";
            this.txtDomReq2.Size = new System.Drawing.Size(47, 24);
            this.txtDomReq2.TabIndex = 70;
            // 
            // txtDomReq3
            // 
            this.txtDomReq3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDomReq3.Location = new System.Drawing.Point(398, 577);
            this.txtDomReq3.Mask = "0.00";
            this.txtDomReq3.Name = "txtDomReq3";
            this.txtDomReq3.Size = new System.Drawing.Size(47, 24);
            this.txtDomReq3.TabIndex = 71;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(138, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 72;
            this.label1.Text = "Minhas Vagas\r\n";
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 679);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDomReq3);
            this.Controls.Add(this.txtDomReq2);
            this.Controls.Add(this.txtDomReq1);
            this.Controls.Add(this.btnMaisIndicados);
            this.Controls.Add(this.dgvMinhasVagas);
            this.Controls.Add(this.btnFecharPrograma);
            this.Controls.Add(this.labelMeuId);
            this.Controls.Add(this.cbId);
            this.Controls.Add(this.labelIdVaga);
            this.Controls.Add(this.labelEscalaDominio);
            this.Controls.Add(this.labelRequisito3);
            this.Controls.Add(this.labelRequisito2);
            this.Controls.Add(this.labelRequisito1);
            this.Controls.Add(this.btnCandidatar);
            this.Controls.Add(this.cbVaga);
            this.Controls.Add(this.dgvVagasOuEstudantes);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMenu";
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVagasOuEstudantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMinhasVagas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        public System.Windows.Forms.ToolStripMenuItem MenuEmpresas;
        public System.Windows.Forms.ToolStripMenuItem MenuEstudantes;
        public System.Windows.Forms.ToolStripMenuItem VagasEmpresa;
        public System.Windows.Forms.ToolStripMenuItem AtualizarCadastroEmpresa;
        public System.Windows.Forms.ToolStripMenuItem ExcluirCadastroEmpresa;
        public System.Windows.Forms.ToolStripMenuItem AtualizarCadastroEstudante;
        public System.Windows.Forms.ToolStripMenuItem AtualizarCurriculo;
        public System.Windows.Forms.DataGridView dgvVagasOuEstudantes;
        public System.Windows.Forms.ComboBox cbVaga;
        public System.Windows.Forms.ComboBox cbId;
        private System.Windows.Forms.Button btnFecharPrograma;
        public System.Windows.Forms.Button btnCandidatar;
        public System.Windows.Forms.Label labelRequisito1;
        public System.Windows.Forms.Label labelRequisito2;
        public System.Windows.Forms.Label labelRequisito3;
        public System.Windows.Forms.Label labelEscalaDominio;
        public System.Windows.Forms.Label labelIdVaga;
        public System.Windows.Forms.Label labelMeuId;
        private System.Windows.Forms.ToolStripMenuItem excluirContaToolStripMenuItem;
        public System.Windows.Forms.DataGridView dgvMinhasVagas;
        public System.Windows.Forms.Button btnMaisIndicados;
        public System.Windows.Forms.MaskedTextBox txtDomReq1;
        public System.Windows.Forms.MaskedTextBox txtDomReq2;
        public System.Windows.Forms.MaskedTextBox txtDomReq3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem novaVagaToolStripMenuItem;
    }
}