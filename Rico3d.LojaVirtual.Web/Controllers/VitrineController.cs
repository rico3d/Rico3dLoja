using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Rico3d.LojaVirtual.Dominio.Repositorio;
using Rico3d.LojaVirtual.Web.Models;

namespace Rico3d.LojaVirtual.Web.Controllers
{
    public class VitrineController : Controller
    {
        private ProdutosRepositorio _repositorio;
        public int ProdutosPorPagina = 8;

        public ActionResult ListaProdutos(int pagina = 1)
        {
        _repositorio = new ProdutosRepositorio();

            var model = new ProdustosViewModel()
            {
                Produtos = _repositorio.Produtos
                    .OrderBy(p => p.Descricao)
                    .Skip((pagina - 1)*ProdutosPorPagina)
                    .Take(ProdutosPorPagina),


                Paginacao = new Paginacao()
                {
                    PaginaAtual = pagina,
                    ItensPorPagina = ProdutosPorPagina,
                    ItensTotal = _repositorio.Produtos.Count()
                }
            };



            return View(model);
        }
    }
}