using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;
using Model;

namespace GUI
{
    public partial class frmCadastroProduto : Form
    {
        public String foto = "";
        public String operacao;
        public frmCadastroProduto()
        {
            InitializeComponent();
        }

        private void LimparTela()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtDescricao.Clear();
            txtValorPago.Clear();
            txtValorVenda.Clear();
            txtQtde.Clear();
            foto = "";
            pbFoto.Image = null;
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

        private void frmCadastroProduto_Load(object sender, EventArgs e)
        {
            alterarBotoes(1);
            DALConexao cx = new DALConexao(DadosDaConexão.StringDeConexao);

            //Combobox Categoria
            BLLCategoria bllCategoria = new BLLCategoria(cx);
            cbCategoria.DataSource = bllCategoria.Localizar("");
            cbCategoria.DisplayMember = "cat_nome";
            cbCategoria.ValueMember = "cat_cod";

            //Combobox SubCategoria
            BLLSubCategoria bLLSubCategoria = new BLLSubCategoria(cx);
            cbSubCategoria.DataSource = bLLSubCategoria.LocalizarPorCategoria((int)cbCategoria.SelectedValue);
            cbSubCategoria.DisplayMember = "scat_nome";
            cbSubCategoria.ValueMember = "scat_cod";

            //Combobox Unidade de Medida
            BLLUnidadeDeMedida bLLUnidadeDeMedida = new BLLUnidadeDeMedida(cx);
            cbUnidade.DataSource = bLLUnidadeDeMedida.Localizar("");
            cbUnidade.DisplayMember = "umed_nome";
            cbUnidade.ValueMember = "umed_cod";
        }


        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexão.StringDeConexao);

            try
            {
                cbSubCategoria.Text = "";

                BLLSubCategoria bLLSubCategoria = new BLLSubCategoria(cx);
                cbSubCategoria.DataSource = bLLSubCategoria.LocalizarPorCategoria((int)cbCategoria.SelectedValue);
                cbSubCategoria.DisplayMember = "scat_nome";
                cbSubCategoria.ValueMember = "scat_cod";
            }
            catch
            {
                //MessageBox.Show("Cadastre uma categoria");
            }
        }

        private void btLoadFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.ShowDialog();
            if (!string.IsNullOrEmpty(od.FileName))
            {
                foto = od.FileName;
                pbFoto.Load(foto);
            }
        }

        private void btRemoveFoto_Click(object sender, EventArgs e)
        {
            foto = "";
            pbFoto.Image = null;
        }
        private void btInserir_Click(object sender, EventArgs e)
        {
            operacao = "inserir";
            alterarBotoes(2);
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            alterarBotoes(1);
            LimparTela();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                //Leitura dos dados
                ModelProduto model = new ModelProduto();
                model.Pro_nome = txtNome.Text;

                model.Pro_descricao = txtDescricao.Text;
                model.Pro_valorPago = Convert.ToDouble(txtValorPago.Text);
                model.Pro_valorVenda = Convert.ToDouble(txtValorVenda.Text);
                model.Pro_quantidade = Convert.ToInt32(txtQtde.Text);
                model.Umed_cod = Convert.ToInt32(cbUnidade.SelectedValue);
                model.Cat_cod = Convert.ToInt32(cbCategoria.SelectedValue);
                model.Scat_cod = Convert.ToInt32(cbSubCategoria.SelectedValue);

                //Obj para gravar os dados no branco
                DALConexao cx = new DALConexao(DadosDaConexão.StringDeConexao);
                BLLProduto bll = new BLLProduto(cx);

                if (operacao.Equals("inserir"))
                {
                    //Cadastrar um Produto
                    model.CarregaImagem(foto);
                    bll.Incluir(model);
                    MessageBox.Show("Cadastro efetuado: Código " + model.Pro_cod.ToString());
                }
                else
                {
                    //Alterar um Produto
                    model.Pro_cod = Convert.ToInt32(txtCodigo.Text);

                    if (foto.Equals("Foto Original"))
                    {
                        ModelProduto mt = bll.CarregaModeloProduto(model.Pro_cod);
                        model.Pro_foto = mt.Pro_foto;
                    }
                    else
                    {
                        model.CarregaImagem(foto);
                    }
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

        private void btExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja excluir o registro?",
                    "Aviso", MessageBoxButtons.YesNo);
                if (d.ToString().Equals("Yes"))
                {
                    DALConexao cx = new DALConexao(DadosDaConexão.StringDeConexao);
                    BLLProduto bll = new BLLProduto(cx);
                    bll.Excluir(Convert.ToInt32(txtCodigo.Text));
                    LimparTela();
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
            frmConsultaProduto f = new frmConsultaProduto();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexão.StringDeConexao);
                BLLProduto bll = new BLLProduto(cx);
                ModelProduto model = bll.CarregaModeloProduto(f.codigo);

                txtCodigo.Text = model.Pro_cod.ToString();
                txtNome.Text = model.Pro_nome;
                txtDescricao.Text = model.Pro_descricao;
                txtValorPago.Text = model.Pro_valorPago.ToString();
                txtValorVenda.Text = model.Pro_valorVenda.ToString();
                txtQtde.Text = model.Pro_quantidade.ToString();
                cbUnidade.SelectedValue = model.Umed_cod;
                cbCategoria.SelectedValue = model.Cat_cod;
                cbSubCategoria.SelectedValue = model.Scat_cod;

                try
                {
                    if (model.Pro_foto != null)
                    {
                        MemoryStream ms = new MemoryStream(model.Pro_foto);
                        pbFoto.Image = Image.FromStream(ms);
                        foto = "Foto Original";
                    }
                }
                catch
                {
                }

                alterarBotoes(3);
            }
            else
            {
                LimparTela();
                alterarBotoes(1);
            }

            f.Dispose();
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            operacao = "alterar";
            alterarBotoes(2);
        }


        /*
         *
         *
         *
         * VALIDAÇÕES \/ \/ \/ \/ \/ \/
         *
         *
         *
         */

        private void txtQtde_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtValorPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8
                                         && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                if (!txtValorPago.Text.Contains(","))
                {
                    e.KeyChar = ',';
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void txtValorVenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8
                                         && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                if (!txtValorVenda.Text.Contains(","))
                {
                    e.KeyChar = ',';
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void txtValorPago_Leave(object sender, EventArgs e)
        {
            if (txtValorPago.Text.Contains(",") == false)
            {
                txtValorPago.Text += ",00";
            }
            else
            {
                if (txtValorPago.Text.IndexOf(",") == txtValorPago.Text.Length - 1)
                {
                    txtValorPago.Text += "00";
                }
            }

            try
            {
                Double d = Convert.ToDouble(txtValorPago.Text);
            }
            catch
            {
                txtValorPago.Text = "0,00";
            }
        }

        private void txtValorVenda_Leave(object sender, EventArgs e)
        {
            if (txtValorVenda.Text.Contains(",") == false)
            {
                txtValorVenda.Text += ",00";
            }
            else
            {
                if (txtValorVenda.Text.IndexOf(",") == txtValorVenda.Text.Length - 1)
                {
                    txtValorVenda.Text += "00";
                }
            }

            try
            {
                Double d = Convert.ToDouble(txtValorVenda.Text);
            }
            catch
            {
                txtValorVenda.Text = "0,00";
            }
        }

    }
}
