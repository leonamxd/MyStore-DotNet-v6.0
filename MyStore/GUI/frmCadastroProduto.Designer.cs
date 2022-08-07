namespace GUI
{
    partial class frmCadastroProduto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnDados = new System.Windows.Forms.Panel();
            this.btRemoveFoto = new System.Windows.Forms.Button();
            this.btLoadFoto = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.cbSubCategoria = new System.Windows.Forms.ComboBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.cbUnidade = new System.Windows.Forms.ComboBox();
            this.txtValorVenda = new System.Windows.Forms.TextBox();
            this.txtValorPago = new System.Windows.Forms.TextBox();
            this.txtQtde = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.btLocalizar = new System.Windows.Forms.Button();
            this.btInserir = new System.Windows.Forms.Button();
            this.pnBotoes = new System.Windows.Forms.Panel();
            this.pnDados.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.pnBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnDados
            // 
            this.pnDados.Controls.Add(this.btRemoveFoto);
            this.pnDados.Controls.Add(this.btLoadFoto);
            this.pnDados.Controls.Add(this.label10);
            this.pnDados.Controls.Add(this.panel1);
            this.pnDados.Controls.Add(this.cbSubCategoria);
            this.pnDados.Controls.Add(this.cbCategoria);
            this.pnDados.Controls.Add(this.cbUnidade);
            this.pnDados.Controls.Add(this.txtValorVenda);
            this.pnDados.Controls.Add(this.txtValorPago);
            this.pnDados.Controls.Add(this.txtQtde);
            this.pnDados.Controls.Add(this.txtDescricao);
            this.pnDados.Controls.Add(this.txtNome);
            this.pnDados.Controls.Add(this.txtCodigo);
            this.pnDados.Controls.Add(this.label9);
            this.pnDados.Controls.Add(this.label8);
            this.pnDados.Controls.Add(this.label7);
            this.pnDados.Controls.Add(this.label6);
            this.pnDados.Controls.Add(this.label5);
            this.pnDados.Controls.Add(this.label4);
            this.pnDados.Controls.Add(this.label3);
            this.pnDados.Controls.Add(this.label2);
            this.pnDados.Controls.Add(this.label1);
            this.pnDados.Location = new System.Drawing.Point(12, 12);
            this.pnDados.Name = "pnDados";
            this.pnDados.Size = new System.Drawing.Size(760, 434);
            this.pnDados.TabIndex = 2;
            // 
            // btRemoveFoto
            // 
            this.btRemoveFoto.Image = global::GUI.Properties.Resources.remove_64px;
            this.btRemoveFoto.Location = new System.Drawing.Point(667, 371);
            this.btRemoveFoto.Name = "btRemoveFoto";
            this.btRemoveFoto.Size = new System.Drawing.Size(90, 58);
            this.btRemoveFoto.TabIndex = 22;
            this.btRemoveFoto.UseVisualStyleBackColor = true;
            this.btRemoveFoto.Click += new System.EventHandler(this.btRemoveFoto_Click);
            // 
            // btLoadFoto
            // 
            this.btLoadFoto.Image = global::GUI.Properties.Resources.load_64px;
            this.btLoadFoto.Location = new System.Drawing.Point(548, 369);
            this.btLoadFoto.Name = "btLoadFoto";
            this.btLoadFoto.Size = new System.Drawing.Size(90, 60);
            this.btLoadFoto.TabIndex = 21;
            this.btLoadFoto.UseVisualStyleBackColor = true;
            this.btLoadFoto.Click += new System.EventHandler(this.btLoadFoto_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(545, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 15);
            this.label10.TabIndex = 20;
            this.label10.Text = "Foto";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pbFoto);
            this.panel1.Location = new System.Drawing.Point(548, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 323);
            this.panel1.TabIndex = 19;
            // 
            // pbFoto
            // 
            this.pbFoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbFoto.Location = new System.Drawing.Point(0, 0);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(207, 321);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 18;
            this.pbFoto.TabStop = false;
            // 
            // cbSubCategoria
            // 
            this.cbSubCategoria.FormattingEnabled = true;
            this.cbSubCategoria.Location = new System.Drawing.Point(372, 187);
            this.cbSubCategoria.Name = "cbSubCategoria";
            this.cbSubCategoria.Size = new System.Drawing.Size(142, 23);
            this.cbSubCategoria.TabIndex = 17;
            // 
            // cbCategoria
            // 
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(372, 114);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(142, 23);
            this.cbCategoria.TabIndex = 16;
            this.cbCategoria.SelectedIndexChanged += new System.EventHandler(this.cbCategoria_SelectedIndexChanged);
            // 
            // cbUnidade
            // 
            this.cbUnidade.FormattingEnabled = true;
            this.cbUnidade.Location = new System.Drawing.Point(372, 42);
            this.cbUnidade.Name = "cbUnidade";
            this.cbUnidade.Size = new System.Drawing.Size(142, 23);
            this.cbUnidade.TabIndex = 15;
            // 
            // txtValorVenda
            // 
            this.txtValorVenda.Location = new System.Drawing.Point(249, 345);
            this.txtValorVenda.Name = "txtValorVenda";
            this.txtValorVenda.Size = new System.Drawing.Size(90, 23);
            this.txtValorVenda.TabIndex = 14;
            this.txtValorVenda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorVenda_KeyPress);
            this.txtValorVenda.Leave += new System.EventHandler(this.txtValorVenda_Leave);
            // 
            // txtValorPago
            // 
            this.txtValorPago.Location = new System.Drawing.Point(126, 345);
            this.txtValorPago.Name = "txtValorPago";
            this.txtValorPago.Size = new System.Drawing.Size(90, 23);
            this.txtValorPago.TabIndex = 13;
            this.txtValorPago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorPago_KeyPress);
            this.txtValorPago.Leave += new System.EventHandler(this.txtValorPago_Leave);
            // 
            // txtQtde
            // 
            this.txtQtde.Location = new System.Drawing.Point(3, 345);
            this.txtQtde.Name = "txtQtde";
            this.txtQtde.Size = new System.Drawing.Size(90, 23);
            this.txtQtde.TabIndex = 12;
            this.txtQtde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQtde_KeyPress);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(3, 187);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(336, 104);
            this.txtDescricao.TabIndex = 11;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(3, 114);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(336, 23);
            this.txtNome.TabIndex = 10;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(3, 44);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(90, 23);
            this.txtCodigo.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(369, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "Sub-Categoria";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(369, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Categoria";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(369, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Unidade de Medida";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(246, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Valor de Venda";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(123, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Valor Pago";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quantidade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descrição";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // btCancelar
            // 
            this.btCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btCancelar.Image = global::GUI.Properties.Resources.cancel_64px;
            this.btCancelar.Location = new System.Drawing.Point(667, 3);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(90, 90);
            this.btCancelar.TabIndex = 5;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btSalvar.Image = global::GUI.Properties.Resources.save_64px;
            this.btSalvar.Location = new System.Drawing.Point(548, 3);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(90, 90);
            this.btSalvar.TabIndex = 4;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btExcluir.Image = global::GUI.Properties.Resources.delete_64px;
            this.btExcluir.Location = new System.Drawing.Point(372, 3);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(90, 90);
            this.btExcluir.TabIndex = 3;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btAlterar.Image = global::GUI.Properties.Resources.update_64px;
            this.btAlterar.Location = new System.Drawing.Point(249, 3);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(90, 90);
            this.btAlterar.TabIndex = 2;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btAlterar.UseVisualStyleBackColor = true;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // btLocalizar
            // 
            this.btLocalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btLocalizar.Image = global::GUI.Properties.Resources.search_64px;
            this.btLocalizar.Location = new System.Drawing.Point(126, 3);
            this.btLocalizar.Name = "btLocalizar";
            this.btLocalizar.Size = new System.Drawing.Size(90, 90);
            this.btLocalizar.TabIndex = 1;
            this.btLocalizar.Text = "Localizar";
            this.btLocalizar.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btLocalizar.UseVisualStyleBackColor = true;
            this.btLocalizar.Click += new System.EventHandler(this.btLocalizar_Click);
            // 
            // btInserir
            // 
            this.btInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btInserir.Image = global::GUI.Properties.Resources.create_64px;
            this.btInserir.Location = new System.Drawing.Point(3, 3);
            this.btInserir.Name = "btInserir";
            this.btInserir.Size = new System.Drawing.Size(90, 90);
            this.btInserir.TabIndex = 0;
            this.btInserir.Text = "Inserir";
            this.btInserir.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btInserir.UseVisualStyleBackColor = true;
            this.btInserir.Click += new System.EventHandler(this.btInserir_Click);
            // 
            // pnBotoes
            // 
            this.pnBotoes.Controls.Add(this.btCancelar);
            this.pnBotoes.Controls.Add(this.btSalvar);
            this.pnBotoes.Controls.Add(this.btExcluir);
            this.pnBotoes.Controls.Add(this.btAlterar);
            this.pnBotoes.Controls.Add(this.btLocalizar);
            this.pnBotoes.Controls.Add(this.btInserir);
            this.pnBotoes.Location = new System.Drawing.Point(12, 449);
            this.pnBotoes.Name = "pnBotoes";
            this.pnBotoes.Size = new System.Drawing.Size(760, 100);
            this.pnBotoes.TabIndex = 3;
            // 
            // frmCadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pnDados);
            this.Controls.Add(this.pnBotoes);
            this.Name = "frmCadastroProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Produto";
            this.Load += new System.EventHandler(this.frmCadastroProduto_Load);
            this.pnDados.ResumeLayout(false);
            this.pnDados.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.pnBotoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected Panel pnDados;
        protected Button btCancelar;
        protected Button btSalvar;
        protected Button btExcluir;
        protected Button btAlterar;
        protected Button btLocalizar;
        protected Button btInserir;
        protected Panel pnBotoes;
        private Button btRemoveFoto;
        private Button btLoadFoto;
        private Label label10;
        private Panel panel1;
        private PictureBox pbFoto;
        private ComboBox cbSubCategoria;
        private ComboBox cbCategoria;
        private ComboBox cbUnidade;
        private TextBox txtValorVenda;
        private TextBox txtValorPago;
        private TextBox txtQtde;
        private TextBox txtDescricao;
        private TextBox txtNome;
        private TextBox txtCodigo;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}