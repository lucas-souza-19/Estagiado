using MySql.Data.MySqlClient;
using System.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estagiado.Conexao
{
    public class ConnectionFactory
    {
        public static MySqlConnection getConnection()
        {
            string conexaoBD = ConfigurationManager.ConnectionStrings["estagiado"].ConnectionString;
            return new MySqlConnection(conexaoBD);
        }
    }
}
