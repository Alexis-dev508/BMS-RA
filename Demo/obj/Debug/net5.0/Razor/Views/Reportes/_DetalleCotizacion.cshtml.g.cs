#pragma checksum "C:\Users\PROGRAMACION\source\repos\Demo\Demo\Views\Reportes\_DetalleCotizacion.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f91ad1704274bd87bc014776f15e9a930d9fcd6e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reportes__DetalleCotizacion), @"mvc.1.0.view", @"/Views/Reportes/_DetalleCotizacion.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f91ad1704274bd87bc014776f15e9a930d9fcd6e", @"/Views/Reportes/_DetalleCotizacion.cshtml")]
    public class Views_Reportes__DetalleCotizacion : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Demo.Models.DetalleCotizacion>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<table class=\"table table-hover\" id=\"tablaProds\">\r\n\t<thead>\r\n\t <tr>\r\n\t  <th>Código</th>\r\n\t  <th>Descripción</th>\r\n\t  <th>Cantidad</th>\r\n\t  <th>Unidad</th>\r\n\t  <th>Precio</th>\r\n\t  <th>Total</th>\r\n  </tr>\r\n </thead>\r\n <tbody>\r\n");
#nullable restore
#line 15 "C:\Users\PROGRAMACION\source\repos\Demo\Demo\Views\Reportes\_DetalleCotizacion.cshtml"
      foreach(var prods in Model)
		{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<tr>\r\n\t   <td>");
#nullable restore
#line 18 "C:\Users\PROGRAMACION\source\repos\Demo\Demo\Views\Reportes\_DetalleCotizacion.cshtml"
      Write(prods.cod_prod);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t   <td>");
#nullable restore
#line 19 "C:\Users\PROGRAMACION\source\repos\Demo\Demo\Views\Reportes\_DetalleCotizacion.cshtml"
      Write(prods.descripcion_completa);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t   <td>");
#nullable restore
#line 20 "C:\Users\PROGRAMACION\source\repos\Demo\Demo\Views\Reportes\_DetalleCotizacion.cshtml"
      Write(prods.cantidad.ToString("#,##0.###"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t   <td>");
#nullable restore
#line 21 "C:\Users\PROGRAMACION\source\repos\Demo\Demo\Views\Reportes\_DetalleCotizacion.cshtml"
      Write(prods.unidad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t    <td>");
#nullable restore
#line 22 "C:\Users\PROGRAMACION\source\repos\Demo\Demo\Views\Reportes\_DetalleCotizacion.cshtml"
       Write(prods.precio.ToString("#,##0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t<td>");
#nullable restore
#line 23 "C:\Users\PROGRAMACION\source\repos\Demo\Demo\Views\Reportes\_DetalleCotizacion.cshtml"
       Write(prods.total.ToString("#,##0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n   </tr>\r\n");
#nullable restore
#line 25 "C:\Users\PROGRAMACION\source\repos\Demo\Demo\Views\Reportes\_DetalleCotizacion.cshtml"
		}

#line default
#line hidden
#nullable disable
            WriteLiteral(" </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Demo.Models.DetalleCotizacion>> Html { get; private set; }
    }
}
#pragma warning restore 1591