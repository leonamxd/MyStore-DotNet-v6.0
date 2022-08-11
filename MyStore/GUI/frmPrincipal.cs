using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroCategoria frmCadastroCategoria = new frmCadastroCategoria();
            frmCadastroCategoria.ShowDialog();
            frmCadastroCategoria.Dispose();
        }

        private void categoriaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaCategoria frmConsultaCategoria = new frmConsultaCategoria();
            frmConsultaCategoria.ShowDialog();
            frmConsultaCategoria.Dispose();
        }

        private void subCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroSubCategoria frmCadastroSubCategoria = new frmCadastroSubCategoria();
            frmCadastroSubCategoria.ShowDialog();
            frmCadastroSubCategoria.Dispose();
        }

        private void subCategoriaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaSubCategoria frmConsultaSubCategoria = new frmConsultaSubCategoria();
            frmConsultaSubCategoria.ShowDialog();
            frmConsultaSubCategoria.Dispose();
        }

        private void unidadeDeMedidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroUnidadeDeMedida frmCadastroUnidadeDeMedida = new frmCadastroUnidadeDeMedida();
            frmCadastroUnidadeDeMedida.ShowDialog();
            frmCadastroUnidadeDeMedida.Dispose();
        }
        private void unidadeDeMedidaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaUnidadeDeMedida frmConsultaUnidadeDeMedida = new frmConsultaUnidadeDeMedida();
            frmConsultaUnidadeDeMedida.ShowDialog();
            frmConsultaUnidadeDeMedida.Dispose();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroProduto frmCadastroProduto = new frmCadastroProduto();
            frmCadastroProduto.ShowDialog();
            frmCadastroProduto.Dispose();
        }

        private void configuraçãoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConfiguracaoDados frmConfiguracaoDados = new frmConfiguracaoDados();
            frmConfiguracaoDados.ShowDialog();
            frmConfiguracaoDados.Dispose();
        }
        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
        }

        private void explorerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer");
        }

        private void notpadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad");
        }
    }
}
