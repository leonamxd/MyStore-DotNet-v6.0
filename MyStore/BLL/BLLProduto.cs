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
    public class BLLProduto
    {
        public DALConexao Conexao { get; set; }

        public BLLProduto(DALConexao _cx)
        {
            Conexao = _cx;
        }

        public void Incluir(ModelProduto _model)
        {
            if (_model.Pro_nome.Trim().Length == 0)
            {
                throw new Exception("Nome Obrigatório");
            }
            if (_model.Pro_descricao.Trim().Length == 0)
            {
                throw new Exception("Descrição Obrigatória");
            }
            if (_model.Pro_valorVenda <= 0)
            {
                throw new Exception("Valor Obrigatório");
            }
            if (_model.Pro_quantidade < 0)
            {
                throw new Exception("Informar quantidade maior ou igual a zero");
            }
            if (_model.Umed_cod <= 0)
            {
                throw new Exception("O codigo é Obrigatório");
            }
            if (_model.Cat_cod <= 0)
            {
                throw new Exception("O codigo é Obrigatório");
            }
            if (_model.Scat_cod <= 0)
            {
                throw new Exception("O codigo é Obrigatório");
            }
            DALProduto dalObj = new DALProduto(Conexao);
            dalObj.Incluir(_model);
        }

        public void Alterar(ModelProduto _model)
        {
            if (_model.Pro_cod <= 0)
            {
                throw new Exception("Codigo Obrigatório");
            }
            if (_model.Pro_nome.Trim().Length == 0)
            {
                throw new Exception("Nome Obrigatório");
            }
            if (_model.Pro_descricao.Trim().Length == 0)
            {
                throw new Exception("Descrição Obrigatória");
            }
            if (_model.Pro_valorVenda <= 0)
            {
                throw new Exception("Valor Obrigatório");
            }
            if (_model.Pro_quantidade < 0)
            {
                throw new Exception("Informar quantidade maior ou igual a zero");
            }
            if (_model.Umed_cod <= 0)
            {
                throw new Exception("O codigo é Obrigatório");
            }
            if (_model.Cat_cod <= 0)
            {
                throw new Exception("O codigo é Obrigatório");
            }
            if (_model.Scat_cod <= 0)
            {
                throw new Exception("O codigo é Obrigatório");
            }
            DALProduto dalObj = new DALProduto(Conexao);
            dalObj.Alterar(_model);
        }

        public void Excluir(int _cod)
        {
            DALProduto dalObj = new DALProduto(Conexao);
            dalObj.Excluir(_cod);
        }

        public DataTable Localizar(String _value)
        {
            DALProduto dalObj = new DALProduto(Conexao);
            return dalObj.Localizar(_value);
        }

        public ModelProduto CarregaModeloProduto(int _cod)
        {
            DALProduto dalObj = new DALProduto(Conexao);
            return dalObj.CarregaModelProduto(_cod);
        }
    }
}
