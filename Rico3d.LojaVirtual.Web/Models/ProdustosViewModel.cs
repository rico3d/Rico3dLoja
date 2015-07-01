using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Rico3d.LojaVirtual.Dominio.Entidades;

namespace Rico3d.LojaVirtual.Web.Models
{
    public class ProdustosViewModel
    {
        public IEnumerable<Produto> Produtos { get; set; }
        public Paginacao Paginacao { get; set; }
    }
}