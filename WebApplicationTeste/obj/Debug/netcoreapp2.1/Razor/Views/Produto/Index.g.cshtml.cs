#pragma checksum "C:\GIT\ApiTeste\WebApplicationTeste\Views\Produto\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8257d83ae7cfa54e0e9c5501faa0298239aedc32"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produto_Index), @"mvc.1.0.view", @"/Views/Produto/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Produto/Index.cshtml", typeof(AspNetCore.Views_Produto_Index))]
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
#line 1 "C:\GIT\ApiTeste\WebApplicationTeste\Views\_ViewImports.cshtml"
using WebApplicationTeste;

#line default
#line hidden
#line 2 "C:\GIT\ApiTeste\WebApplicationTeste\Views\_ViewImports.cshtml"
using WebApplicationTeste.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8257d83ae7cfa54e0e9c5501faa0298239aedc32", @"/Views/Produto/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7536152bdca597c5d40c0fce8329f895e523ba8b", @"/Views/_ViewImports.cshtml")]
    public class Views_Produto_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebApplicationTeste.Models.ProdutoData>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(60, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\GIT\ApiTeste\WebApplicationTeste\Views\Produto\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(103, 32, true);
            WriteLiteral("\r\n<h2>Produtos</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(135, 41, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ec6635a66a54264b4142743fefa919b", async() => {
                BeginContext(158, 14, true);
                WriteLiteral("+ Novo Produto");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(176, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(269, 45, false);
#line 16 "C:\GIT\ApiTeste\WebApplicationTeste\Views\Produto\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IdProduto));

#line default
#line hidden
            EndContext();
            BeginContext(314, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(370, 47, false);
#line 19 "C:\GIT\ApiTeste\WebApplicationTeste\Views\Produto\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.NomeProduto));

#line default
#line hidden
            EndContext();
            BeginContext(417, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(473, 48, false);
#line 22 "C:\GIT\ApiTeste\WebApplicationTeste\Views\Produto\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DataCadastro));

#line default
#line hidden
            EndContext();
            BeginContext(521, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(577, 46, false);
#line 25 "C:\GIT\ApiTeste\WebApplicationTeste\Views\Produto\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Quantidade));

#line default
#line hidden
            EndContext();
            BeginContext(623, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(679, 47, false);
#line 28 "C:\GIT\ApiTeste\WebApplicationTeste\Views\Produto\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IdCategoria));

#line default
#line hidden
            EndContext();
            BeginContext(726, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 34 "C:\GIT\ApiTeste\WebApplicationTeste\Views\Produto\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(844, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(893, 44, false);
#line 37 "C:\GIT\ApiTeste\WebApplicationTeste\Views\Produto\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.IdProduto));

#line default
#line hidden
            EndContext();
            BeginContext(937, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(993, 46, false);
#line 40 "C:\GIT\ApiTeste\WebApplicationTeste\Views\Produto\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.NomeProduto));

#line default
#line hidden
            EndContext();
            BeginContext(1039, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1095, 47, false);
#line 43 "C:\GIT\ApiTeste\WebApplicationTeste\Views\Produto\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DataCadastro));

#line default
#line hidden
            EndContext();
            BeginContext(1142, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1198, 45, false);
#line 46 "C:\GIT\ApiTeste\WebApplicationTeste\Views\Produto\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Quantidade));

#line default
#line hidden
            EndContext();
            BeginContext(1243, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1299, 46, false);
#line 49 "C:\GIT\ApiTeste\WebApplicationTeste\Views\Produto\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.IdCategoria));

#line default
#line hidden
            EndContext();
            BeginContext(1345, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1401, 60, false);
#line 52 "C:\GIT\ApiTeste\WebApplicationTeste\Views\Produto\Index.cshtml"
           Write(Html.ActionLink("Editar", "Edit", new { id=item.IdProduto }));

#line default
#line hidden
            EndContext();
            BeginContext(1461, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1482, 65, false);
#line 53 "C:\GIT\ApiTeste\WebApplicationTeste\Views\Produto\Index.cshtml"
           Write(Html.ActionLink("Detalhes", "Details", new { id=item.IdProduto }));

#line default
#line hidden
            EndContext();
            BeginContext(1547, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1568, 63, false);
#line 54 "C:\GIT\ApiTeste\WebApplicationTeste\Views\Produto\Index.cshtml"
           Write(Html.ActionLink("Excluir", "Delete", new { id=item.IdProduto }));

#line default
#line hidden
            EndContext();
            BeginContext(1631, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 57 "C:\GIT\ApiTeste\WebApplicationTeste\Views\Produto\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1670, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebApplicationTeste.Models.ProdutoData>> Html { get; private set; }
    }
}
#pragma warning restore 1591
