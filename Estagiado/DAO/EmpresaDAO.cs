using Estagiado.Conexao;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estagiado.DAO
{
    class EmpresaDAO
    {
        MySqlConnection connection;

        public EmpresaDAO()
        {
            this.connection = ConnectionFactory.getConnection();
        }

        public void CreateEmpresa()
        {
            try
            {

            }
            catch (Exception erroCriacao)
            {
                MessageBox.Show("Erro ao criar: " + erroCriacao);
            }
        }
    }
}
