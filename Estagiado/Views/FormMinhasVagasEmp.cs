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
    public partial class FormMinhasVagasEmp : Form
    {
        private string IdEmpresa;
        public string getIdEmpresa()
        {
            return this.IdEmpresa;
        }
        public void setIdEmpresa(string id_empresa)
        {
            if (!id_empresa.Equals(""))
            {
                this.IdEmpresa = id_empresa;
            }
        }

        public FormMinhasVagasEmp()
        {
            InitializeComponent();
        }

        private void FormMinhasVagasEmp_Load(object sender, EventArgs e)
        {
            cbIdEmpresa.Text = getIdEmpresa();
            cbIdEmpresa.Enabled = false;
            VagaestagioDAO vagas = new VagaestagioDAO();
            dgvMinhasVagasEmp.DataSource = vagas.ReadVaga2(int.Parse(cbIdEmpresa.Text));
        }
        private void dgvMinhasVagasEmp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdVaga.Text = dgvMinhasVagasEmp.CurrentRow.Cells[0].Value.ToString();
            txtTituloVaga.Text = dgvMinhasVagasEmp.CurrentRow.Cells[1].Value.ToString();
            txtRequisito1.Text = dgvMinhasVagasEmp.CurrentRow.Cells[2].Value.ToString();
            txtRequisito2.Text = dgvMinhasVagasEmp.CurrentRow.Cells[3].Value.ToString();
            txtRequisito3.Text = dgvMinhasVagasEmp.CurrentRow.Cells[4].Value.ToString();
            txtPesoRequisito1.Text = dgvMinhasVagasEmp.CurrentRow.Cells[5].Value.ToString();
            txtPesoRequisito2.Text = dgvMinhasVagasEmp.CurrentRow.Cells[6].Value.ToString();
            txtPesoRequisito3.Text = dgvMinhasVagasEmp.CurrentRow.Cells[7].Value.ToString();
        }
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            VagaestagioModel vagaModel = new VagaestagioModel();
            vagaModel.Nome = txtTituloVaga.Text;
            vagaModel.Requisito1 = txtRequisito1.Text;
            vagaModel.Requisito2 = txtRequisito2.Text;
            vagaModel.Requisito3 = txtRequisito3.Text;
            vagaModel.ValRequisito1 = double.Parse(txtPesoRequisito1.Text);
            vagaModel.ValRequisito2 = double.Parse(txtPesoRequisito2.Text);
            vagaModel.ValRequisito3 = double.Parse(txtPesoRequisito3.Text);
            vagaModel.IprVaga = vagaModel.CalcularIpr(vagaModel.ValRequisito1, vagaModel.ValRequisito2, vagaModel.ValRequisito3);
            vagaModel.IdVaga = int.Parse(txtIdVaga.Text);

            VagaestagioDAO vagaDao = new VagaestagioDAO();
            vagaDao.UpdateVaga(vagaModel);

            dgvMinhasVagasEmp.DataSource = vagaDao.ReadVaga2(int.Parse(cbIdEmpresa.Text));
        }
        private void btnExcluirVaga_Click(object sender, EventArgs e)
        {
            if (!txtIdVaga.Text.Equals(""))
            {
                VagaestagioDAO vaga = new VagaestagioDAO();
                vaga.DeleteVaga(int.Parse(txtIdVaga.Text));
                VagaestagioDAO vagaDao = new VagaestagioDAO();
                dgvMinhasVagasEmp.DataSource = vagaDao.ReadVaga2(int.Parse(cbIdEmpresa.Text));
            }
            else
            {
                MessageBox.Show("Clique sobre a vaga ou indique o ID da vaga que deseja excluir!");
            }
        }
    }
}

        /*      
        private void btnEncontrarIdComCpf_Click(object sender, EventArgs e)
        {
            EmpresaModel empresa = new EmpresaModel();
            empresa.Cnpj = txtCnpjEmpresa.Text;
            VagaestagioDAO vaga = new VagaestagioDAO();
            cbIdEmpresa.DataSource = vaga.RecuperarIdEmpresa(empresa);
            cbIdEmpresa.DisplayMember = "ID";
            VagaestagioDAO vagas = new VagaestagioDAO();
            dgvMinhasVagasEmp.DataSource = vagas.ReadVaga2(int.Parse(cbIdEmpresa.Text));
        }
        */
