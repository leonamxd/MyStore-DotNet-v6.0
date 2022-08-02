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
    public class BLLSubCategoria
    {
        public DALConexao Conexao { get; set; }
        public BLLSubCategoria(DALConexao _cx)
        {
            Conexao = _cx;
        }

        public void Incluir(ModelSubCategoria _model)
        {
            if (_model.Scat_nome.Trim().Length == 0)
            {
                throw new Exception("Nome obrigatório");
            }
            if (_model.FK_Cat_cod <= 0)
            {
                throw new Exception("Código da Categoria é obrigatório");
            }
            DALSubCategoria dalObj = new DALSubCategoria(Conexao);
            dalObj.Incluir(_model);
        }

        public void Alterar(ModelSubCategoria _model)
        {
            if (_model.Scat_nome.Trim().Length == 0)
            {
                throw new Exception("Nome obrigatório");
            }
            if (_model.FK_Cat_cod <= 0)
            {
                throw new Exception("Código da Categoria é obrigatório");
            }
            if (_model.Scat_cod <= 0)
            {
                throw new Exception("Código da SubCategoria é obrigatório");
            }
            DALSubCategoria dalObj = new DALSubCategoria(Conexao);
            dalObj.Alterar(_model);
        }

        public void Excluir(int _codigo)
        {
            DALSubCategoria dalObj = new DALSubCategoria(Conexao);
            dalObj.Excluir(_codigo);
        }

        public DataTable Localizar(String _value)
        {
            DALSubCategoria dalObj = new DALSubCategoria(Conexao);
            return dalObj.Localizar(_value);
        }

        public DataTable LocalizarPorCategoria(int _categoria)
        {
            DALSubCategoria dalObj = new DALSubCategoria(Conexao);
            return dalObj.LocalizarProCategoria(_categoria);
        }

        public ModelSubCategoria CarregaModelSubCategoria(int _codigo)
        {
            DALSubCategoria dalObj = new DALSubCategoria(Conexao);
            return dalObj.CarregaModelSubCategoria(_codigo);
        }
    }
}
