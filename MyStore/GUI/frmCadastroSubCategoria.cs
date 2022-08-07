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
    public partial class frmCadastroSubCategoria : Form
    {
        public String operacao;
        public frmCadastroSubCategoria()
        {
            InitializeComponent();
        }
        public void LimpaTela()
        {
            txtScatNome.Clear();
            txtScatCod.Clear();
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

        private void frmCadastroSubCategoria_Load(object sender, EventArgs e)
        {
            alterarBotoes(1);
            DALConexao cx = new DALConexao(DadosDaConexão.StringDeConexao);
            BLLCategoria bll = new BLLCategoria(cx);
            cbCatCod.DataSource = bll.Localizar("");
            cbCatCod.DisplayMember = "cat_nome";
            cbCatCod.ValueMember = "cat_cod";
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            alterarBotoes(2);
            operacao = "inserir";
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            alterarBotoes(1);
            LimpaTela();
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            alterarBotoes(2);
            operacao = "alterar";
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                //Leitura dos Dados
                ModelSubCategoria model = new ModelSubCategoria();
                model.Scat_nome = txtScatNome.Text;
                model.FK_Cat_cod = Convert.ToInt32(cbCatCod.SelectedValue);

                //Objeto para gravar os dadaos no banco
                DALConexao cx = new DALConexao(DadosDaConexão.StringDeConexao);
                BLLSubCategoria bll = new BLLSubCategoria(cx);

                if (operacao.Equals("inserir"))
                {
                    //Cadastrar uma Categoria
                    bll.Incluir(model);
                    MessageBox.Show("Cadastro Efetuado: Código "
                        + model.Scat_cod.ToString());
                }
                else
                {
                    //Alterar uma Categoria
                    model.Scat_cod = Convert.ToInt32(txtScatCod.Text);
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

        private void btExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja excluir o registro?",
                    "Aviso", MessageBoxButtons.YesNo);
                if (d.ToString().Equals("Yes"))
                {
                    DALConexao cx = new DALConexao(DadosDaConexão.StringDeConexao);
                    BLLSubCategoria bll = new BLLSubCategoria(cx);
                    bll.Excluir(Convert.ToInt32(txtScatCod.Text));
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
            frmConsultaSubCategoria f = new frmConsultaSubCategoria();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexão.StringDeConexao);
                BLLSubCategoria bll = new BLLSubCategoria(cx);

                ModelSubCategoria modelo = bll.CarregaModelSubCategoria(f.codigo);
                txtScatCod.Text = modelo.Scat_cod.ToString();
                txtScatNome.Text = modelo.Scat_nome;
                cbCatCod.SelectedValue = modelo.FK_Cat_cod;
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
