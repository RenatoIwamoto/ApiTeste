#pragma checksum "C:\GIT\ApiTeste\ApiTeste\Views\Categorias\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d0029dec6b79ba5f8fbdb7c8e60bde7ec06c4af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Categorias_Delete), @"mvc.1.0.view", @"/Views/Categorias/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Categorias/Delete.cshtml", typeof(AspNetCore.Views_Categorias_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d0029dec6b79ba5f8fbdb7c8e60bde7ec06c4af", @"/Views/Categorias/Delete.cshtml")]
    public class Views_Categorias_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ApiTeste.Models.Categoria>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(34, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\GIT\ApiTeste\ApiTeste\Views\Categorias\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(78, 170, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Categoria</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(249, 49, false);
#line 15 "C:\GIT\ApiTeste\ApiTeste\Views\Categorias\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.NomeCategoria));

#line default
#line hidden
            EndContext();
            BeginContext(298, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(342, 45, false);
#line 18 "C:\GIT\ApiTeste\ApiTeste\Views\Categorias\Delete.cshtml"
       Write(Html.DisplayFor(model => model.NomeCategoria));

#line default
#line hidden
            EndContext();
            BeginContext(387, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(431, 47, false);
#line 21 "C:\GIT\ApiTeste\ApiTeste\Views\Categorias\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DataCriacao));

#line default
#line hidden
            EndContext();
            BeginContext(478, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(522, 43, false);
#line 24 "C:\GIT\ApiTeste\ApiTeste\Views\Categorias\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DataCriacao));

#line default
#line hidden
            EndContext();
            BeginContext(565, 264, true);
            WriteLiteral(@"
        </dd>
    </dl>
    
    <form asp-action=""Delete"">
        <input type=""hidden"" asp-for=""IdCategoria"" />
        <input type=""submit"" value=""Delete"" class=""btn btn-default"" /> |
        <a asp-action=""Index"">Back to List</a>
    </form>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ApiTeste.Models.Categoria> Html { get; private set; }
    }
}
#pragma warning restore 1591