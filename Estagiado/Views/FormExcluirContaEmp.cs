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
    public partial class FormExcluirContaEmp : Form
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

        public FormExcluirContaEmp()
        {
            InitializeComponent();
        }

        private void FormExcluirContaEmp_Load(object sender, EventArgs e)
        {
            cbIdEmpresa.Text = getIdEmpresa();
            cbIdEmpresa.Enabled = false;
            VagaestagioDAO vagas = new VagaestagioDAO();
            dgvMinhasVagasEmp.DataSource = vagas.ReadVaga2(int.Parse(cbIdEmpresa.Text));
        }
        private void btnExcluirVagasAntes_Click(object sender, EventArgs e)
        {
            FormMinhasVagasEmp form = new FormMinhasVagasEmp();
            form.setIdEmpresa(cbIdEmpresa.Text);
            form.Show();         
        }
        private void btnExcluirConta_Click(object sender, EventArgs e)
        {
            if (dgvMinhasVagasEmp.RowCount == 0){ 
                EmpresaDAO empresa = new EmpresaDAO();
                empresa.DeleteEmpresa(int.Parse(cbIdEmpresa.Text));
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Exclua suas vagas antes!");
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
}
*/
