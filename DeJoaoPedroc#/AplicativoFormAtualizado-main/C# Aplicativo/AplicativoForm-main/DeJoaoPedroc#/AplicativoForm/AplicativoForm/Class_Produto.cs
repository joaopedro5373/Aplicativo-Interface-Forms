using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicativoForm
{
    public class Class_Produto
    {
        public int Id { get; set; }
        [DisplayName("Produto")] public string nome { get; set; }
        [DisplayName("Fabricante")] public string nomeFabricante { get; set; }
        [DisplayName("Preço de Compra")] public decimal precoCompra { get; set; }
        [DisplayName("Preço de Venda")] public decimal precoVenda { get; set; }

    }
}