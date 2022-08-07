using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BLL;
using Model;

namespace GUI
{
    public partial class frmCadastroUnidadeDeMedida : Form
    {
        public String operacao;
        public frmCadastroUnidadeDeMedida()
        {
            InitializeComponent();
        }
        public void LimparTela()
        {
            txtCod.Clear();
            txtUnidadeDeMedida.Clear();
        }
        public void alterarBotoes(int _op)
        {
            pnDados.Enabled = false;
            btInserir.Enabled = false;
            btAlterar.Enabled = false;
            btLocalizar.Enabled = false;
            btExcluir.Enabled = false;
            btCancelar.Enabled = false;
            btSalvar.Enabled = false;

            switch (_op)
            {
                case 1:
                    btInserir.Enabled = true;
                    btLocalizar.Enabled = true;
                    break;
                case 2:
                    pnDados.Enabled = true;
                    btSalvar.Enabled = true;
                    btCancelar.Enabled = true;
                    break;
                case 3:
                    btAlterar.Enabled = true;
                    btExcluir.Enabled = true;
                    btCancelar.Enabled = true;

                    break;
                default:
                    break;
            }
        }

        private void frmCadastroUnidadeDeMedida_Load(object sender, EventArgs e)
        {
            alterarBotoes(1);
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            operacao = "inserir";
            alterarBotoes(2);
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            operacao = "alterar";
            alterarBotoes(2);
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo);
                if (d.ToString().Equals("Yes"))
                {
                    DALConexao cx = new DALConexao(DadosDaConexão.StringDeConexao);
                    BLLUnidadeDeMedida bll = new BLLUnidadeDeMedida(cx);
                    bll.Excluir(Convert.ToInt32(txtCod.Text));
                    LimparTela();
                    alterarBotoes(1);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Impossivel excluir o registro. \n O registro está sendo ultilizado em outro local.");
                alterarBotoes(3);
            }
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                //Leitura dos Dados
                ModelUnidadeDeMedida model = new ModelUnidadeDeMedida();
                model.Umed_nome = txtUnidadeDeMedida.Text;

                //Objeto para gravar os dadaos no banco
                DALConexao cx = new DALConexao(DadosDaConexão.StringDeConexao);
                BLLUnidadeDeMedida bll = new BLLUnidadeDeMedida(cx);

                if (operacao.Equals("inserir"))
                {
                    //Cadastrar uma Categoria
                    bll.Incluir(model);
                    MessageBox.Show("Cadastro Efetuado: Código "
                        + model.Umed_cod.ToString());
                }
                else
                {
                    //Alterar uma Categoria
                    model.Umed_cod = Convert.ToInt32(txtCod.Text);
                    bll.Alterar(model);
                    MessageBox.Show("Cadastro Alterado");
                }
                LimparTela();
                alterarBotoes(1);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            LimparTela();
            alterarBotoes(1);
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            frmConsultaUnidadeDeMedida f = new frmConsultaUnidadeDeMedida();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexão.StringDeConexao);
                BLLUnidadeDeMedida bll = new BLLUnidadeDeMedida(cx);

                ModelUnidadeDeMedida model = bll.CarregaModelUnidadeDeMedida(f.codigo);
                txtCod.Text = model.Umed_cod.ToString();
                txtUnidadeDeMedida.Text = model.Umed_nome;
                alterarBotoes(3);
            }
            else
            {
                LimparTela();
                alterarBotoes(1);
            }
            f.Dispose();
        }

        private void txtUnidadeDeMedida_Leave(object sender, EventArgs e)
        {
            if (operacao.Equals("inserir"))
            {
                int aux = 0;
                DALConexao cx = new DALConexao(DadosDaConexão.StringDeConexao);
                BLLUnidadeDeMedida bll = new BLLUnidadeDeMedida(cx);

                aux = bll.VerificaUnidadeDeMedida(txtUnidadeDeMedida.Text);

                if (aux > 0)
                {
                    DialogResult d = MessageBox.Show("Valor de registro ja existente!\nDeseja alterar o registro?", "Aviso", MessageBoxButtons.YesNo);
                    if (d.ToString().Equals("Yes"))
                    {
                        operacao = "alterar";

                        ModelUnidadeDeMedida model = bll.CarregaModelUnidadeDeMedida(aux);
                        txtCod.Text = model.Umed_cod.ToString();
                        txtUnidadeDeMedida.Text = model.Umed_nome;
                    }
                    else
                    {
                        LimparTela();
                        alterarBotoes(1);
                    }
                }
            }
        }
    }
}
