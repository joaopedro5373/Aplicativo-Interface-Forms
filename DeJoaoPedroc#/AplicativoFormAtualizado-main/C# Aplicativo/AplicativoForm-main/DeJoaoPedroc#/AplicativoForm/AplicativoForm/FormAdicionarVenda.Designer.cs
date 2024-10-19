namespace AplicativoForm
{
    partial class FormAdicionarVenda
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
            buttonCancel = new Button();
            buttonoOK = new Button();
            numericUpDownQuantidade = new NumericUpDown();
            numericUpDownIDproduto = new NumericUpDown();
            numericUpDownDesconto = new NumericUpDown();
            numericUpDownIDcliente = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantidade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownIDproduto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDesconto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownIDcliente).BeginInit();
            SuspendLayout();
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(157, 220);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 0;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonoOK
            // 
            buttonoOK.Location = new Point(73, 220);
            buttonoOK.Name = "buttonoOK";
            buttonoOK.Size = new Size(75, 23);
            buttonoOK.TabIndex = 1;
            buttonoOK.Text = "OK";
            buttonoOK.UseVisualStyleBackColor = true;
            buttonoOK.Click += buttonoOK_Click;
            // 
            // numericUpDownQuantidade
            // 
            numericUpDownQuantidade.Location = new Point(174, 138);
            numericUpDownQuantidade.Name = "numericUpDownQuantidade";
            numericUpDownQuantidade.Size = new Size(120, 23);
            numericUpDownQuantidade.TabIndex = 2;
            // 
            // numericUpDownIDproduto
            // 
            numericUpDownIDproduto.Location = new Point(174, 80);
            numericUpDownIDproduto.Name = "numericUpDownIDproduto";
            numericUpDownIDproduto.Size = new Size(120, 23);
            numericUpDownIDproduto.TabIndex = 3;
            // 
            // numericUpDownDesconto
            // 
            numericUpDownDesconto.DecimalPlaces = 2;
            numericUpDownDesconto.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            numericUpDownDesconto.Location = new Point(174, 167);
            numericUpDownDesconto.Name = "numericUpDownDesconto";
            numericUpDownDesconto.Size = new Size(120, 23);
            numericUpDownDesconto.TabIndex = 4;
            numericUpDownDesconto.TextAlign = HorizontalAlignment.Right;
            // 
            // numericUpDownIDcliente
            // 
            numericUpDownIDcliente.Location = new Point(174, 109);
            numericUpDownIDcliente.Name = "numericUpDownIDcliente";
            numericUpDownIDcliente.Size = new Size(120, 23);
            numericUpDownIDcliente.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 111);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 6;
            label1.Text = "ID do Cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(110, 23);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 6;
            label2.Text = "Nova venda";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 169);
            label3.Name = "label3";
            label3.Size = new Size(147, 15);
            label3.TabIndex = 6;
            label3.Text = "Porcentagem de Desconto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 140);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 6;
            label4.Text = "Quantidade";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 82);
            label5.Name = "label5";
            label5.Size = new Size(81, 15);
            label5.TabIndex = 6;
            label5.Text = "ID do Produto";
            // 
            // FormAdicionarVenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(306, 270);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numericUpDownIDcliente);
            Controls.Add(numericUpDownDesconto);
            Controls.Add(numericUpDownIDproduto);
            Controls.Add(numericUpDownQuantidade);
            Controls.Add(buttonoOK);
            Controls.Add(buttonCancel);
            Name = "FormAdicionarVenda";
            Text = "FormAdicionarVenda";
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantidade).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownIDproduto).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDesconto).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownIDcliente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCancel;
        private Button buttonoOK;
        private NumericUpDown numericUpDownQuantidade;
        private NumericUpDown numericUpDownIDproduto;
        private NumericUpDown numericUpDownDesconto;
        private NumericUpDown numericUpDownIDcliente;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}