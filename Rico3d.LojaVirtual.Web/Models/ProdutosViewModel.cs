using System.Collections.Generic;
using ASP.NET_MVC5_Bootstrap_3._3._4_LESS1.Dominio.Entidades;

namespace ASP.NET_MVC5_Bootstrap_3._3._4_LESS1.Models
{
    public class ProdutosViewModel
    {
        

        public IEnumerable<Produto> Produtos { get; set; }
        public Paginacao Paginacao { get; set; }

        public string CategoriaAtual { get; set; }

    }
}