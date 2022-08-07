using DAL;
using Model;
using System.Data;

namespace BLL
{
    public class BLLUnidadeDeMedida
    {
        public DALConexao Conexao { get; set; }

        public BLLUnidadeDeMedida(DALConexao _cx)
        {
            Conexao = _cx;
        }

        public void Incluir(ModelUnidadeDeMedida _model)
        {
            if (_model.Umed_nome.Trim().Length == 0)
            {
                throw new Exception("Nome obrigatório");
            }
            DALUnidadeDeMedida dalObj = new DALUnidadeDeMedida(Conexao);
            dalObj.Incluir(_model);
        }

        public void Alterar(ModelUnidadeDeMedida _model)
        {
            if (_model.Umed_nome.Trim().Length == 0)
            {
                throw new Exception("Nome obrigatório");
            }
            if (_model.Umed_cod <= 0)
            {
                throw new Exception("Código da Unidade de Medida é obrigatório");
            }
            DALUnidadeDeMedida dalObj = new DALUnidadeDeMedida(Conexao);
            dalObj.Alterar(_model);
        }

        public void Excluir(int _cod)
        {
            DALUnidadeDeMedida dalObj = new DALUnidadeDeMedida(Conexao);
            dalObj.Excluir(_cod);
        }

        public DataTable Localizar(String _value)
        {
            DALUnidadeDeMedida dalObj = new DALUnidadeDeMedida(Conexao);
            return dalObj.Localizar(_value);
        }

        public int VerificaUnidadeDeMedida(String _value)
        {
            DALUnidadeDeMedida dalObj = new DALUnidadeDeMedida(Conexao);
            return dalObj.VerificaUnidadeDeMedida(_value);
        }

        public ModelUnidadeDeMedida CarregaModelUnidadeDeMedida(int _cod)
        {
            DALUnidadeDeMedida dalObj = new DALUnidadeDeMedida(Conexao);
            return dalObj.CarregaModelUnidadeDeMedida(_cod);
        }
    }
}