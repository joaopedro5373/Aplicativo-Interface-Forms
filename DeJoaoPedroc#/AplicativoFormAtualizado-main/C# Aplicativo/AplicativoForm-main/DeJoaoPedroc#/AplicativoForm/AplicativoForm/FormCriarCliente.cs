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
    public partial class FormAdicionarCliente : Form
    {
        public string nome { get { return textBoxNome.Text; } }
        public string telefone { get { return textBoxTelefone.Text; } }
        public string email { get { return textBoxEmail.Text; } }
        public string Endereco
        {
            get
            {
                string endereco = "";
                endereco += $"({textBoxLogradouro.Text}), ";
                endereco += $"({textBoxNumero.Text}), ";
                endereco += $"({textBoxComplemento.Text}), ";
                endereco += $"({textBoxCidade.Text} - {textBoxUF.Text}), ";
                endereco += $"CEP: {textBoxCep.Text}";
                return endereco;
            }
        }

        public FormAdicionarCliente()
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

        private void FormAdicionarCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
