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
    public partial class FormAdicionarFornecedor : Form
    {
        public string nome { get { return textBoxNome.Text; } }
        public string telefone { get { return textBoxTelefone.Text; } }
        public string email { get { return textBoxEmail.Text; } }
        public string endereco { get { return textBoxEndereco.Text; } }

        public FormAdicionarFornecedor()
        {
            InitializeComponent();
        }

        private void FormAdicionarFornecedor_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Cancel;
            this.Close();
        }
    }
}
