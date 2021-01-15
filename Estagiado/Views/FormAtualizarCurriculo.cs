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
    public partial class FormAtualizarCurriculo : Form
    {
        private string IdCandidato;
        public string getIdCandidato()
        {
            return this.IdCandidato;
        }
        public void setIdCandidato(string id_candidato)
        {
            if (!id_candidato.Equals(""))
            {
                this.IdCandidato = id_candidato;
            }
        }

        public FormAtualizarCurriculo()
        {
            InitializeComponent();
        }

        private void FormAtualizarCurriculo_Load(object sender, EventArgs e)
        {
            cbIdCandidato.Text = getIdCandidato();
            cbIdCandidato.Visible = false;
            CurriculoDAO curriculoDao = new CurriculoDAO();
            dgvCurriculo.DataSource = curriculoDao.ReadCurriculo(int.Parse(cbIdCandidato.Text));
        }
        private void dgvCurriculo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtFormacaoFinalizada.Text = dgvCurriculo.CurrentRow.Cells[0].Value.ToString();
            txtCursoAtual.Text = dgvCurriculo.CurrentRow.Cells[1].Value.ToString();
            txtAnoInicio.Text = dgvCurriculo.CurrentRow.Cells[2].Value.ToString();
            cbSemestreInicio.Text = dgvCurriculo.CurrentRow.Cells[3].Value.ToString();
            txtAnoPrevistoTermino.Text = dgvCurriculo.CurrentRow.Cells[4].Value.ToString();
            txtSemestreTermino.Text = dgvCurriculo.CurrentRow.Cells[5].Value.ToString();
            cbTurnoCurso.Text = dgvCurriculo.CurrentRow.Cells[6].Value.ToString();
            txtHabilidadesPraticas.Text = dgvCurriculo.CurrentRow.Cells[7].Value.ToString();
            txtConhecimentoTeorico.Text = dgvCurriculo.CurrentRow.Cells[8].Value.ToString();
            txtHorasDiaDisponiveis.Text = dgvCurriculo.CurrentRow.Cells[9].Value.ToString();
        }
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            CurriculoModel curriculoModel = new CurriculoModel();
            curriculoModel.FormacaoFinalizada = txtFormacaoFinalizada.Text;
            curriculoModel.CursoAtual = txtCursoAtual.Text;
            curriculoModel.AnoInicio = int.Parse(txtAnoInicio.Text);
            curriculoModel.SemestreInicio = cbSemestreInicio.Text;
            curriculoModel.AnoTermino = int.Parse(txtAnoPrevistoTermino.Text);
            curriculoModel.SemestreTermino = txtSemestreTermino.Text;
            curriculoModel.TurnoCurso = cbTurnoCurso.Text;
            curriculoModel.HabilidadesPraticas = txtHabilidadesPraticas.Text;
            curriculoModel.ConhecimentoTeorico = txtConhecimentoTeorico.Text;
            curriculoModel.HorasDiariasDisponivel = txtHorasDiaDisponiveis.Text;
            curriculoModel.CodEstudante = int.Parse(cbIdCandidato.Text);
            CurriculoDAO curriculoDao = new CurriculoDAO();
            curriculoDao.UpdateCurriculo(curriculoModel);
            dgvCurriculo.DataSource = curriculoDao.ReadCurriculo(int.Parse(cbIdCandidato.Text));
        }
    }
}


/*
private void btnEncontrarIdComCpf_Click(object sender, EventArgs e)
{
    EstudanteModel estudante = new EstudanteModel();
    estudante.Cpf = txtCpf.Text;
    CurriculoDAO curriculoDao = new CurriculoDAO();
    cbIdCandidato.DataSource = curriculoDao.EncontrarIdEstudante(estudante);
    cbIdCandidato.DisplayMember = "ID";
    CurriculoDAO curriculo = new CurriculoDAO();
    dgvCurriculo.DataSource = curriculo.ReadCurriculo(int.Parse(cbIdCandidato.Text));
}
*/
