using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicativoForm
{
    public partial class FormAdicionarVenda : Form
    {
        public int idProduto { get { return (int)numericUpDownIDproduto.Value; } }
        public int idCliente { get { return (int)numericUpDownIDcliente.Value; } }
        public int quantidade { get { return (int)numericUpDownQuantidade.Value; } }
        public float desconto { get { return (float)numericUpDownDesconto.Value; } }

        public FormAdicionarVenda()
        {
            InitializeComponent();
        }

        private void buttonoOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
