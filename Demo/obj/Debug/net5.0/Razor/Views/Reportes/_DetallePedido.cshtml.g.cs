#pragma checksum "D:\Users\PROGRAMACION\Desktop\BMS\Demo\Views\Reportes\_DetallePedido.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f8fd2f2f68867bf73599dd045981ab5816d6893"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reportes__DetallePedido), @"mvc.1.0.view", @"/Views/Reportes/_DetallePedido.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f8fd2f2f68867bf73599dd045981ab5816d6893", @"/Views/Reportes/_DetallePedido.cshtml")]
    public class Views_Reportes__DetallePedido : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Demo.Models.DetallePedido>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<table class=""table table-hover"" id=""tablaProds"">
	<thead>
	 <tr>
	  <th>Código</th>
	  <th>Descripción</th>
	  <th>Cantidad Autorizada</th>
	  <th>Cantidad Surtida</th>
	  <th>Unidad</th>
	  <th>Precio</th>
	  <th>Total</th>
  </tr>
 </thead>
 <tbody>
");
#nullable restore
#line 16 "D:\Users\PROGRAMACION\Desktop\BMS\Demo\Views\Reportes\_DetallePedido.cshtml"
      foreach(var prods in Model)
		{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<tr>\r\n\t   <td>");
#nullable restore
#line 19 "D:\Users\PROGRAMACION\Desktop\BMS\Demo\Views\Reportes\_DetallePedido.cshtml"
      Write(prods.cod_prod);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t   <td>");
#nullable restore
#line 20 "D:\Users\PROGRAMACION\Desktop\BMS\Demo\Views\Reportes\_DetallePedido.cshtml"
      Write(prods.descripcion_completa);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t   <td>");
#nullable restore
#line 21 "D:\Users\PROGRAMACION\Desktop\BMS\Demo\Views\Reportes\_DetallePedido.cshtml"
      Write(prods.cantidad_autorizada.ToString("#,##0.###"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t   <td>");
#nullable restore
#line 22 "D:\Users\PROGRAMACION\Desktop\BMS\Demo\Views\Reportes\_DetallePedido.cshtml"
      Write(prods.cantidad_surtida.ToString("#,##0.###"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t   <td>");
#nullable restore
#line 23 "D:\Users\PROGRAMACION\Desktop\BMS\Demo\Views\Reportes\_DetallePedido.cshtml"
      Write(prods.unidad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t    <td>");
#nullable restore
#line 24 "D:\Users\PROGRAMACION\Desktop\BMS\Demo\Views\Reportes\_DetallePedido.cshtml"
       Write(prods.precio.ToString("#,##0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t<td>");
#nullable restore
#line 25 "D:\Users\PROGRAMACION\Desktop\BMS\Demo\Views\Reportes\_DetallePedido.cshtml"
       Write(prods.total.ToString("#,##0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\r\n   </tr>\r\n");
#nullable restore
#line 28 "D:\Users\PROGRAMACION\Desktop\BMS\Demo\Views\Reportes\_DetallePedido.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Demo.Models.DetallePedido>> Html { get; private set; }
    }
}
#pragma warning restore 1591
