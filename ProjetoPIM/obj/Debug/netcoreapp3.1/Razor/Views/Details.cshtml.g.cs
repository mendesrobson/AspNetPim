#pragma checksum "C:\Users\rnma\Documents\Source\AspNetPim\ProjetoPIM\Views\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5dea403b362b4d5798e2f4b0da6d1a033380c691"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Details), @"mvc.1.0.view", @"/Views/Details.cshtml")]
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
#line 1 "C:\Users\rnma\Documents\Source\AspNetPim\ProjetoPIM\Views\_ViewImports.cshtml"
using ProjetoPIM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rnma\Documents\Source\AspNetPim\ProjetoPIM\Views\_ViewImports.cshtml"
using ProjetoPIM.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5dea403b362b4d5798e2f4b0da6d1a033380c691", @"/Views/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d5de3cd90092b97a445c832d7e3ac75c05b6639", @"/Views/_ViewImports.cshtml")]
    public class Views_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Pessoa>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\rnma\Documents\Source\AspNetPim\ProjetoPIM\Views\Details.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5dea403b362b4d5798e2f4b0da6d1a033380c6913424", async() => {
                WriteLiteral("\r\n    <!--head-->\r\n    <meta name=\"viewport\"");
                BeginWriteAttribute("content", " content=\"", 119, "\"", 129, 0);
                EndWriteAttribute();
                WriteLiteral(@" width-divvice-width"" />
    <title>Detalhes Usuarios</title>
    <link rel=""icon"" type=""image/x-icon"" href=""#"" />
    <link rel=""stylesheet"" type=""text/css"" href=""#"" />
    <link rel=""stylesheet"" type=""text/css"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css"" />
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>
    <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js""></script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("<!--fim head-->\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5dea403b362b4d5798e2f4b0da6d1a033380c6915120", async() => {
                WriteLiteral(@"
    <!--body-->
    <nav class=""navbar navbar-default"">

        <div class=""container-fluid"">
            <div class=""navbar-header"">
                <a class=""navbar-brand"" href=""#"">Lista de Usuarios</a>
            </div>
            <url class=""nav navbar-nav navbar-right"">
                <li>");
#nullable restore
#line 27 "C:\Users\rnma\Documents\Source\AspNetPim\ProjetoPIM\Views\Details.cshtml"
               Write(Html.ActionLink("Editar Pessoa","Edit", new {id = Model.Id}));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                <li>");
#nullable restore
#line 28 "C:\Users\rnma\Documents\Source\AspNetPim\ProjetoPIM\Views\Details.cshtml"
               Write(Html.ActionLink("Voltar para Home","Index"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</li>
            </url>
        </div>
    </nav>

    <div style=""margin: auto; width: 90%; padding: 10px;"">
        <h4>Detalhes Pessoa</h4>
        <hr />

        <table class=""content-table"" style=""margin:auto; width: 95%; padding: 10px;"">
            <tr>
                <th>
                    ");
#nullable restore
#line 40 "C:\Users\rnma\Documents\Source\AspNetPim\ProjetoPIM\Views\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 43 "C:\Users\rnma\Documents\Source\AspNetPim\ProjetoPIM\Views\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Cpf));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 46 "C:\Users\rnma\Documents\Source\AspNetPim\ProjetoPIM\Views\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Endereco));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n            </tr>\r\n            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 51 "C:\Users\rnma\Documents\Source\AspNetPim\ProjetoPIM\Views\Details.cshtml"
               Write(Html.DisplayFor(model => model.Nome));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n                 <td>\r\n                    ");
#nullable restore
#line 54 "C:\Users\rnma\Documents\Source\AspNetPim\ProjetoPIM\Views\Details.cshtml"
               Write(Html.DisplayFor(model => model.Cpf));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n                 <td>\r\n                    ");
#nullable restore
#line 57 "C:\Users\rnma\Documents\Source\AspNetPim\ProjetoPIM\Views\Details.cshtml"
               Write(Html.DisplayFor(model => model.Endereco));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n            </tr>\r\n        </table>\r\n    </div>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("<!--fim body-->\r\n\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pessoa> Html { get; private set; }
    }
}
#pragma warning restore 1591
