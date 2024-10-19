using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicativoForm
{
    public class Class_Fornecedor
    {
        public int Id { get; set; }
        [DisplayName("Fornecedor")] public string nome { get; set; }

        [DisplayName("Telefone")] public string telefone { get; set; }

        [DisplayName("Endereço E-mail")] public string email { get; set; }

        [DisplayName("Endereço Físico")] public string endereco { get; set; }


    }
}
