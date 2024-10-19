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
    public partial class FormCriarProduto : Form
    {
        public string nome { get { return textBoxNome.Text; } }
        public string nomeFabricante { get { return textBoxFornecedor.Text; } }
        public float precoCompra { get { return (float)numericUpDownCompra.Value; } }
        public float precoVenda { get { return (float)numericUpDownVenda.Value; } }

        public FormCriarProduto()
        {
            InitializeComponent();
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
    }
}
