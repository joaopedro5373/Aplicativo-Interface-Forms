using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicativoForm
{
    public class Class_Compra
    {
        public int Id { get; set; }
        [DisplayName("Id do Produto")] public int idProduto { get; set; }

        [DisplayName("Id do Fornecedor")] public int idFornecedor { get; set; }

        [DisplayName("Quantidade")] public int quantidade { get; set; }

        [DisplayName("Valor Total")] public decimal desconto { get; set; }

        [DisplayName("Data da compra")] public DateTime DataCompra { get; set; }


        public void loadData(string datastring)
        {
            string[] data = datastring.Split(";");
            Id = int.Parse(data[0]);
            idProduto = int.Parse(data[1]);
            idFornecedor = int.Parse(data[2]);
            quantidade = int.Parse(data[3]);
            desconto = decimal.Parse(data[4]);
            DataCompra = DateTime.Parse(data[5]);
        }
        public override string ToString()
        {
            return $"{Id};{idProduto};{idFornecedor};{quantidade};{desconto.ToString()};{DataCompra}";
        }
    } 
}
