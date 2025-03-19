using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static WFCadastroProduto.Usuário;

namespace WFCadastroProduto
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string? NomeProduto { get; set; }
        public string? Categoria { get; set; }
        public double? Preco { get; set; }
        public DateTime DataVencimento { get; set; }
        public string? Observacao { get; set; }

        public static
            List<Produto> ListaProduto = new List<Produto>();

    }
}
