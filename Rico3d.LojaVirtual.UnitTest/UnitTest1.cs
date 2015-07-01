using System;
using System.Web.Mvc;
using System.Web.WebPages.Html;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Rico3d.LojaVirtual.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestarSeApaginacaoEstaSendoGeradaCorretamente()
        {
            //arrange
            HtmlHelper ohtml = null;

            var paginacao = new Paginacao()
            {
                PaginaAtual = 2,
                ItensPorPagina = 10,
                ItensTotal = 28
            };

            Func<int,string> paginaUrl = i => "Pagina" + i;

            var resultado = ohtml.PageLinks(paginacao, paginaUrl);

            Assert.AreEqual(
               @"<a class=""btn btn-default"" href=""Pagina1"">1</a>"
               + @"<a class=""btn btn-default btn-primary selected"" href=""Pagina2"">2</a>"
               + @"<a class=""btn btn-default"" href=""Pagina3"">3</a>", resultado.ToString()
               );

        }
    }
}
