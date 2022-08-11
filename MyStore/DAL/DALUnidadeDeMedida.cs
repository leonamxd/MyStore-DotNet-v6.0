using Model;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DALUnidadeDeMedida
    {
        private DALConexao DALConexao;

        public DALUnidadeDeMedida(DALConexao _cx)
        {
            DALConexao = _cx;
        }

        public void Incluir(ModelUnidadeDeMedida _model)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = DALConexao.Conexao;
                cmd.CommandText = "insert into undmedida(umed_nome) " +
                    "values(@nome) select @@IDENTITY;";
                cmd.Parameters.AddWithValue("@nome", _model.Umed_nome);
                DALConexao.Conectar();
                _model.Umed_cod = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
            finally
            {
                DALConexao.Desconectar();
            }
        }

        public void Alterar(ModelUnidadeDeMedida _model)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = DALConexao.Conexao;
                cmd.CommandText = "update undmedida set umed_nome = @nome " +
                    "where umed_cod = @cod";
                cmd.Parameters.AddWithValue("@nome", _model.Umed_nome);
                cmd.Parameters.AddWithValue("@cod", _model.Umed_cod);
                DALConexao.Conectar();
                cmd.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
            finally
            {
                DALConexao.Desconectar();
            }
        }

        public void Excluir(int _cod)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = DALConexao.Conexao;
                cmd.CommandText = "delete from undmedida where umed_cod = @codigo";
                cmd.Parameters.AddWithValue("@codigo", _cod);
                DALConexao.Conectar();
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Erro na exclusão.\n" +
                    "O registro pode está sendo usado em outra tabela!");
            }
            finally
            {
                DALConexao.Desconectar();
            }
        }

        public DataTable Localizar(String _value)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from undmedida " +
                "where umed_nome like '%" + _value + "%'", DALConexao.StringConexao);
            sqlDataAdapter.Fill(tabela);
            return tabela;
        }

        public int VerificaUnidadeDeMedida(String _value)
        {
            int aux = 0;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = DALConexao.Conexao;
            cmd.CommandText = "select * from undmedida where umed_nome = @nome";
            cmd.Parameters.AddWithValue("@nome", _value);
            DALConexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                aux = Convert.ToInt32(registro["umed_cod"]);
            }
            DALConexao.Desconectar();
            return aux;
        }

        public ModelUnidadeDeMedida CarregaModelUnidadeDeMedida(int _cod)
        {
            ModelUnidadeDeMedida model = new ModelUnidadeDeMedida();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = DALConexao.Conexao;
            cmd.CommandText = "select * from undmedida where umed_cod = @codigo";
            cmd.Parameters.AddWithValue("@codigo", _cod);
            DALConexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                model.Umed_cod = Convert.ToInt32(registro["umed_cod"]);
                model.Umed_nome = Convert.ToString(registro["umed_nome"]);
            }
            DALConexao.Desconectar();
            return model;
        }
    }
}