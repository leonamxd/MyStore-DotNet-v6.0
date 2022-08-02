using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALConexao
    {
        public String StringConexao { get; set; }
        public SqlConnection Conexao { get; set; }

        public DALConexao(String _dadosConexao)
        {
            Conexao = new SqlConnection();
            StringConexao = _dadosConexao;
            Conexao.ConnectionString = _dadosConexao;
        }

        public void Conectar()
        {
            Conexao.Open();
        }
        public void Desconectar()
        {
            Conexao.Close();
        }
    }
}
