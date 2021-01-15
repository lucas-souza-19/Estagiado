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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btnCandidatar_Click(object sender, EventArgs e)
        {
            VagaestagioDAO vaga = new VagaestagioDAO();
            CandidaturaModel candidaturaModel = new CandidaturaModel();
            candidaturaModel.setCodVagaestagio(int.Parse(cbVaga.Text));
            candidaturaModel.setCodCandidato(int.Parse(cbId.Text));
            candidaturaModel.setIprCandidato(candidaturaModel.CalcularIprCandidato(double.Parse(txtDomReq1.Text), double.Parse(txtDomReq2.Text), double.Parse(txtDomReq3.Text)));
            double iprCandidato = candidaturaModel.CalcularIprCandidato(double.Parse(txtDomReq1.Text), double.Parse(txtDomReq2.Text), double.Parse(txtDomReq3.Text));
            double iprVaga = vaga.RecuperarIprVaga(int.Parse(cbVaga.Text));
            candidaturaModel.setDistanciaDoIprDaVaga(candidaturaModel.CalcularDistanciaDoIprDaVaga(iprCandidato, iprVaga));
            CandidaturaDAO candidaturaDao = new CandidaturaDAO();
            candidaturaDao.CreateCandidatura(candidaturaModel);
            dgvMinhasVagas.DataSource = candidaturaDao.RecuperarMinhasVagas(int.Parse(cbId.Text));
        }
        private void alterarCadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAtualizarCadastroEmp form = new FormAtualizarCadastroEmp();
            form.setIdEmpresa(cbId.Text);
            form.Show();
        }
        private void AtualizarCadastroEstudante_Click(object sender, EventArgs e)
        {
            FormAtualizarCadastro form = new FormAtualizarCadastro(cbId.Text);
            form.Show();
        }
        private void AtualizarCurriculo_Click(object sender, EventArgs e)
        {
            FormAtualizarCurriculo form = new FormAtualizarCurriculo();
            form.setIdCandidato(cbId.Text);
            form.Show();
        }
        private void btnFecharPrograma_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void VagasEmpresa_Click(object sender, EventArgs e)
        {
            FormMinhasVagasEmp form = new FormMinhasVagasEmp();
            form.setIdEmpresa(cbId.Text);
            form.Show();
        }
        private void btnMaisIndicados_Click(object sender, EventArgs e)
        {
            CandidaturaDAO candidatura = new CandidaturaDAO();
            dgvVagasOuEstudantes.DataSource = candidatura.BuscarCandidatos(int.Parse(cbVaga.Text));
        }
        private void novaVagaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVagaestagio vaga = new FormVagaestagio();
            vaga.btnFinalizar.Visible = false;
            vaga.setIdEmpresa(cbId.Text);
            vaga.Show();
        }
        private void ExcluirCadastroEmpresa_Click(object sender, EventArgs e)
        {
            FormExcluirContaEmp form = new FormExcluirContaEmp();
            form.setIdEmpresa(cbId.Text);
            form.Show();
        }
        private void excluirContaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormExcluirContaEst form = new FormExcluirContaEst();
            form.Show();
        }
        private void FormMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
