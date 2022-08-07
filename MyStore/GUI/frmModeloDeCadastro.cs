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
    public partial class frmModeloDeCadastro : Form
    {
        public String operacao;
        public frmModeloDeCadastro()
        {
            InitializeComponent();
        }

        public void alteraBotoes(int _op)
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
    }
}
