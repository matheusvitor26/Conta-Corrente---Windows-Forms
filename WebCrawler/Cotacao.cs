using HtmlAgilityPack;
using System.Collections.Generic;
using System.Linq;

namespace WebCrawler
{
    public class Cotacao
    {
        public float GetCotacao()
        {
            string cotacaoDolar;
            HtmlWeb web = new HtmlWeb();
            HtmlDocument html = web.Load("https://economia.uol.com.br/");
            
            List<HtmlNode> htmlNodes = html.DocumentNode.Descendants("h3").Where(node => node.GetAttributeValue("class", "").Equals("primeiroGrafico")).ToList();
            cotacaoDolar = htmlNodes.FirstOrDefault().ChildNodes.LastOrDefault().InnerHtml;

            return float.Parse(cotacaoDolar.Replace("R$", "").Trim());
        }
    }
}