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
    public partial class FormAtualizarCadastro : Form
    {
        public FormAtualizarCadastro()
        {
            InitializeComponent();
        }
        public FormAtualizarCadastro(string id_candidato)
        {
            InitializeComponent();
            cbIdCandidato.Text = id_candidato;
            cbIdCandidato.Visible = false;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            EstudanteModel obj_estudante = new EstudanteModel();
            obj_estudante.Nome = txtNome.Text;
            obj_estudante.Cpf = txtCpf.Text;
            obj_estudante.Sexo = cbSexo.Text;
            obj_estudante.Email = txtEmail.Text;
            obj_estudante.Fone = txtFone.Text;
            obj_estudante.Whatsapp = txtWhatsApp.Text;
            obj_estudante.Senha = txtSenha.Text;
            obj_estudante.Endereco = txtEnderecoEstudante.Text;
            obj_estudante.Cidade = txtCidadeEstudante.Text;
            obj_estudante.Estado = cbEstadoEstudante.Text;
            obj_estudante.CodUniversidade = int.Parse(cbIdUniversidade.Text);
            obj_estudante.NivelAcesso = "Estudante";
            obj_estudante.Id = int.Parse(cbIdCandidato.Text); 

            EstudantesDAO estudanteDao = new EstudantesDAO();
            estudanteDao.UpdateEstudante(obj_estudante);
            dgvEstudante.DataSource = estudanteDao.ReadEstudantes2(int.Parse(cbIdCandidato.Text));
        }

        private void dgvUniversidades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNome.Text = dgvEstudante.CurrentRow.Cells[0].Value.ToString();
            txtCpf.Text = dgvEstudante.CurrentRow.Cells[1].Value.ToString();
            cbSexo.Text = dgvEstudante.CurrentRow.Cells[2].Value.ToString();
            txtEmail.Text = dgvEstudante.CurrentRow.Cells[3].Value.ToString();
            txtFone.Text = dgvEstudante.CurrentRow.Cells[4].Value.ToString();
            txtWhatsApp.Text = dgvEstudante.CurrentRow.Cells[5].Value.ToString();
            txtSenha.Text = dgvEstudante.CurrentRow.Cells[6].Value.ToString();
            txtEnderecoEstudante.Text = dgvEstudante.CurrentRow.Cells[7].Value.ToString();
            txtCidadeEstudante.Text = dgvEstudante.CurrentRow.Cells[8].Value.ToString();
            cbEstadoEstudante.Text = dgvEstudante.CurrentRow.Cells[9].Value.ToString();
            cbIdUniversidade.Text = dgvEstudante.CurrentRow.Cells[10].Value.ToString();
        }

        private void FormAtualizarCadastro_Load(object sender, EventArgs e)
        {
            EstudantesDAO estudanteDao = new EstudantesDAO();
            dgvEstudante.DataSource = estudanteDao.ReadEstudantes2(int.Parse(cbIdCandidato.Text));
            cbIdUniversidade.Enabled = false;
        }
    }
}

/*
private void btnEncontrarIdComCpf_Click(object sender, EventArgs e)
{
    EstudanteModel estudante = new EstudanteModel();
    estudante.Cpf = txtCpfBusca.Text;
    CurriculoDAO curriculoDao = new CurriculoDAO();
    cbIdCandidato.DataSource = curriculoDao.EncontrarIdEstudante(estudante);
    cbIdCandidato.DisplayMember = "ID";
    EstudantesDAO estudanteDao = new EstudantesDAO();
    dgvEstudante.DataSource = estudanteDao.ReadEstudantes2(int.Parse(cbIdCandidato.Text));
}
*/
