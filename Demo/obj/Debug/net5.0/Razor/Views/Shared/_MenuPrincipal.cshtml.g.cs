#pragma checksum "C:\Users\PROGRAMACION\source\repos\Demo\Demo\Views\Shared\_MenuPrincipal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b967fb7c05e60b8bf3a85a2708dc00901da4456"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__MenuPrincipal), @"mvc.1.0.view", @"/Views/Shared/_MenuPrincipal.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b967fb7c05e60b8bf3a85a2708dc00901da4456", @"/Views/Shared/_MenuPrincipal.cshtml")]
    public class Views_Shared__MenuPrincipal : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<nav class=""mt-2"">
    <ul class=""nav nav-pills nav-sidebar flex-column"" data-widget=""treeview"" role=""menu"" data-accordion=""false"">
        <li class=""nav-item"">
            <a href=""#"" class=""nav-link"">
                <i class=""nav-icon fas fa-book""></i>
                <p>
                    Catálogos
                    <i class=""fas fa-angle-left right""></i>
                </p>
            </a>
            <ul class=""nav nav-treeview"">
                <li class=""nav-item"">
                    <a");
            BeginWriteAttribute("href", " href=\"", 519, "\"", 560, 1);
#nullable restore
#line 13 "C:\Users\PROGRAMACION\source\repos\Demo\Demo\Views\Shared\_MenuPrincipal.cshtml"
WriteAttributeValue("", 526, Url.Action("Sabores","Catalogos"), 526, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"nav-link\">\r\n                        <i class=\"far fa-circle nav-icon\"></i>\r\n                        <p>Sabores</p>\r\n                    </a>\r\n                </li>\r\n                <li class=\"nav-item\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 795, "\"", 835, 1);
#nullable restore
#line 19 "C:\Users\PROGRAMACION\source\repos\Demo\Demo\Views\Shared\_MenuPrincipal.cshtml"
WriteAttributeValue("", 802, Url.Action("Aromas","Catalogos"), 802, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""nav-link"">
                        <i class=""far fa-circle nav-icon""></i>
                        <p>Aromas</p>
                    </a>
                </li>
            </ul>
        </li>
        <li class=""nav-item"">
            <a href=""#"" class=""nav-link"">
                <i class=""nav-icon fas fa-table""></i>
                <p>
                    Reportes
                    <i class=""fas fa-angle-left right""></i>
                </p>
            </a>
            <ul class=""nav nav-treeview"">
                <li class=""nav-item"">
                    <a");
            BeginWriteAttribute("href", " href=\"", 1427, "\"", 1474, 1);
#nullable restore
#line 36 "C:\Users\PROGRAMACION\source\repos\Demo\Demo\Views\Shared\_MenuPrincipal.cshtml"
WriteAttributeValue("", 1434, Url.Action("ReportePedidos","Reportes"), 1434, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"nav-link\">\r\n                        <i class=\"far fa-circle nav-icon\"></i>\r\n                        <p>Pedidos</p>\r\n                    </a>\r\n                </li>\r\n                <li class=\"nav-item\">\r\n");
            WriteLiteral("                    <a");
            BeginWriteAttribute("href", " href=\"", 1744, "\"", 1796, 1);
#nullable restore
#line 43 "C:\Users\PROGRAMACION\source\repos\Demo\Demo\Views\Shared\_MenuPrincipal.cshtml"
WriteAttributeValue("", 1751, Url.Action("ReporteCotizaciones","Reportes"), 1751, 45, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"nav-link\">\r\n                        <i class=\"far fa-circle nav-icon\"></i>\r\n                        <p>Cotizaciones</p>\r\n                    </a>\r\n                </li>\r\n            </ul>\r\n        </li>\r\n    </ul>\r\n</nav>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
