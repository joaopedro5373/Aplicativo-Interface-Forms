namespace AplicativoForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonViewProdutos = new Button();
            buttonRemoverProduto = new Button();
            buttonAdicionarProduto = new Button();
            dataGridView1 = new DataGridView();
            buttonViewClientes = new Button();
            buttonAdicionarCliente = new Button();
            buttonRemoverCliente = new Button();
            buttonViewFornecedores = new Button();
            buttonViewCompras = new Button();
            buttonViewVendas = new Button();
            buttonAdicionarFornecedor = new Button();
            buttonRemoverFornecedor = new Button();
            buttonAdicionarCompra = new Button();
            buttonRemoverCompra = new Button();
            buttonAdicionarVenda = new Button();
            buttonRemovervenda = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // buttonViewProdutos
            // 
            buttonViewProdutos.BackColor = Color.FromArgb(255, 192, 192);
            buttonViewProdutos.Cursor = Cursors.Hand;
            buttonViewProdutos.FlatStyle = FlatStyle.Popup;
            buttonViewProdutos.ForeColor = Color.FromArgb(64, 0, 0);
            buttonViewProdutos.Image = Properties.Resources.produto;
            buttonViewProdutos.ImageAlign = ContentAlignment.MiddleLeft;
            buttonViewProdutos.Location = new Point(21, 6);
            buttonViewProdutos.Name = "buttonViewProdutos";
            buttonViewProdutos.Size = new Size(164, 37);
            buttonViewProdutos.TabIndex = 0;
            buttonViewProdutos.Text = "Produtos";
            buttonViewProdutos.UseVisualStyleBackColor = false;
            buttonViewProdutos.Click += buttonViewProdutos_Click;
            // 
            // buttonRemoverProduto
            // 
            buttonRemoverProduto.BackColor = Color.FromArgb(255, 192, 192);
            buttonRemoverProduto.FlatStyle = FlatStyle.Popup;
            buttonRemoverProduto.ForeColor = Color.FromArgb(64, 0, 0);
            buttonRemoverProduto.Location = new Point(21, 78);
            buttonRemoverProduto.Name = "buttonRemoverProduto";
            buttonRemoverProduto.Size = new Size(164, 23);
            buttonRemoverProduto.TabIndex = 2;
            buttonRemoverProduto.Text = "Remover Produto";
            buttonRemoverProduto.UseVisualStyleBackColor = false;
            buttonRemoverProduto.Click += buttonRemoverProduto_Click;
            // 
            // buttonAdicionarProduto
            // 
            buttonAdicionarProduto.BackColor = Color.FromArgb(255, 192, 192);
            buttonAdicionarProduto.FlatStyle = FlatStyle.Popup;
            buttonAdicionarProduto.ForeColor = Color.FromArgb(64, 0, 0);
            buttonAdicionarProduto.Location = new Point(21, 49);
            buttonAdicionarProduto.Name = "buttonAdicionarProduto";
            buttonAdicionarProduto.Size = new Size(164, 23);
            buttonAdicionarProduto.TabIndex = 3;
            buttonAdicionarProduto.Text = "Adicionar Produto";
            buttonAdicionarProduto.UseVisualStyleBackColor = false;
            buttonAdicionarProduto.Click += buttonAdicionarProduto_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 121);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridView1.Size = new Size(853, 317);
            dataGridView1.TabIndex = 4;
            // 
            // buttonViewClientes
            // 
            buttonViewClientes.BackColor = Color.FromArgb(192, 255, 255);
            buttonViewClientes.Cursor = Cursors.Hand;
            buttonViewClientes.FlatStyle = FlatStyle.Popup;
            buttonViewClientes.ForeColor = Color.FromArgb(0, 64, 64);
            buttonViewClientes.Image = Properties.Resources.cliente;
            buttonViewClientes.ImageAlign = ContentAlignment.MiddleLeft;
            buttonViewClientes.Location = new Point(191, 6);
            buttonViewClientes.Name = "buttonViewClientes";
            buttonViewClientes.Size = new Size(164, 37);
            buttonViewClientes.TabIndex = 5;
            buttonViewClientes.Text = "Clientes";
            buttonViewClientes.UseVisualStyleBackColor = false;
            buttonViewClientes.Click += buttonViewClientes_Click;
            // 
            // buttonAdicionarCliente
            // 
            buttonAdicionarCliente.BackColor = Color.FromArgb(192, 255, 255);
            buttonAdicionarCliente.FlatStyle = FlatStyle.Popup;
            buttonAdicionarCliente.ForeColor = Color.FromArgb(0, 64, 64);
            buttonAdicionarCliente.Location = new Point(191, 49);
            buttonAdicionarCliente.Name = "buttonAdicionarCliente";
            buttonAdicionarCliente.Size = new Size(164, 23);
            buttonAdicionarCliente.TabIndex = 6;
            buttonAdicionarCliente.Text = "Adicionar Cliente";
            buttonAdicionarCliente.UseVisualStyleBackColor = false;
            buttonAdicionarCliente.Click += buttonAdicionarCliente_Click;
            // 
            // buttonRemoverCliente
            // 
            buttonRemoverCliente.BackColor = Color.FromArgb(192, 255, 255);
            buttonRemoverCliente.FlatStyle = FlatStyle.Popup;
            buttonRemoverCliente.ForeColor = Color.FromArgb(0, 64, 64);
            buttonRemoverCliente.Location = new Point(191, 78);
            buttonRemoverCliente.Name = "buttonRemoverCliente";
            buttonRemoverCliente.Size = new Size(164, 23);
            buttonRemoverCliente.TabIndex = 7;
            buttonRemoverCliente.Text = "Remover Cliente";
            buttonRemoverCliente.UseVisualStyleBackColor = false;
            buttonRemoverCliente.Click += buttonRemoverCliente_Click;
            // 
            // buttonViewFornecedores
            // 
            buttonViewFornecedores.BackColor = Color.FromArgb(192, 192, 255);
            buttonViewFornecedores.Cursor = Cursors.Hand;
            buttonViewFornecedores.FlatStyle = FlatStyle.Popup;
            buttonViewFornecedores.ForeColor = Color.FromArgb(0, 0, 64);
            buttonViewFornecedores.Image = Properties.Resources.fornecedor;
            buttonViewFornecedores.ImageAlign = ContentAlignment.MiddleLeft;
            buttonViewFornecedores.Location = new Point(361, 6);
            buttonViewFornecedores.Name = "buttonViewFornecedores";
            buttonViewFornecedores.Size = new Size(164, 37);
            buttonViewFornecedores.TabIndex = 8;
            buttonViewFornecedores.Text = "Fornecedores";
            buttonViewFornecedores.UseVisualStyleBackColor = false;
            buttonViewFornecedores.Click += buttonViewFornecedores_Click;
            // 
            // buttonViewCompras
            // 
            buttonViewCompras.BackColor = Color.FromArgb(192, 255, 192);
            buttonViewCompras.Cursor = Cursors.Hand;
            buttonViewCompras.FlatStyle = FlatStyle.Popup;
            buttonViewCompras.ForeColor = Color.FromArgb(0, 64, 0);
            buttonViewCompras.Image = Properties.Resources.compra;
            buttonViewCompras.ImageAlign = ContentAlignment.MiddleLeft;
            buttonViewCompras.Location = new Point(531, 6);
            buttonViewCompras.Name = "buttonViewCompras";
            buttonViewCompras.Size = new Size(164, 37);
            buttonViewCompras.TabIndex = 9;
            buttonViewCompras.Text = "Compras";
            buttonViewCompras.UseVisualStyleBackColor = false;
            buttonViewCompras.Click += buttonViewCompras_Click;
            // 
            // buttonViewVendas
            // 
            buttonViewVendas.BackColor = Color.FromArgb(255, 255, 192);
            buttonViewVendas.Cursor = Cursors.Hand;
            buttonViewVendas.FlatStyle = FlatStyle.Popup;
            buttonViewVendas.ForeColor = Color.FromArgb(64, 64, 0);
            buttonViewVendas.Image = Properties.Resources.venda;
            buttonViewVendas.ImageAlign = ContentAlignment.MiddleLeft;
            buttonViewVendas.Location = new Point(701, 6);
            buttonViewVendas.Name = "buttonViewVendas";
            buttonViewVendas.Size = new Size(164, 37);
            buttonViewVendas.TabIndex = 10;
            buttonViewVendas.Text = "Vendas";
            buttonViewVendas.UseVisualStyleBackColor = false;
            buttonViewVendas.Click += buttonViewVendas_Click;
            // 
            // buttonAdicionarFornecedor
            // 
            buttonAdicionarFornecedor.BackColor = Color.FromArgb(192, 192, 255);
            buttonAdicionarFornecedor.FlatStyle = FlatStyle.Popup;
            buttonAdicionarFornecedor.ForeColor = Color.FromArgb(0, 0, 64);
            buttonAdicionarFornecedor.Location = new Point(361, 49);
            buttonAdicionarFornecedor.Name = "buttonAdicionarFornecedor";
            buttonAdicionarFornecedor.Size = new Size(164, 23);
            buttonAdicionarFornecedor.TabIndex = 11;
            buttonAdicionarFornecedor.Text = "Adicionar Fornecedor";
            buttonAdicionarFornecedor.UseVisualStyleBackColor = false;
            buttonAdicionarFornecedor.Click += buttonAdicionarFornecedor_Click;
            // 
            // buttonRemoverFornecedor
            // 
            buttonRemoverFornecedor.BackColor = Color.FromArgb(192, 192, 255);
            buttonRemoverFornecedor.FlatStyle = FlatStyle.Popup;
            buttonRemoverFornecedor.ForeColor = Color.FromArgb(0, 0, 64);
            buttonRemoverFornecedor.Location = new Point(361, 78);
            buttonRemoverFornecedor.Name = "buttonRemoverFornecedor";
            buttonRemoverFornecedor.Size = new Size(164, 23);
            buttonRemoverFornecedor.TabIndex = 12;
            buttonRemoverFornecedor.Text = "Remover Fornecedor";
            buttonRemoverFornecedor.UseVisualStyleBackColor = false;
            buttonRemoverFornecedor.Click += buttonRemoverFornecedor_Click;
            // 
            // buttonAdicionarCompra
            // 
            buttonAdicionarCompra.BackColor = Color.FromArgb(192, 255, 192);
            buttonAdicionarCompra.FlatStyle = FlatStyle.Popup;
            buttonAdicionarCompra.ForeColor = Color.FromArgb(0, 64, 0);
            buttonAdicionarCompra.Location = new Point(531, 49);
            buttonAdicionarCompra.Name = "buttonAdicionarCompra";
            buttonAdicionarCompra.Size = new Size(164, 23);
            buttonAdicionarCompra.TabIndex = 13;
            buttonAdicionarCompra.Text = "Adicionar Compra";
            buttonAdicionarCompra.UseVisualStyleBackColor = false;
            buttonAdicionarCompra.Click += buttonAdicionarCompra_Click;
            // 
            // buttonRemoverCompra
            // 
            buttonRemoverCompra.BackColor = Color.FromArgb(192, 255, 192);
            buttonRemoverCompra.FlatStyle = FlatStyle.Popup;
            buttonRemoverCompra.ForeColor = Color.FromArgb(0, 64, 0);
            buttonRemoverCompra.Location = new Point(531, 78);
            buttonRemoverCompra.Name = "buttonRemoverCompra";
            buttonRemoverCompra.Size = new Size(164, 23);
            buttonRemoverCompra.TabIndex = 14;
            buttonRemoverCompra.Text = "Remover Compra";
            buttonRemoverCompra.UseVisualStyleBackColor = false;
            buttonRemoverCompra.Click += buttonRemoverCompra_Click;
            // 
            // buttonAdicionarVenda
            // 
            buttonAdicionarVenda.BackColor = Color.FromArgb(255, 255, 192);
            buttonAdicionarVenda.FlatStyle = FlatStyle.Popup;
            buttonAdicionarVenda.ForeColor = Color.FromArgb(64, 64, 0);
            buttonAdicionarVenda.Location = new Point(701, 49);
            buttonAdicionarVenda.Name = "buttonAdicionarVenda";
            buttonAdicionarVenda.Size = new Size(164, 23);
            buttonAdicionarVenda.TabIndex = 15;
            buttonAdicionarVenda.Text = "Adicionar venda";
            buttonAdicionarVenda.UseVisualStyleBackColor = false;
            buttonAdicionarVenda.Click += buttonAdicionarVenda_Click;
            // 
            // buttonRemovervenda
            // 
            buttonRemovervenda.BackColor = Color.FromArgb(255, 255, 192);
            buttonRemovervenda.FlatStyle = FlatStyle.Popup;
            buttonRemovervenda.ForeColor = Color.FromArgb(64, 64, 0);
            buttonRemovervenda.Location = new Point(701, 78);
            buttonRemovervenda.Name = "buttonRemovervenda";
            buttonRemovervenda.Size = new Size(164, 23);
            buttonRemovervenda.TabIndex = 16;
            buttonRemovervenda.Text = "Remover Venda";
            buttonRemovervenda.UseVisualStyleBackColor = false;
            buttonRemovervenda.Click += buttonRemovervenda_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(877, 450);
            Controls.Add(buttonRemovervenda);
            Controls.Add(buttonAdicionarVenda);
            Controls.Add(buttonRemoverCompra);
            Controls.Add(buttonAdicionarCompra);
            Controls.Add(buttonRemoverFornecedor);
            Controls.Add(buttonAdicionarFornecedor);
            Controls.Add(buttonViewVendas);
            Controls.Add(buttonViewCompras);
            Controls.Add(buttonViewFornecedores);
            Controls.Add(buttonRemoverCliente);
            Controls.Add(buttonAdicionarCliente);
            Controls.Add(buttonViewClientes);
            Controls.Add(dataGridView1);
            Controls.Add(buttonAdicionarProduto);
            Controls.Add(buttonRemoverProduto);
            Controls.Add(buttonViewProdutos);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonViewProdutos;
        private Button button2;
        private Button buttonRemoverProduto;
        private Button buttonAdicionarProduto;
        private DataGridView dataGridView1;
        private Button buttonViewClientes;
        private Button buttonAdicionarCliente;
        private Button buttonRemoverCliente;
        private Button buttonViewFornecedores;
        private Button buttonViewCompras;
        private Button buttonViewVendas;
        private Button buttonAdicionarFornecedor;
        private Button buttonRemoverFornecedor;
        private Button buttonAdicionarCompra;
        private Button buttonRemoverCompra;
        private Button buttonAdicionarVenda;
        private Button buttonRemovervenda;
    }
}
