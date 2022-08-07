using Model;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DALProduto
    {
        private DALConexao DALConexao;

        public DALProduto(DALConexao _cx)
        {
            DALConexao = _cx;
        }

        public void Incluir(ModelProduto _model)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = DALConexao.Conexao;
            cmd.CommandText = "insert into Produto(pro_nome, pro_descricao, " +
                "pro_foto, pro_valorpago, pro_valorvenda, pro_qtde, umed_cod, " +
                "cat_cod, scat_cod) values (@nome, @descricao, @foto, @valorpago, " +
                "@valorvenda, @qtde, @undmedcod, @catcod, @scatcod); select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@nome", _model.Pro_nome);
            cmd.Parameters.AddWithValue("@descricao", _model.Pro_descricao);
            cmd.Parameters.Add("@foto", System.Data.SqlDbType.Image);
            if (_model.Pro_foto == null)
            {
                cmd.Parameters["@foto"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@foto"].Value = _model.Pro_foto;
            }
            cmd.Parameters.AddWithValue("@valorpago", _model.Pro_valorPago);
            cmd.Parameters.AddWithValue("@valorvenda", _model.Pro_valorVenda);
            cmd.Parameters.AddWithValue("@qtde", _model.Pro_quantidade);
            cmd.Parameters.AddWithValue("@undmedcod", _model.Umed_cod);
            cmd.Parameters.AddWithValue("@catcod", _model.Cat_cod);
            cmd.Parameters.AddWithValue("@scatcod", _model.Scat_cod);

            DALConexao.Conectar();
            _model.Pro_cod = Convert.ToInt32(cmd.ExecuteScalar());
            DALConexao.Desconectar();
        }

        public void Excluir(int _cod)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = DALConexao.Conexao;
            cmd.CommandText = "delete from Produto where pro_cod = @codigo";
            cmd.Parameters.AddWithValue("@codigo", _cod);
            DALConexao.Conectar();
            cmd.ExecuteNonQuery();
            DALConexao.Desconectar();
        }

        public void Alterar(ModelProduto _model)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = DALConexao.Conexao;
            cmd.CommandText = "update Produto set pro_nome = @nome, pro_descricao = @descricao, " +
                "pro_foto = @foto, pro_valorpago = @valorpago, pro_valorvenda = @valorvenda, " +
                "pro_qtde = @qtde, umed_cod = @umedcod, cat_cod = @catcod, scat_cod = @scatcod " +
                "where pro_cod = @codigo";
            cmd.Parameters.AddWithValue("@nome", _model.Pro_nome);
            cmd.Parameters.AddWithValue("@descricao", _model.Pro_descricao);
            cmd.Parameters.Add("@foto", System.Data.SqlDbType.Image);
            if (_model.Pro_foto == null)
            {
                cmd.Parameters["@foto"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@foto"].Value = _model.Pro_foto;
            }
            cmd.Parameters.AddWithValue("@valorpago", _model.Pro_valorPago);
            cmd.Parameters.AddWithValue("@valorvenda", _model.Pro_valorVenda);
            cmd.Parameters.AddWithValue("@qtde", _model.Pro_quantidade);
            cmd.Parameters.AddWithValue("@umedcod", _model.Umed_cod);
            cmd.Parameters.AddWithValue("@catcod", _model.Cat_cod);
            cmd.Parameters.AddWithValue("@scatcod", _model.Scat_cod);
            cmd.Parameters.AddWithValue("@codigo", _model.Pro_cod);
            DALConexao.Conectar();
            cmd.ExecuteNonQuery();
            DALConexao.Desconectar();
        }

        public DataTable Localizar(String _value)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select pro_cod, pro_nome, pro_descricao, " +
                "pro_foto, pro_valorpago, pro_valorvenda, pro_qtde, pro.umed_cod, " +
                "pro.cat_cod, pro.scat_cod, umed_nome, cat_nome, scat_nome from produto pro " +
                "inner join undmedida umd on pro.umed_cod = umd.umed_cod " +
                "inner join categoria cat on pro.cat_cod = cat.cat_cod " +
                "inner join subcategoria sct on pro.scat_cod = sct.scat_cod " +
                "where pro.pro_nome like '%" + _value + "%'", DALConexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModelProduto CarregaModelProduto(int _cod)
        {
            ModelProduto model = new ModelProduto();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = DALConexao.Conexao;
            cmd.CommandText = "select * from Produto where pro_cod = " + _cod.ToString();
            DALConexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                model.Pro_cod = Convert.ToInt32(registro["pro_cod"]);
                model.Pro_nome = Convert.ToString(registro["pro_nome"]);
                model.Pro_descricao = Convert.ToString(registro["pro_descricao"]);
                try
                {
                    model.Pro_foto = (byte[])registro["pro_foto"];
                }
                catch
                {
                }
                model.Pro_valorPago = Convert.ToDouble(registro["pro_valorpago"]);
                model.Pro_valorVenda = Convert.ToDouble(registro["pro_valorvenda"]);
                model.Pro_quantidade = Convert.ToInt32(registro["pro_qtde"]);
                model.Umed_cod = Convert.ToInt32(registro["umed_cod"]);
                model.Cat_cod = Convert.ToInt32(registro["cat_cod"]);
                model.Scat_cod = Convert.ToInt32(registro["scat_cod"]);
            }
            DALConexao.Desconectar();
            return model;
        }
    }
}