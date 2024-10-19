using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicativoForm
{
    public class Class_Cliente
    {
        public int Id { get; set; }
        [DisplayName("Cliente")] public string nome { get; set; }

        [DisplayName("Telefone")] public string telefone { get; set; }

        [DisplayName("Endereço de E-mail")] public string email { get; set; }

        [DisplayName("Endereço Físico")] public string Endereco { get; set; }

    }
}
