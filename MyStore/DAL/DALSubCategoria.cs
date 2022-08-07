using Model;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DALSubCategoria
    {
        private DALConexao DALconexao;

        public DALSubCategoria(DALConexao _cx)
        {
            DALconexao = _cx;
        }

        public void Incluir(ModelSubCategoria _model)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = DALconexao.Conexao;
                cmd.CommandText = "insert into subcategoria(cat_cod, scat_nome) " +
                    "values(@catcod, @nome) select @@IDENTITY;";
                cmd.Parameters.AddWithValue("@catcod", _model.FK_Cat_cod);
                cmd.Parameters.AddWithValue("@nome", _model.Scat_nome);
                DALconexao.Conectar();
                _model.Scat_cod = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
            finally
            {
                DALconexao.Desconectar();
            }
        }

        public void Alterar(ModelSubCategoria _model)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = DALconexao.Conexao;
                cmd.CommandText = "update subcategoria set " +
                    "scat_nome = @nome, cat_cod = @catcod " +
                    "where scat_cod = @scatcod";
                cmd.Parameters.AddWithValue("@nome", _model.Scat_nome);
                cmd.Parameters.AddWithValue("@catcod", _model.FK_Cat_cod);
                cmd.Parameters.AddWithValue("@scatcod", _model.Scat_cod);
                DALconexao.Conectar();
                cmd.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
            finally
            {
                DALconexao.Desconectar();
            }
        }

        public void Excluir(int _cod)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = DALconexao.Conexao;
                cmd.CommandText = "delete from subcategoria where scat_cod = @scodigo";
                cmd.Parameters.AddWithValue("@scodigo", _cod);
                DALconexao.Conectar();
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Erro na exclusão.\n" +
                    "O registro pode está sendo usado em outra tabela!");
            }
            finally
            {
                DALconexao.Desconectar();
            }
        }

        public DataTable Localizar(String _value)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select " +
                "sc.scat_cod, sc.scat_nome, sc.cat_cod, c.cat_nome " +
                "from subcategoria sc inner join categoria c " +
                "on sc.cat_cod = c.cat_cod " +
                "where scat_nome like '%" + _value + "%'", DALconexao.StringConexao);
            sqlDataAdapter.Fill(tabela);
            return tabela;
        }

        public DataTable LocalizarProCategoria(int _categoria)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select " +
                "sc.scat_cod, sc.scat_nome, sc.cat_cod, c.cat_nome " +
                "from subcategoria sc inner join categoria c " +
                 "on sc.cat_cod = c.cat_cod " +
                "where sc.cat_cod = " + _categoria.ToString(), DALconexao.StringConexao);
            sqlDataAdapter.Fill(dt);
            return dt;
        }

        public ModelSubCategoria CarregaModelSubCategoria(int _cod)
        {
            ModelSubCategoria modelo = new ModelSubCategoria();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = DALconexao.Conexao;
            cmd.CommandText = "select * from subcategoria " +
                "where scat_cod = @scodigo";
            cmd.Parameters.AddWithValue("@scodigo", _cod);
            DALconexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.FK_Cat_cod = Convert.ToInt32(registro["cat_cod"]);
                modelo.Scat_nome = Convert.ToString(registro["scat_nome"]);
                modelo.Scat_cod = Convert.ToInt32(registro["scat_cod"]);
            }
            DALconexao.Desconectar();
            return modelo;
        }
    }
}