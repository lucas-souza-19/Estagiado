using Estagiado.DAO;
using Estagiado.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estagiado.Views
{
    public partial class FormCurriculo : Form
    {
        public FormCurriculo()
        {
            InitializeComponent();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            FormMainEstudante form = new FormMainEstudante();
            form.Show();
        }

        private void btnCadastrarCurriculo_Click(object sender, EventArgs e)
        {
            CurriculoModel curriculo = new CurriculoModel();
            curriculo.FormacaoFinalizada = txtFormacaoFinalizada.Text;
            curriculo.CursoAtual = txtCursoAtual.Text;
            curriculo.AnoInicio = int.Parse(txtAnoInicio.Text);
            curriculo.SemestreInicio = cbSemestreInicio.Text;
            curriculo.AnoTermino = int.Parse(txtAnoPrevistoTermino.Text);
            curriculo.SemestreTermino = txtSemestreTermino.Text;
            curriculo.TurnoCurso = cbTurnoCurso.Text;
            curriculo.HabilidadesPraticas = txtHabilidadesPraticas.Text;
            curriculo.ConhecimentoTeorico = txtConhecimentoTeorico.Text;
            curriculo.HorasDiariasDisponivel = txtHorasDiaDisponiveis.Text;
            curriculo.CodEstudante = int.Parse(cbIdEstudante.Text);
            CurriculoDAO curriculoDao = new CurriculoDAO();
            curriculoDao.CreateCurriculo(curriculo);
        }
        private void btnEncontrarIdComCpf_Click(object sender, EventArgs e)
        {
            EstudanteModel estudante = new EstudanteModel();
            estudante.Cpf = txtCpf.Text;
            CurriculoDAO curriculoDao = new CurriculoDAO();
            cbIdEstudante.DataSource = curriculoDao.EncontrarIdEstudante(estudante);
            cbIdEstudante.DisplayMember = "ID";
        }
        private void txtCpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
           
        }
        private void FormCurriculo_Load(object sender, EventArgs e)
        {

        }

    }
}
