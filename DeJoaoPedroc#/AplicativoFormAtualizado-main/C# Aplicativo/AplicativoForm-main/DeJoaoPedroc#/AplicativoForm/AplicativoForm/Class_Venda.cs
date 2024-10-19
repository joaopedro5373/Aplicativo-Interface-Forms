using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicativoForm
{
    public class Class_Venda
    {
        public int Id { get; set; }
        [DisplayName("Id do produto")] public int idProduto {get;set;}

        [DisplayName("Id do cliente")] public int idCliente { get; set; }

        [DisplayName("Quantidade")] public int quantidade { get; set; }

        [DisplayName("Porcentagem de desconto")] public float desconto { get; set; }

    }
}
