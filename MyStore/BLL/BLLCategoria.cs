using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace BLL
{
    public class BLLCategoria
    {
        public DALConexao Conexao { get; set; }

        public BLLCategoria(DALConexao _cx)
        {
            Conexao = _cx;
        }

        public void Incluir(ModelCategoria _model)
        {
            if (_model.Cat_nome.Trim().Length == 0)
            {
                throw new Exception("Nome Obrigatorio");
            }
            DALCategoria dalObj = new DALCategoria(Conexao);
            dalObj.Incluir(_model);
        }

        public void Alterar(ModelCategoria _model)
        {
            if (_model.Cat_cod <= 0)
            {
                throw new Exception("Codigo Obrigatório");
            }
            if (_model.Cat_nome.Trim().Length == 0)
            {
                throw new Exception("Nome Obrigatório");
            }
            DALCategoria dalObj = new DALCategoria(Conexao);
            dalObj.Alterar(_model);
        }

        public void Excluir(int _cod)
        {
            DALCategoria dalObj = new DALCategoria(Conexao);
            dalObj.Excluir(_cod);
        }

        public DataTable Localizar(String _value)
        {
            DALCategoria dalObj = new DALCategoria(Conexao);
            return dalObj.Localizar(_value);
        }

        public ModelCategoria CarregaModeloCategoria(int _cod)
        {
            DALCategoria dalObj = new DALCategoria(Conexao);
            return dalObj.CarregaModelCategoria(_cod);
        }
    }
}
