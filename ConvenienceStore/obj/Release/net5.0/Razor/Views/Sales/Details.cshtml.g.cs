#pragma checksum "C:\Users\Carlos Barros\source\repos\ConvenienceStore\ConvenienceStore\Views\Sales\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "283e40366300feaf75cad6c0efe9b6f11c880783"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sales_Details), @"mvc.1.0.view", @"/Views/Sales/Details.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Carlos Barros\source\repos\ConvenienceStore\ConvenienceStore\Views\_ViewImports.cshtml"
using ConvenienceStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Carlos Barros\source\repos\ConvenienceStore\ConvenienceStore\Views\_ViewImports.cshtml"
using ConvenienceStore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Carlos Barros\source\repos\ConvenienceStore\ConvenienceStore\Views\_ViewImports.cshtml"
using ConvenienceStore.Models.ModelView;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"283e40366300feaf75cad6c0efe9b6f11c880783", @"/Views/Sales/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b035848c5d0f708c94cecca5d72882c20fb311b", @"/Views/_ViewImports.cshtml")]
    public class Views_Sales_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ConvenienceStore.Models.Sale>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("border-radius: 35px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-light"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Carlos Barros\source\repos\ConvenienceStore\ConvenienceStore\Views\Sales\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""d-flex justify-content-center"">
    <div class=""card d-block bg-dark text-white "" style=""width:600px; border-radius: 22px;"">
        <h3 class=""d-flex justify-content-center"">Registrar uma Venda</h3>
    </div>

</div>

<hr />


<div class=""card mt-3"">
    <div class=""card-header font-weight-bolder d-flex justify-content-center""> Informação do Produto</div>
    <div class=""card-body"">
        <div class=""card-body row"">
            <div class=""form-group col-md"">
                <label class=""d-flex justify-content-center"">
                    ");
#nullable restore
#line 23 "C:\Users\Carlos Barros\source\repos\ConvenienceStore\ConvenienceStore\Views\Sales\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Store.Inventory.Product.Category.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </label>\r\n                <input class=\"form-control\" style=\"border-radius: 22px;\" disabled");
            BeginWriteAttribute("value", " value=\"", 845, "\"", 923, 1);
#nullable restore
#line 25 "C:\Users\Carlos Barros\source\repos\ConvenienceStore\ConvenienceStore\Views\Sales\Details.cshtml"
WriteAttributeValue("", 853, Html.DisplayFor(model => model.Store.Inventory.Product.Category.Name), 853, 70, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </div>\r\n\r\n            <div class=\"form-group col-md\">\r\n                <label class=\"d-flex justify-content-center\">\r\n                    ");
#nullable restore
#line 30 "C:\Users\Carlos Barros\source\repos\ConvenienceStore\ConvenienceStore\Views\Sales\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Store.Inventory.Product.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </label>\r\n                <input class=\"form-control\" style=\"border-radius: 22px;\" disabled");
            BeginWriteAttribute("value", " value=\"", 1253, "\"", 1322, 1);
#nullable restore
#line 32 "C:\Users\Carlos Barros\source\repos\ConvenienceStore\ConvenienceStore\Views\Sales\Details.cshtml"
WriteAttributeValue("", 1261, Html.DisplayFor(model => model.Store.Inventory.Product.Name), 1261, 61, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </div>\r\n            <div class=\"form-group col-md\">\r\n                <label class=\"d-flex justify-content-center\">\r\n                    ");
#nullable restore
#line 36 "C:\Users\Carlos Barros\source\repos\ConvenienceStore\ConvenienceStore\Views\Sales\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Store.Inventory.Product.Brand));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </label>\r\n                <input class=\"form-control\" style=\"border-radius: 22px;\" disabled");
            BeginWriteAttribute("value", " value=\"", 1651, "\"", 1726, 1);
#nullable restore
#line 38 "C:\Users\Carlos Barros\source\repos\ConvenienceStore\ConvenienceStore\Views\Sales\Details.cshtml"
WriteAttributeValue("", 1659, Html.DisplayFor(model => model.Store.Inventory.Product.Brand.Name), 1659, 67, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group col-md\">\r\n            <label class=\"d-flex justify-content-center\">\r\n                ");
#nullable restore
#line 43 "C:\Users\Carlos Barros\source\repos\ConvenienceStore\ConvenienceStore\Views\Sales\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Store.Inventory.Product.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </label>\r\n            <input class=\"form-control\" style=\"border-radius: 22px;\" disabled");
            BeginWriteAttribute("value", " value=\"", 2057, "\"", 2133, 1);
#nullable restore
#line 45 "C:\Users\Carlos Barros\source\repos\ConvenienceStore\ConvenienceStore\Views\Sales\Details.cshtml"
WriteAttributeValue("", 2065, Html.DisplayFor(model => model.Store.Inventory.Product.Description), 2065, 68, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
        </div>

    </div>
</div>

<div class=""card mt-3"">
    <div class=""card-header font-weight-bolder d-flex justify-content-center""> Informação do Estoque</div>
    <div class=""card-body"">
        <div class=""card-body row"">

            <div class=""form-group col-md"">
                <label class=""d-flex justify-content-center"">
                    ");
#nullable restore
#line 58 "C:\Users\Carlos Barros\source\repos\ConvenienceStore\ConvenienceStore\Views\Sales\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Store.Inventory.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </label>\r\n                <input class=\"form-control\" style=\"border-radius: 22px;\" disabled");
            BeginWriteAttribute("value", " value=\"", 2672, "\"", 2731, 1);
#nullable restore
#line 60 "C:\Users\Carlos Barros\source\repos\ConvenienceStore\ConvenienceStore\Views\Sales\Details.cshtml"
WriteAttributeValue("", 2680, Html.DisplayFor(model => model.Store.Inventory.Id), 2680, 51, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </div>\r\n\r\n            <div class=\"form-group col-md\">\r\n                <label class=\"d-flex justify-content-center\">\r\n                    ");
#nullable restore
#line 65 "C:\Users\Carlos Barros\source\repos\ConvenienceStore\ConvenienceStore\Views\Sales\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Store.Inventory.Cost));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </label>\r\n                <input class=\"form-control\" style=\"border-radius: 22px;\" disabled");
            BeginWriteAttribute("value", " value=\"", 3053, "\"", 3114, 1);
#nullable restore
#line 67 "C:\Users\Carlos Barros\source\repos\ConvenienceStore\ConvenienceStore\Views\Sales\Details.cshtml"
WriteAttributeValue("", 3061, Html.DisplayFor(model => model.Store.Inventory.Cost), 3061, 53, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </div>\r\n\r\n            <div class=\"form-group col-md\">\r\n                <label class=\"d-flex justify-content-center\">\r\n                    ");
#nullable restore
#line 72 "C:\Users\Carlos Barros\source\repos\ConvenienceStore\ConvenienceStore\Views\Sales\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Store.Inventory.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </label>\r\n                <input class=\"form-control\" style=\"border-radius: 22px;\" disabled");
            BeginWriteAttribute("value", " value=\"", 3436, "\"", 3497, 1);
#nullable restore
#line 74 "C:\Users\Carlos Barros\source\repos\ConvenienceStore\ConvenienceStore\Views\Sales\Details.cshtml"
WriteAttributeValue("", 3444, Html.DisplayFor(model => model.Store.Inventory.Date), 3444, 53, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
            </div>
        </div>
    </div>
</div>

<div class=""card mt-3"">
    <div class=""card-header font-weight-bolder d-flex justify-content-center""> Informação da Loja</div>
    <div class=""card-body"">
        <div class=""card-body row"">

            <div class=""form-group col-md"">
                <label class=""d-flex justify-content-center"">
                    ");
#nullable restore
#line 87 "C:\Users\Carlos Barros\source\repos\ConvenienceStore\ConvenienceStore\Views\Sales\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Store.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </label>\r\n                <input class=\"form-control\" style=\"border-radius: 22px;\" disabled");
            BeginWriteAttribute("value", " value=\"", 4041, "\"", 4090, 1);
#nullable restore
#line 89 "C:\Users\Carlos Barros\source\repos\ConvenienceStore\ConvenienceStore\Views\Sales\Details.cshtml"
WriteAttributeValue("", 4049, Html.DisplayFor(model => model.Store.Id), 4049, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </div>\r\n\r\n            <div class=\"form-group col-md\">\r\n                <label class=\"d-flex justify-content-center\">\r\n                    ");
#nullable restore
#line 94 "C:\Users\Carlos Barros\source\repos\ConvenienceStore\ConvenienceStore\Views\Sales\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </label>\r\n                <input class=\"form-control\" style=\"border-radius: 22px;\" disabled");
            BeginWriteAttribute("value", " value=\"", 4400, "\"", 4449, 1);
#nullable restore
#line 96 "C:\Users\Carlos Barros\source\repos\ConvenienceStore\ConvenienceStore\Views\Sales\Details.cshtml"
WriteAttributeValue("", 4408, Html.DisplayFor(model => model.Quantity), 4408, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </div>\r\n\r\n\r\n            <div class=\"form-group col-md\">\r\n                <label class=\"d-flex justify-content-center\">\r\n                    ");
#nullable restore
#line 102 "C:\Users\Carlos Barros\source\repos\ConvenienceStore\ConvenienceStore\Views\Sales\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Store.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </label>\r\n                <input class=\"form-control\" style=\"border-radius: 22px;\" disabled");
            BeginWriteAttribute("value", " value=\"", 4764, "\"", 4816, 1);
#nullable restore
#line 104 "C:\Users\Carlos Barros\source\repos\ConvenienceStore\ConvenienceStore\Views\Sales\Details.cshtml"
WriteAttributeValue("", 4772, Html.DisplayFor(model => model.Store.Price), 4772, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </div>\r\n\r\n            <div class=\"form-group col-md\">\r\n                <label class=\"d-flex justify-content-center\">\r\n                    ");
#nullable restore
#line 109 "C:\Users\Carlos Barros\source\repos\ConvenienceStore\ConvenienceStore\Views\Sales\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Store.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </label>\r\n                <input class=\"form-control\" style=\"border-radius: 22px;\" disabled");
            BeginWriteAttribute("value", " value=\"", 5128, "\"", 5179, 1);
#nullable restore
#line 111 "C:\Users\Carlos Barros\source\repos\ConvenienceStore\ConvenienceStore\Views\Sales\Details.cshtml"
WriteAttributeValue("", 5136, Html.DisplayFor(model => model.Store.Date), 5136, 43, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
            </div>
        </div>
    </div>
</div>

<div class=""card mt-3"">
    <div class=""card-header font-weight-bolder d-flex justify-content-center""> Informação da Venda</div>
    <div class=""card-body"">
        <div class=""card-body row"">

            <div class=""form-group col-md"">
                <label class=""d-flex justify-content-center"">
                    ");
#nullable restore
#line 124 "C:\Users\Carlos Barros\source\repos\ConvenienceStore\ConvenienceStore\Views\Sales\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Store.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </label>\r\n                <input class=\"form-control\" style=\"border-radius: 22px;\" disabled");
            BeginWriteAttribute("value", " value=\"", 5724, "\"", 5767, 1);
#nullable restore
#line 126 "C:\Users\Carlos Barros\source\repos\ConvenienceStore\ConvenienceStore\Views\Sales\Details.cshtml"
WriteAttributeValue("", 5732, Html.DisplayFor(model => model.Id), 5732, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </div>\r\n\r\n            <div class=\"form-group col-md\">\r\n                <label class=\"d-flex justify-content-center\">\r\n                    ");
#nullable restore
#line 131 "C:\Users\Carlos Barros\source\repos\ConvenienceStore\ConvenienceStore\Views\Sales\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </label>\r\n                <input class=\"form-control\" style=\"border-radius: 22px;\" disabled");
            BeginWriteAttribute("value", " value=\"", 6077, "\"", 6126, 1);
#nullable restore
#line 133 "C:\Users\Carlos Barros\source\repos\ConvenienceStore\ConvenienceStore\Views\Sales\Details.cshtml"
WriteAttributeValue("", 6085, Html.DisplayFor(model => model.Quantity), 6085, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </div>\r\n\r\n");
#nullable restore
#line 136 "C:\Users\Carlos Barros\source\repos\ConvenienceStore\ConvenienceStore\Views\Sales\Details.cshtml"
               double cost = Model.Store.Inventory.Cost;
                    double price = Model.Store.Price;
                int quantity = Model.Quantity;

                string unitProfit = (price - cost).ToString();
                string totalProfit = ((price - cost) * quantity).ToString();
            

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"form-group col-md\">\r\n                <label class=\"d-flex justify-content-center\">\r\n                    Lucro Unitário\r\n                </label>\r\n                <input class=\"form-control\" style=\"border-radius: 22px;\" disabled");
            BeginWriteAttribute("value", " value=\"", 6727, "\"", 6746, 1);
#nullable restore
#line 148 "C:\Users\Carlos Barros\source\repos\ConvenienceStore\ConvenienceStore\Views\Sales\Details.cshtml"
WriteAttributeValue("", 6735, unitProfit, 6735, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
            </div>

            <div class=""form-group col-md"">
                <label class=""d-flex justify-content-center"">
                    Lucro Total
                </label>
                <input class=""form-control"" style=""border-radius: 22px;"" disabled");
            BeginWriteAttribute("value", " value=\"", 7022, "\"", 7042, 1);
#nullable restore
#line 155 "C:\Users\Carlos Barros\source\repos\ConvenienceStore\ConvenienceStore\Views\Sales\Details.cshtml"
WriteAttributeValue("", 7030, totalProfit, 7030, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </div>\r\n\r\n            <div class=\"form-group col-md\">\r\n                <label class=\"d-flex justify-content-center\">\r\n                    ");
#nullable restore
#line 160 "C:\Users\Carlos Barros\source\repos\ConvenienceStore\ConvenienceStore\Views\Sales\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Store.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </label>\r\n                <input class=\"form-control\" style=\"border-radius: 22px;\" disabled");
            BeginWriteAttribute("value", " value=\"", 7354, "\"", 7405, 1);
#nullable restore
#line 162 "C:\Users\Carlos Barros\source\repos\ConvenienceStore\ConvenienceStore\Views\Sales\Details.cshtml"
WriteAttributeValue("", 7362, Html.DisplayFor(model => model.Store.Date), 7362, 43, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n<hr />\r\n<div class=\"d-flex justify-content-center\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "283e40366300feaf75cad6c0efe9b6f11c88078322352", async() => {
                WriteLiteral("Editar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 171 "C:\Users\Carlos Barros\source\repos\ConvenienceStore\ConvenienceStore\Views\Sales\Details.cshtml"
                           WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    <p>&ensp;</p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "283e40366300feaf75cad6c0efe9b6f11c88078324700", async() => {
                WriteLiteral("Voltar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ConvenienceStore.Models.Sale> Html { get; private set; }
    }
}
#pragma warning restore 1591
