using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicativoForm
{
    public partial class FormAdicionarCompra : Form
    {
        private BindingList<Class_Fornecedor> Fornecedores { get; set; }
        private Class_Fornecedor Fornecedor { get { return Fornecedores.FirstOrDefault(f => f.Id == (int)comboBoxFornecedor.SelectedValue); } }
        public int idFornecedor { get { return (int)comboBoxFornecedor.SelectedValue; } }

        private BindingList<Class_Produto> Produtos { get; set; }
        private Class_Produto Produto { get { return Produtos.FirstOrDefault(p => p.Id == (int)comboBoxProduto.SelectedValue); } }
        public int idProduto { get { return (int) comboBoxProduto.SelectedValue; } }

        public decimal quantidade { get { return numericUpDownQuantidade.Value; } }
        public decimal desconto { get { return numericUpDownDesconto.Value; } }

        private decimal PrecoUnitario { get { return Produto.precoCompra; } }
        private decimal ValorTotal { get { return PrecoUnitario * quantidade; } }
        private decimal ValorComDesconto { get { return ValorTotal * (1 - (desconto / 100)); } }

        public FormAdicionarCompra(BindingList<Class_Fornecedor> fornecedores, BindingList<Class_Produto> produtos)
        {
            InitializeComponent();
            Fornecedores = fornecedores;
            comboBoxFornecedor.DataSource = Fornecedores;
            comboBoxFornecedor.ValueMember = "Id";
            comboBoxFornecedor.DisplayMember = "NomeEmpresa";

            Produtos = produtos;
            comboBoxProduto.DataSource = Produtos;
            comboBoxProduto.ValueMember = "Id";
            comboBoxProduto.DisplayMember = "Nome";
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void FormAdicionarCompra_Load(object sender, EventArgs e)
        {

        }
        private void AtualizarValores()
        {
            if (Produto != null)
            {
                textBoxPrecoUnitario.Text = PrecoUnitario.ToString("C", CultureInfo.CurrentCulture);
                textBoxValorTotal.Text = ValorTotal.ToString("C", CultureInfo.CurrentCulture);
                textBoxValorTotalDesconto.Text = ValorComDesconto.ToString("C", CultureInfo.CurrentCulture);
            }
        }

        private void numericUpDownQuantidade_ValueChanged(object sender, EventArgs e)
        {
            AtualizarValores();
        }

        private void numericUpDownDesconto_ValueChanged(object sender, EventArgs e)
        {
            AtualizarValores();
        }

        private void comboBoxProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarValores();
        }
    }
}
