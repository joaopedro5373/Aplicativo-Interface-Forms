namespace AplicativoForm
{
    partial class FormAdicionarCompra
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
            buttonOK = new Button();
            buttonCancel = new Button();
            numericUpDownQuantidade = new NumericUpDown();
            numericUpDownDesconto = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            comboBoxProduto = new ComboBox();
            comboBoxFornecedor = new ComboBox();
            textBoxPrecoUnitario = new TextBox();
            textBoxValorTotal = new TextBox();
            label8 = new Label();
            label9 = new Label();
            textBoxValorTotalDesconto = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantidade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDesconto).BeginInit();
            SuspendLayout();
            // 
            // buttonOK
            // 
            buttonOK.Location = new Point(97, 272);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(75, 23);
            buttonOK.TabIndex = 0;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(178, 272);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 1;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // numericUpDownQuantidade
            // 
            numericUpDownQuantidade.Location = new Point(152, 85);
            numericUpDownQuantidade.Name = "numericUpDownQuantidade";
            numericUpDownQuantidade.Size = new Size(145, 23);
            numericUpDownQuantidade.TabIndex = 4;
            numericUpDownQuantidade.ValueChanged += numericUpDownQuantidade_ValueChanged;
            // 
            // numericUpDownDesconto
            // 
            numericUpDownDesconto.DecimalPlaces = 2;
            numericUpDownDesconto.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            numericUpDownDesconto.Location = new Point(152, 118);
            numericUpDownDesconto.Maximum = new decimal(new int[] { 1410065408, 2, 0, 0 });
            numericUpDownDesconto.Name = "numericUpDownDesconto";
            numericUpDownDesconto.Size = new Size(145, 23);
            numericUpDownDesconto.TabIndex = 5;
            numericUpDownDesconto.ValueChanged += numericUpDownDesconto_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 30);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 6;
            label1.Text = "Produto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 59);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 6;
            label2.Text = "Fornecedor:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 87);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 6;
            label3.Text = "Quantidade:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(5, 120);
            label5.Name = "label5";
            label5.Size = new Size(78, 15);
            label5.TabIndex = 6;
            label5.Text = "Desconto(%):";
            // 
            // comboBoxProduto
            // 
            comboBoxProduto.FormattingEnabled = true;
            comboBoxProduto.Location = new Point(152, 27);
            comboBoxProduto.Name = "comboBoxProduto";
            comboBoxProduto.Size = new Size(146, 23);
            comboBoxProduto.TabIndex = 7;
            comboBoxProduto.SelectedIndexChanged += comboBoxProduto_SelectedIndexChanged;
            // 
            // comboBoxFornecedor
            // 
            comboBoxFornecedor.FormattingEnabled = true;
            comboBoxFornecedor.Location = new Point(152, 56);
            comboBoxFornecedor.Name = "comboBoxFornecedor";
            comboBoxFornecedor.Size = new Size(146, 23);
            comboBoxFornecedor.TabIndex = 8;
            // 
            // textBoxPrecoUnitario
            // 
            textBoxPrecoUnitario.BackColor = SystemColors.ControlDarkDark;
            textBoxPrecoUnitario.ForeColor = SystemColors.Info;
            textBoxPrecoUnitario.Location = new Point(153, 147);
            textBoxPrecoUnitario.Name = "textBoxPrecoUnitario";
            textBoxPrecoUnitario.ReadOnly = true;
            textBoxPrecoUnitario.Size = new Size(146, 23);
            textBoxPrecoUnitario.TabIndex = 9;
            // 
            // textBoxValorTotal
            // 
            textBoxValorTotal.BackColor = SystemColors.ControlDarkDark;
            textBoxValorTotal.ForeColor = SystemColors.Info;
            textBoxValorTotal.Location = new Point(152, 176);
            textBoxValorTotal.Name = "textBoxValorTotal";
            textBoxValorTotal.Size = new Size(145, 23);
            textBoxValorTotal.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(5, 150);
            label8.Name = "label8";
            label8.Size = new Size(85, 15);
            label8.TabIndex = 13;
            label8.Text = "Preço Unitário:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(3, 208);
            label9.Name = "label9";
            label9.Size = new Size(144, 15);
            label9.TabIndex = 14;
            label9.Text = "Valor Total com Desconto:";
            // 
            // textBoxValorTotalDesconto
            // 
            textBoxValorTotalDesconto.BackColor = SystemColors.ControlDarkDark;
            textBoxValorTotalDesconto.ForeColor = SystemColors.Info;
            textBoxValorTotalDesconto.Location = new Point(153, 205);
            textBoxValorTotalDesconto.Name = "textBoxValorTotalDesconto";
            textBoxValorTotalDesconto.Size = new Size(145, 23);
            textBoxValorTotalDesconto.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 179);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 13;
            label4.Text = "Valor Total:\r\n";
            // 
            // FormAdicionarCompra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(324, 308);
            Controls.Add(textBoxValorTotalDesconto);
            Controls.Add(label9);
            Controls.Add(label4);
            Controls.Add(label8);
            Controls.Add(textBoxValorTotal);
            Controls.Add(textBoxPrecoUnitario);
            Controls.Add(comboBoxFornecedor);
            Controls.Add(comboBoxProduto);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numericUpDownDesconto);
            Controls.Add(numericUpDownQuantidade);
            Controls.Add(buttonCancel);
            Controls.Add(buttonOK);
            Name = "FormAdicionarCompra";
            Text = "FormAdicionarCompra";
            Load += FormAdicionarCompra_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantidade).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDesconto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonOK;
        private Button buttonCancel;
        private NumericUpDown numericUpDownQuantidade;
        private NumericUpDown numericUpDownDesconto;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private ComboBox comboBoxProduto;
        private ComboBox comboBoxFornecedor;
        private TextBox textBoxPrecoUnitario;
        private TextBox textBoxValorTotal;
        private Label label8;
        private Label label9;
        private TextBox textBoxValorTotalDesconto;
        private Label label4;
    }
}