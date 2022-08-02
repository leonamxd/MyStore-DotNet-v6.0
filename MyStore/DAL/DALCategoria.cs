using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL
{
    public class DALCategoria
    {
        private DALConexao DALConexao;

        public DALCategoria(DALConexao _cx)
        {
            DALConexao = _cx;
        }

        public void Incluir(ModelCategoria _model)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = DALConexao.Conexao;
            cmd.CommandText = "insert into categoria(cat_nome)" +
                " values(@nome) select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@nome", _model.Cat_nome);
            DALConexao.Conectar();
            _model.Cat_cod = Convert.ToInt32(cmd.ExecuteScalar());
            DALConexao.Desconectar();
        }
        public void Alterar(ModelCategoria _model)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = DALConexao.Conexao;
            cmd.CommandText = "update categoria set cat_nome = " +
                "@nome where cat_cod = @codigo";
            cmd.Parameters.AddWithValue("@nome", _model.Cat_nome);
            cmd.Parameters.AddWithValue("@codigo", _model.Cat_cod);
            DALConexao.Conectar();
            cmd.ExecuteNonQuery();
            DALConexao.Desconectar();
        }
        public void Excluir(int _cod)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = DALConexao.Conexao;
            cmd.CommandText = "delete from categoria where cat_cod = @codigo";
            cmd.Parameters.AddWithValue("@codigo", _cod);
            DALConexao.Conectar();
            cmd.ExecuteNonQuery();
            DALConexao.Desconectar();
        }
        public DataTable Localizar(String _value)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from categoria " +
                "where cat_nome like '%" + _value + "%'",
                DALConexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        public ModelCategoria CarregaModelCategoria(int _cod)
        {
            ModelCategoria modelo = new ModelCategoria();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = DALConexao.Conexao;
            cmd.CommandText = "select * from categoria " +
                "where cat_cod = @codigo";
            cmd.Parameters.AddWithValue("@codigo", _cod);
            DALConexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.Cat_cod = Convert.ToInt32(registro["cat_cod"]);
                modelo.Cat_nome = Convert.ToString(registro["cat_nome"]);
            }
            DALConexao.Desconectar();
            return modelo;
        }
    }
}
