using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using DAL;
using BLL;

namespace GUI
{
    public partial class frmCadastroCategoria : Form
    {
        public String operacao;
        public frmCadastroCategoria()
        {
            InitializeComponent();
        }
        public void LimpaTela()
        {
            txtCodigo.Clear();
            txtNome.Clear();
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

        private void frmCadastroCategoria_Load(object sender, EventArgs e)
        {
            alterarBotoes(1);
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            operacao = "inserir";
            alterarBotoes(2);
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            LimpaTela();
            alterarBotoes(1);
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                //Leitura dos Dados
                ModelCategoria model = new ModelCategoria();
                model.Cat_nome = txtNome.Text;

                //Objeto para gravar os dadaos no banco
                DALConexao cx = new DALConexao(DadosDaConexão.StringDeConexao);
                BLLCategoria bll = new BLLCategoria(cx);

                if (operacao.Equals("inserir"))
                {
                    //Cadastrar uma Categoria
                    bll.Incluir(model);
                    MessageBox.Show("Cadastro Efetuado: Código "
                        + model.Cat_cod.ToString());
                }
                else
                {
                    //Alterar uma Categoria
                    model.Cat_cod = Convert.ToInt32(txtCodigo.Text);
                    bll.Alterar(model);
                    MessageBox.Show("Cadastro Alterado");
                }
                LimpaTela();
                alterarBotoes(1);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
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
                DialogResult d = MessageBox.Show("Deseja excluir o registro?",
                    "Aviso", MessageBoxButtons.YesNo);
                if (d.ToString().Equals("Yes"))
                {
                    DALConexao cx = new DALConexao(DadosDaConexão.StringDeConexao);
                    BLLCategoria bll = new BLLCategoria(cx);
                    bll.Excluir(Convert.ToInt32(txtCodigo.Text));
                    LimpaTela();
                    alterarBotoes(1);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Impossivel excluir o registro." +
                    "\n O registro está sendo ultilizado em outro local.");
                alterarBotoes(3);
            }
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            frmConsultaCategoria f = new frmConsultaCategoria();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexão.StringDeConexao);
                BLLCategoria bll = new BLLCategoria(cx);

                ModelCategoria model = bll.CarregaModeloCategoria(f.codigo);
                txtCodigo.Text = model.Cat_cod.ToString();
                txtNome.Text = model.Cat_nome;
                alterarBotoes(3);
            }
            else
            {
                LimpaTela();
                alterarBotoes(1);
            }
            f.Dispose();
        }
    }
}
