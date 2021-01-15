namespace Estagiado.Views
{
    partial class FormAtualizarCurriculo
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
            this.cbIdCandidato = new System.Windows.Forms.ComboBox();
            this.dgvCurriculo = new System.Windows.Forms.DataGridView();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.txtHorasDiaDisponiveis = new System.Windows.Forms.MaskedTextBox();
            this.cbTurnoCurso = new System.Windows.Forms.ComboBox();
            this.txtSemestreTermino = new System.Windows.Forms.ComboBox();
            this.txtAnoPrevistoTermino = new System.Windows.Forms.MaskedTextBox();
            this.txtAnoInicio = new System.Windows.Forms.MaskedTextBox();
            this.cbSemestreInicio = new System.Windows.Forms.ComboBox();
            this.txtConhecimentoTeorico = new System.Windows.Forms.TextBox();
            this.txtHabilidadesPraticas = new System.Windows.Forms.TextBox();
            this.txtCursoAtual = new System.Windows.Forms.TextBox();
            this.txtFormacaoFinalizada = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurriculo)).BeginInit();
            this.SuspendLayout();
            // 
            // cbIdCandidato
            // 
            this.cbIdCandidato.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIdCandidato.FormattingEnabled = true;
            this.cbIdCandidato.Location = new System.Drawing.Point(316, 51);
            this.cbIdCandidato.Name = "cbIdCandidato";
            this.cbIdCandidato.Size = new System.Drawing.Size(48, 26);
            this.cbIdCandidato.TabIndex = 56;
            // 
            // dgvCurriculo
            // 
            this.dgvCurriculo.AllowUserToAddRows = false;
            this.dgvCurriculo.AllowUserToDeleteRows = false;
            this.dgvCurriculo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvCurriculo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvCurriculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCurriculo.Location = new System.Drawing.Point(316, 83);
            this.dgvCurriculo.Name = "dgvCurriculo";
            this.dgvCurriculo.ReadOnly = true;
            this.dgvCurriculo.RowHeadersWidth = 45;
            this.dgvCurriculo.Size = new System.Drawing.Size(636, 101);
            this.dgvCurriculo.TabIndex = 58;
            this.dgvCurriculo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCurriculo_CellContentClick);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Location = new System.Drawing.Point(865, 552);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(86, 46);
            this.btnAtualizar.TabIndex = 59;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // txtHorasDiaDisponiveis
            // 
            this.txtHorasDiaDisponiveis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHorasDiaDisponiveis.Location = new System.Drawing.Point(442, 390);
            this.txtHorasDiaDisponiveis.Mask = "0:00";
            this.txtHorasDiaDisponiveis.Name = "txtHorasDiaDisponiveis";
            this.txtHorasDiaDisponiveis.Size = new System.Drawing.Size(177, 24);
            this.txtHorasDiaDisponiveis.TabIndex = 79;
            // 
            // cbTurnoCurso
            // 
            this.cbTurnoCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTurnoCurso.FormattingEnabled = true;
            this.cbTurnoCurso.Items.AddRange(new object[] {
            "Matutino",
            "Vespertino",
            "Noturno"});
            this.cbTurnoCurso.Location = new System.Drawing.Point(317, 388);
            this.cbTurnoCurso.Name = "cbTurnoCurso";
            this.cbTurnoCurso.Size = new System.Drawing.Size(106, 26);
            this.cbTurnoCurso.TabIndex = 78;
            // 
            // txtSemestreTermino
            // 
            this.txtSemestreTermino.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSemestreTermino.FormattingEnabled = true;
            this.txtSemestreTermino.Items.AddRange(new object[] {
            "Primeiro",
            "Segundo"});
            this.txtSemestreTermino.Location = new System.Drawing.Point(795, 333);
            this.txtSemestreTermino.Name = "txtSemestreTermino";
            this.txtSemestreTermino.Size = new System.Drawing.Size(157, 26);
            this.txtSemestreTermino.TabIndex = 77;
            // 
            // txtAnoPrevistoTermino
            // 
            this.txtAnoPrevistoTermino.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnoPrevistoTermino.Location = new System.Drawing.Point(586, 333);
            this.txtAnoPrevistoTermino.Mask = "0000";
            this.txtAnoPrevistoTermino.Name = "txtAnoPrevistoTermino";
            this.txtAnoPrevistoTermino.Size = new System.Drawing.Size(192, 24);
            this.txtAnoPrevistoTermino.TabIndex = 76;
            // 
            // txtAnoInicio
            // 
            this.txtAnoInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnoInicio.Location = new System.Drawing.Point(317, 332);
            this.txtAnoInicio.Mask = "0000";
            this.txtAnoInicio.Name = "txtAnoInicio";
            this.txtAnoInicio.Size = new System.Drawing.Size(98, 24);
            this.txtAnoInicio.TabIndex = 75;
            // 
            // cbSemestreInicio
            // 
            this.cbSemestreInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSemestreInicio.FormattingEnabled = true;
            this.cbSemestreInicio.Items.AddRange(new object[] {
            "Primeiro",
            "Segundo"});
            this.cbSemestreInicio.Location = new System.Drawing.Point(432, 332);
            this.cbSemestreInicio.Name = "cbSemestreInicio";
            this.cbSemestreInicio.Size = new System.Drawing.Size(136, 26);
            this.cbSemestreInicio.TabIndex = 74;
            // 
            // txtConhecimentoTeorico
            // 
            this.txtConhecimentoTeorico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConhecimentoTeorico.Location = new System.Drawing.Point(316, 500);
            this.txtConhecimentoTeorico.Name = "txtConhecimentoTeorico";
            this.txtConhecimentoTeorico.Size = new System.Drawing.Size(635, 24);
            this.txtConhecimentoTeorico.TabIndex = 73;
            // 
            // txtHabilidadesPraticas
            // 
            this.txtHabilidadesPraticas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHabilidadesPraticas.Location = new System.Drawing.Point(317, 446);
            this.txtHabilidadesPraticas.Name = "txtHabilidadesPraticas";
            this.txtHabilidadesPraticas.Size = new System.Drawing.Size(634, 24);
            this.txtHabilidadesPraticas.TabIndex = 72;
            // 
            // txtCursoAtual
            // 
            this.txtCursoAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCursoAtual.Location = new System.Drawing.Point(317, 276);
            this.txtCursoAtual.Name = "txtCursoAtual";
            this.txtCursoAtual.Size = new System.Drawing.Size(635, 24);
            this.txtCursoAtual.TabIndex = 71;
            // 
            // txtFormacaoFinalizada
            // 
            this.txtFormacaoFinalizada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFormacaoFinalizada.Location = new System.Drawing.Point(317, 221);
            this.txtFormacaoFinalizada.Name = "txtFormacaoFinalizada";
            this.txtFormacaoFinalizada.Size = new System.Drawing.Size(635, 24);
            this.txtFormacaoFinalizada.TabIndex = 70;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(438, 373);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(181, 20);
            this.label10.TabIndex = 69;
            this.label10.Text = "Horas Diárias Disponível";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(313, 482);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(168, 20);
            this.label9.TabIndex = 68;
            this.label9.Text = "Conhecimento Teórico";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(313, 428);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 20);
            this.label8.TabIndex = 67;
            this.label8.Text = "Habilidades Práticas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(313, 370);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 20);
            this.label7.TabIndex = 66;
            this.label7.Text = "Turno do Curso";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(791, 315);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 20);
            this.label6.TabIndex = 65;
            this.label6.Text = "Semestre de Término";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(583, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 20);
            this.label5.TabIndex = 64;
            this.label5.Text = "Ano Previsto para Término";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(428, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 20);
            this.label4.TabIndex = 63;
            this.label4.Text = "Semestre de Início";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(314, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 62;
            this.label3.Text = "Ano de Início";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(314, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 61;
            this.label2.Text = "Curso Atual";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(314, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 20);
            this.label1.TabIndex = 60;
            this.label1.Text = "Formação Finalizada";
            // 
            // FormAtualizarCurriculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 679);
            this.Controls.Add(this.txtHorasDiaDisponiveis);
            this.Controls.Add(this.cbTurnoCurso);
            this.Controls.Add(this.txtSemestreTermino);
            this.Controls.Add(this.txtAnoPrevistoTermino);
            this.Controls.Add(this.txtAnoInicio);
            this.Controls.Add(this.cbSemestreInicio);
            this.Controls.Add(this.txtConhecimentoTeorico);
            this.Controls.Add(this.txtHabilidadesPraticas);
            this.Controls.Add(this.txtCursoAtual);
            this.Controls.Add(this.txtFormacaoFinalizada);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.dgvCurriculo);
            this.Controls.Add(this.cbIdCandidato);
            this.Name = "FormAtualizarCurriculo";
            this.Text = "Formulário de Atualização de Currículo";
            this.Load += new System.EventHandler(this.FormAtualizarCurriculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurriculo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbIdCandidato;
        private System.Windows.Forms.DataGridView dgvCurriculo;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.MaskedTextBox txtHorasDiaDisponiveis;
        private System.Windows.Forms.ComboBox cbTurnoCurso;
        private System.Windows.Forms.ComboBox txtSemestreTermino;
        private System.Windows.Forms.MaskedTextBox txtAnoPrevistoTermino;
        private System.Windows.Forms.MaskedTextBox txtAnoInicio;
        private System.Windows.Forms.ComboBox cbSemestreInicio;
        private System.Windows.Forms.TextBox txtConhecimentoTeorico;
        private System.Windows.Forms.TextBox txtHabilidadesPraticas;
        private System.Windows.Forms.TextBox txtCursoAtual;
        private System.Windows.Forms.TextBox txtFormacaoFinalizada;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}