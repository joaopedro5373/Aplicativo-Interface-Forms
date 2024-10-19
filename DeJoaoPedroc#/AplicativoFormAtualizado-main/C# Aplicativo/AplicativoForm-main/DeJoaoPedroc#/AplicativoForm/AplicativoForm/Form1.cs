using System.ComponentModel;
using System.Runtime.Intrinsics.X86;
using static System.Net.WebRequestMethods;

namespace AplicativoForm
{
    public partial class Form1 : Form
    {
        public BindingList<Class_Produto> produtos { get; set; }
        public BindingList<Class_Cliente> clientes { get; set; }
        public BindingList<Class_Fornecedor> fornecedores { get; set; }
        public BindingList<Class_Compra> compras { get; set; }
        public BindingList<Class_Venda> vendas { get; set; }

        public Form1()
        {
            InitializeComponent();
            produtos = new BindingList<Class_Produto>();
            clientes = new BindingList<Class_Cliente>();
            fornecedores = new BindingList<Class_Fornecedor>();
            compras = new BindingList<Class_Compra>();
            vendas = new BindingList<Class_Venda>();
            this.dataGridView1.DataSource = produtos;
        }


        private void Form1_Load(object sender, EventArgs e) { }

        private void buttonAdicionarProduto_Click(object sender, EventArgs e)
        {
            FormCriarProduto fcp = new FormCriarProduto();
            var resultado = fcp.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                Class_Produto produto = new Class_Produto();
                if (produtos.Count == 0) produto.Id = 1;
                else produto.Id = produtos.Max(X => X.Id) + 1;
                produto.nome = fcp.nome;
                produto.nomeFabricante = fcp.nomeFabricante;
                produto.precoCompra = (decimal)fcp.precoCompra;
                produto.precoVenda = (decimal)fcp.precoVenda;
                produtos.Add(produto);
            }
        }

        private void buttonRemoverProduto_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                produtos.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
        }

        private void buttonViewProdutos_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = produtos;
        }

        private void buttonViewClientes_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = clientes;
        }

        private void buttonViewFornecedores_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = fornecedores;
        }

        private void buttonViewCompras_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = compras;
        }

        private void buttonViewVendas_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = vendas;
        }

        private void buttonAdicionarCliente_Click(object sender, EventArgs e)
        {
            FormAdicionarCliente fac = new FormAdicionarCliente();
            var resultado = fac.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                Class_Cliente cliente = new Class_Cliente();
                if (clientes.Count == 0) cliente.Id = 1;
                else cliente.Id = clientes.Max(X => X.Id) + 1;
                cliente.nome = fac.nome;
                cliente.telefone = fac.telefone;
                cliente.email = fac.email;
                cliente.Endereco = fac.Endereco;
                clientes.Add(cliente);
            }

        }

        private void buttonRemoverCliente_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                clientes.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
        }

        private void buttonAdicionarFornecedor_Click(object sender, EventArgs e)
        {
            FormAdicionarFornecedor faf = new FormAdicionarFornecedor();
            var resultado = faf.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                Class_Fornecedor fornecedor = new Class_Fornecedor();
                if (fornecedores.Count == 0) fornecedor.Id = 1;
                else fornecedor.Id = fornecedores.Max(X => X.Id) + 1;
                fornecedor.nome = faf.nome;
                fornecedor.telefone = faf.telefone;
                fornecedor.email = faf.email;
                fornecedor.endereco = faf.endereco;
                fornecedores.Add(fornecedor);
            }
        }

        private void buttonRemoverFornecedor_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                fornecedores.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
        }

        private void buttonAdicionarCompra_Click(object sender, EventArgs e)
        {
            if (fornecedores.Count == 0)
            {
                MessageBox.Show("Você precisa cadastrar fornecedores antes de efetuar uma compra.");
                return;
            }
            if (produtos.Count == 0)
            {
                MessageBox.Show("Você precisa cadastrar produtos antes de efetuar uma compra.");
                return;
            }

            FormAdicionarCompra faa = new FormAdicionarCompra(fornecedores, produtos);
            var resultado = faa.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                Class_Compra compra = new Class_Compra();
                if (compras.Count == 0) compra.Id = 1;
                else compra.Id = compras.Max(X => X.Id) + 1;
                compra.idProduto = faa.idProduto;
                compra.idFornecedor = faa.idFornecedor;
                compra.quantidade = (int) faa.quantidade;
                compra.desconto = faa.desconto;
                compra.DataCompra = DateTime.Now;
                compras.Add(compra);
            }
        }

        private void buttonRemoverCompra_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                compras.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
        }

        private void buttonAdicionarVenda_Click(object sender, EventArgs e)
        {
            FormAdicionarVenda fav = new FormAdicionarVenda();
            var resultado = fav.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                Class_Venda venda = new Class_Venda();
                if (vendas.Count == 0) venda.Id = 1;
                else venda.Id = vendas.Max(X => X.Id) + 1;
                venda.idProduto = fav.idProduto;
                venda.idCliente = fav.idCliente;
                venda.quantidade = fav.quantidade;
                venda.desconto = fav.desconto;
                vendas.Add(venda);
            }
        }

        private void buttonRemovervenda_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                vendas.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
        }
    }
}
