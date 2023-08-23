using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.Runtime.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Services.Contracts;

namespace BlogApp.Infrastructure.TagHelpers
{
    // You may need to install the Microsoft.AspNetCore.Razor.Runtime package into your project
    [HtmlTargetElement("div", Attributes = "products")]
    public class LastestProductTagHelpers : TagHelper
    {
        private readonly IServiceManager _manager;

        [HtmlAttributeName("number")]
        public int Number { get; set; }


        public LastestProductTagHelpers(IServiceManager manager)
        {
            _manager = manager;
        }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            TagBuilder div = new TagBuilder("div");
            div.Attributes.Add("class", "my-3 , list-group");


         

            TagBuilder h6 = new TagBuilder("h6");
            h6.Attributes.Add("class", "lead");
            h6.InnerHtml.AppendHtml("Lastest Products");


            TagBuilder ul = new TagBuilder("ul");
            ul.Attributes.Add("class", "list-group");
            var products = _manager.ProductService.GetLastestProducts(Number, false);
            foreach (Product product in products)
            {
                TagBuilder li = new TagBuilder("li");
                TagBuilder a = new TagBuilder("a");
                a.Attributes.Add("href", $"/product/get/{product.ProductId}");
                a.Attributes.Add("class", "btn btn-outline-secondary list-group-item");
                a.InnerHtml.AppendHtml(product.ProductName);
                li.InnerHtml.AppendHtml(a);
                ul.InnerHtml.AppendHtml(li);


            }



            div.InnerHtml.AppendHtml(h6);
            div.InnerHtml.AppendHtml(ul);
            output.Content.AppendHtml(div);

        }
    }
}

