using System.Data.SqlClient;

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