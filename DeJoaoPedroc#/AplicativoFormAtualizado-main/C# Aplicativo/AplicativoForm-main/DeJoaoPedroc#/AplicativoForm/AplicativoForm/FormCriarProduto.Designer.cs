namespace AplicativoForm
{
    partial class FormCriarProduto
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
            textBoxNome = new TextBox();
            textBoxFornecedor = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            numericUpDownCompra = new NumericUpDown();
            numericUpDownVenda = new NumericUpDown();
            buttonCancel = new Button();
            buttonOK = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCompra).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownVenda).BeginInit();
            SuspendLayout();
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(145, 89);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(141, 23);
            textBoxNome.TabIndex = 0;
            // 
            // textBoxFornecedor
            // 
            textBoxFornecedor.Location = new Point(145, 118);
            textBoxFornecedor.Name = "textBoxFornecedor";
            textBoxFornecedor.Size = new Size(141, 23);
            textBoxFornecedor.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 92);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 4;
            label1.Text = "Nome do Produto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 121);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 4;
            label2.Text = "Fornecedor:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 150);
            label3.Name = "label3";
            label3.Size = new Size(102, 15);
            label3.TabIndex = 4;
            label3.Text = "Preço de Compra:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 179);
            label4.Name = "label4";
            label4.Size = new Size(91, 15);
            label4.TabIndex = 4;
            label4.Text = "Preço de Venda:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(100, 9);
            label5.Name = "label5";
            label5.Size = new Size(82, 15);
            label5.TabIndex = 4;
            label5.Text = "Novo Produto";
            // 
            // numericUpDownCompra
            // 
            numericUpDownCompra.DecimalPlaces = 2;
            numericUpDownCompra.Location = new Point(145, 150);
            numericUpDownCompra.Name = "numericUpDownCompra";
            numericUpDownCompra.Size = new Size(141, 23);
            numericUpDownCompra.TabIndex = 5;
            numericUpDownCompra.TextAlign = HorizontalAlignment.Right;
            // 
            // numericUpDownVenda
            // 
            numericUpDownVenda.DecimalPlaces = 2;
            numericUpDownVenda.Location = new Point(145, 179);
            numericUpDownVenda.Name = "numericUpDownVenda";
            numericUpDownVenda.Size = new Size(141, 23);
            numericUpDownVenda.TabIndex = 6;
            numericUpDownVenda.TextAlign = HorizontalAlignment.Right;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(193, 237);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 7;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonOK
            // 
            buttonOK.Location = new Point(84, 237);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(75, 23);
            buttonOK.TabIndex = 8;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click;
            // 
            // FormCriarProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(314, 299);
            Controls.Add(buttonOK);
            Controls.Add(buttonCancel);
            Controls.Add(numericUpDownVenda);
            Controls.Add(numericUpDownCompra);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxFornecedor);
            Controls.Add(textBoxNome);
            Name = "FormCriarProduto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCriarProduto";
            ((System.ComponentModel.ISupportInitialize)numericUpDownCompra).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownVenda).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNome;
        private TextBox textBoxFornecedor;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private NumericUpDown numericUpDownCompra;
        private NumericUpDown numericUpDownVenda;
        private Button buttonCancel;
        private Button buttonOK;
    }
}