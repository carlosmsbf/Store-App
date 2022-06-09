#pragma checksum "C:\Users\Carlos Barros\Desktop\Programacao\Asp.Net\ConvenienceStore\ConvenienceStore\Views\Stores\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb3f77e547660c51cefc392485775261bbba9e95"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Stores_Details), @"mvc.1.0.view", @"/Views/Stores/Details.cshtml")]
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
#line 1 "C:\Users\Carlos Barros\Desktop\Programacao\Asp.Net\ConvenienceStore\ConvenienceStore\Views\_ViewImports.cshtml"
using ConvenienceStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Carlos Barros\Desktop\Programacao\Asp.Net\ConvenienceStore\ConvenienceStore\Views\_ViewImports.cshtml"
using ConvenienceStore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Carlos Barros\Desktop\Programacao\Asp.Net\ConvenienceStore\ConvenienceStore\Views\_ViewImports.cshtml"
using ConvenienceStore.Models.ModelView;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb3f77e547660c51cefc392485775261bbba9e95", @"/Views/Stores/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b035848c5d0f708c94cecca5d72882c20fb311b", @"/Views/_ViewImports.cshtml")]
    public class Views_Stores_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ConvenienceStore.Models.Store>
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
#line 3 "C:\Users\Carlos Barros\Desktop\Programacao\Asp.Net\ConvenienceStore\ConvenienceStore\Views\Stores\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""d-flex justify-content-center"">
    <div class=""card d-block bg-dark text-white "" style=""width:600px; border-radius: 22px;"">
        <h3 class=""d-flex justify-content-center"">Product Details from Store</h3>
    </div>

</div>

<hr />

<div class=""card mt-3"">
    <div class=""card-header font-weight-bolder d-flex justify-content-center""> Product Information</div>
    <div class=""card-body"">
        <div class=""card-body row"">
            <div class=""form-group col-md"">
                <label class=""d-flex justify-content-center"">
                    ");
#nullable restore
#line 22 "C:\Users\Carlos Barros\Desktop\Programacao\Asp.Net\ConvenienceStore\ConvenienceStore\Views\Stores\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Inventory.Product.Category.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </label>\r\n                <input class=\"form-control\" style=\"border-radius: 22px;\" disabled");
            BeginWriteAttribute("value", " value=\"", 843, "\"", 915, 1);
#nullable restore
#line 24 "C:\Users\Carlos Barros\Desktop\Programacao\Asp.Net\ConvenienceStore\ConvenienceStore\Views\Stores\Details.cshtml"
WriteAttributeValue("", 851, Html.DisplayFor(model => model.Inventory.Product.Category.Name), 851, 64, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </div>\r\n\r\n            <div class=\"form-group col-md\">\r\n                <label class=\"d-flex justify-content-center\">\r\n                    ");
#nullable restore
#line 29 "C:\Users\Carlos Barros\Desktop\Programacao\Asp.Net\ConvenienceStore\ConvenienceStore\Views\Stores\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Inventory.Product.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </label>\r\n                <input class=\"form-control\" style=\"border-radius: 22px;\" disabled");
            BeginWriteAttribute("value", " value=\"", 1239, "\"", 1302, 1);
#nullable restore
#line 31 "C:\Users\Carlos Barros\Desktop\Programacao\Asp.Net\ConvenienceStore\ConvenienceStore\Views\Stores\Details.cshtml"
WriteAttributeValue("", 1247, Html.DisplayFor(model => model.Inventory.Product.Name), 1247, 55, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </div>\r\n            <div class=\"form-group col-md\">\r\n                <label class=\"d-flex justify-content-center\">\r\n                    ");
#nullable restore
#line 35 "C:\Users\Carlos Barros\Desktop\Programacao\Asp.Net\ConvenienceStore\ConvenienceStore\Views\Stores\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Inventory.Product.Brand));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </label>\r\n                <input class=\"form-control\" style=\"border-radius: 22px;\" disabled");
            BeginWriteAttribute("value", " value=\"", 1625, "\"", 1694, 1);
#nullable restore
#line 37 "C:\Users\Carlos Barros\Desktop\Programacao\Asp.Net\ConvenienceStore\ConvenienceStore\Views\Stores\Details.cshtml"
WriteAttributeValue("", 1633, Html.DisplayFor(model => model.Inventory.Product.Brand.Name), 1633, 61, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group col-md\">\r\n            <label class=\"d-flex justify-content-center\">\r\n                ");
#nullable restore
#line 42 "C:\Users\Carlos Barros\Desktop\Programacao\Asp.Net\ConvenienceStore\ConvenienceStore\Views\Stores\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Inventory.Product.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </label>\r\n            <input class=\"form-control\" style=\"border-radius: 22px;\" disabled");
            BeginWriteAttribute("value", " value=\"", 2019, "\"", 2089, 1);
#nullable restore
#line 44 "C:\Users\Carlos Barros\Desktop\Programacao\Asp.Net\ConvenienceStore\ConvenienceStore\Views\Stores\Details.cshtml"
WriteAttributeValue("", 2027, Html.DisplayFor(model => model.Inventory.Product.Description), 2027, 62, false);

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
#line 57 "C:\Users\Carlos Barros\Desktop\Programacao\Asp.Net\ConvenienceStore\ConvenienceStore\Views\Stores\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Inventory.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </label>\r\n                <input class=\"form-control\" style=\"border-radius: 22px;\" disabled");
            BeginWriteAttribute("value", " value=\"", 2622, "\"", 2675, 1);
#nullable restore
#line 59 "C:\Users\Carlos Barros\Desktop\Programacao\Asp.Net\ConvenienceStore\ConvenienceStore\Views\Stores\Details.cshtml"
WriteAttributeValue("", 2630, Html.DisplayFor(model => model.Inventory.Id), 2630, 45, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </div>\r\n\r\n            <div class=\"form-group col-md\">\r\n                <label class=\"d-flex justify-content-center\">\r\n                    ");
#nullable restore
#line 64 "C:\Users\Carlos Barros\Desktop\Programacao\Asp.Net\ConvenienceStore\ConvenienceStore\Views\Stores\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Inventory.Cost));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </label>\r\n                <input class=\"form-control\" style=\"border-radius: 22px;\" disabled");
            BeginWriteAttribute("value", " value=\"", 2991, "\"", 3046, 1);
#nullable restore
#line 66 "C:\Users\Carlos Barros\Desktop\Programacao\Asp.Net\ConvenienceStore\ConvenienceStore\Views\Stores\Details.cshtml"
WriteAttributeValue("", 2999, Html.DisplayFor(model => model.Inventory.Cost), 2999, 47, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </div>\r\n\r\n            <div class=\"form-group col-md\">\r\n                <label class=\"d-flex justify-content-center\">\r\n                    ");
#nullable restore
#line 71 "C:\Users\Carlos Barros\Desktop\Programacao\Asp.Net\ConvenienceStore\ConvenienceStore\Views\Stores\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Inventory.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </label>\r\n                <input class=\"form-control\" style=\"border-radius: 22px;\" disabled");
            BeginWriteAttribute("value", " value=\"", 3362, "\"", 3417, 1);
#nullable restore
#line 73 "C:\Users\Carlos Barros\Desktop\Programacao\Asp.Net\ConvenienceStore\ConvenienceStore\Views\Stores\Details.cshtml"
WriteAttributeValue("", 3370, Html.DisplayFor(model => model.Inventory.Date), 3370, 47, false);

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
#line 86 "C:\Users\Carlos Barros\Desktop\Programacao\Asp.Net\ConvenienceStore\ConvenienceStore\Views\Stores\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </label>\r\n                <input class=\"form-control\" style=\"border-radius: 22px;\" disabled");
            BeginWriteAttribute("value", " value=\"", 3955, "\"", 3998, 1);
#nullable restore
#line 88 "C:\Users\Carlos Barros\Desktop\Programacao\Asp.Net\ConvenienceStore\ConvenienceStore\Views\Stores\Details.cshtml"
WriteAttributeValue("", 3963, Html.DisplayFor(model => model.Id), 3963, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </div>\r\n\r\n            <div class=\"form-group col-md\">\r\n                <label class=\"d-flex justify-content-center\">\r\n                    ");
#nullable restore
#line 93 "C:\Users\Carlos Barros\Desktop\Programacao\Asp.Net\ConvenienceStore\ConvenienceStore\Views\Stores\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </label>\r\n                <input class=\"form-control\" style=\"border-radius: 22px;\" disabled");
            BeginWriteAttribute("value", " value=\"", 4308, "\"", 4357, 1);
#nullable restore
#line 95 "C:\Users\Carlos Barros\Desktop\Programacao\Asp.Net\ConvenienceStore\ConvenienceStore\Views\Stores\Details.cshtml"
WriteAttributeValue("", 4316, Html.DisplayFor(model => model.Quantity), 4316, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </div>\r\n\r\n\r\n            <div class=\"form-group col-md\">\r\n                <label class=\"d-flex justify-content-center\">\r\n                    ");
#nullable restore
#line 101 "C:\Users\Carlos Barros\Desktop\Programacao\Asp.Net\ConvenienceStore\ConvenienceStore\Views\Stores\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </label>\r\n                <input class=\"form-control\" style=\"border-radius: 22px;\" disabled");
            BeginWriteAttribute("value", " value=\"", 4666, "\"", 4712, 1);
#nullable restore
#line 103 "C:\Users\Carlos Barros\Desktop\Programacao\Asp.Net\ConvenienceStore\ConvenienceStore\Views\Stores\Details.cshtml"
WriteAttributeValue("", 4674, Html.DisplayFor(model => model.Price), 4674, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </div>\r\n\r\n            <div class=\"form-group col-md\">\r\n                <label class=\"d-flex justify-content-center\">\r\n                    ");
#nullable restore
#line 108 "C:\Users\Carlos Barros\Desktop\Programacao\Asp.Net\ConvenienceStore\ConvenienceStore\Views\Stores\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </label>\r\n                <input class=\"form-control\" style=\"border-radius: 22px;\" disabled");
            BeginWriteAttribute("value", " value=\"", 5018, "\"", 5063, 1);
#nullable restore
#line 110 "C:\Users\Carlos Barros\Desktop\Programacao\Asp.Net\ConvenienceStore\ConvenienceStore\Views\Stores\Details.cshtml"
WriteAttributeValue("", 5026, Html.DisplayFor(model => model.Date), 5026, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n<hr/>\r\n<div class=\"d-flex justify-content-center\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eb3f77e547660c51cefc392485775261bbba9e9517623", async() => {
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
#line 119 "C:\Users\Carlos Barros\Desktop\Programacao\Asp.Net\ConvenienceStore\ConvenienceStore\Views\Stores\Details.cshtml"
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eb3f77e547660c51cefc392485775261bbba9e9519987", async() => {
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ConvenienceStore.Models.Store> Html { get; private set; }
    }
}
#pragma warning restore 1591
