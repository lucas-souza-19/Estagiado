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
    public partial class FormUniversidade : Form
    {
        public FormUniversidade()
        {
            InitializeComponent();
        }

        private void FormUniversidade_Load(object sender, EventArgs e)
        {
            UniversidadeDAO univDao = new UniversidadeDAO();
            dgvUniversidades.DataSource = univDao.ReadUniversidade();
        }
        private void btnCadastrarUniversidade_Click(object sender, EventArgs e)
        {
            UniversidadeModel universidadeModel = new UniversidadeModel();
            universidadeModel.setNome(txtNomeUniversidade.Text);
            universidadeModel.setCurso(txtCursoUniversidade.Text);
            universidadeModel.setAvaliacaoMec(int.Parse(cbNotaEnade.Text));
            universidadeModel.setEndereco(txtEnderecoUniversidade.Text);
            universidadeModel.setCidade(txtCidadeUniversidade.Text);
            universidadeModel.setEstado(cbEstadoUniversidade.Text);
            UniversidadeDAO univDao = new UniversidadeDAO();
            univDao.CreateUniversidade(universidadeModel);
            dgvUniversidades.DataSource = univDao.ReadUniversidade();
        }
        private void btnProximaEtapa_Click(object sender, EventArgs e)
        {       
            FormEstudante formEstudante = new FormEstudante();
            formEstudante.Show();
        }
        private void dgvUniversidades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        private void txtCidadeUniversidade_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
