#pragma checksum "C:\Users\PROGRAMACION\source\repos\Demo\Demo\Views\Reportes\ReportePedidos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a4e678dbfbc98a51a71571f7fcb357f04f9df5c5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reportes_ReportePedidos), @"mvc.1.0.view", @"/Views/Reportes/ReportePedidos.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a4e678dbfbc98a51a71571f7fcb357f04f9df5c5", @"/Views/Reportes/ReportePedidos.cshtml")]
    public class Views_Reportes_ReportePedidos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Demo.Models.ReportePedidosModelView>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""container-fluid"">
    <div class=""row"">
        <div class=""col-12"">
            <div class=""card-primary"">
                <div class=""card-header"">
                    <h3>Reporte de pedidos</h3>
                </div>
                <br />
");
#nullable restore
#line 10 "C:\Users\PROGRAMACION\source\repos\Demo\Demo\Views\Reportes\ReportePedidos.cshtml"
                 using (Html.BeginForm("ReportePedidos", "Reportes", FormMethod.Post))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"row\">\r\n                        <div class=\"col-md-6\">\r\n                            <div class=\"form-group\">\r\n                                ");
#nullable restore
#line 15 "C:\Users\PROGRAMACION\source\repos\Demo\Demo\Views\Reportes\ReportePedidos.cshtml"
                           Write(Html.Label("FechaInicial", "Fecha inicial"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                ");
#nullable restore
#line 16 "C:\Users\PROGRAMACION\source\repos\Demo\Demo\Views\Reportes\ReportePedidos.cshtml"
                           Write(Html.TextBoxFor(m => m.FechaInicial, new { @class = "form-control datetimepicker-input" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"col-md-6\">\r\n                            <div class=\"form-group\">\r\n                                ");
#nullable restore
#line 21 "C:\Users\PROGRAMACION\source\repos\Demo\Demo\Views\Reportes\ReportePedidos.cshtml"
                           Write(Html.Label("FechaFinal", "Fecha final"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                ");
#nullable restore
#line 22 "C:\Users\PROGRAMACION\source\repos\Demo\Demo\Views\Reportes\ReportePedidos.cshtml"
                           Write(Html.TextBoxFor(m => m.FechaFinal, new { @class = "form-control datetimepicker-input" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </div>
                        </div>
                    </div>
                    <br />
                    <div class=""row"">
                        <div class=""col-12"">
                            <input type=""submit"" class=""btn btn-lg btn-success"" value=""Actualizar"" />
                        </div>
                    </div>
                    <br />
                    <table id=""tabla"" class=""table table-bordered"">
                        <thead>
                            <tr>
                                <th>Folio</th>
                                <th>Fecha</th>
                                <th>Cliente</th>
                                <th>Nombre Cte</th>
                                <th>Vendedor</th>
                                <th>Nombre Vdor</th>
                                <th>Total</th>
                                <th>Establecimiento</th>
                            </tr>
                        </thead>
       ");
            WriteLiteral("                 <tbody>\r\n");
#nullable restore
#line 47 "C:\Users\PROGRAMACION\source\repos\Demo\Demo\Views\Reportes\ReportePedidos.cshtml"
                             foreach (var ped in Model.Datos)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td><a href=\"#\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2349, "\"", 2394, 3);
            WriteAttributeValue("", 2359, "detallePedido(\'", 2359, 15, true);
#nullable restore
#line 50 "C:\Users\PROGRAMACION\source\repos\Demo\Demo\Views\Reportes\ReportePedidos.cshtml"
WriteAttributeValue("", 2374, ped.folio.Trim(), 2374, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2391, "\');", 2391, 3, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 50 "C:\Users\PROGRAMACION\source\repos\Demo\Demo\Views\Reportes\ReportePedidos.cshtml"
                                                                                         Write(ped.folio);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n                                <td>");
#nullable restore
#line 51 "C:\Users\PROGRAMACION\source\repos\Demo\Demo\Views\Reportes\ReportePedidos.cshtml"
                               Write(ped.fecha.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 52 "C:\Users\PROGRAMACION\source\repos\Demo\Demo\Views\Reportes\ReportePedidos.cshtml"
                               Write(ped.cod_cte);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 53 "C:\Users\PROGRAMACION\source\repos\Demo\Demo\Views\Reportes\ReportePedidos.cshtml"
                               Write(ped.razon_social);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 54 "C:\Users\PROGRAMACION\source\repos\Demo\Demo\Views\Reportes\ReportePedidos.cshtml"
                               Write(ped.vendedor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 55 "C:\Users\PROGRAMACION\source\repos\Demo\Demo\Views\Reportes\ReportePedidos.cshtml"
                               Write(ped.nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 56 "C:\Users\PROGRAMACION\source\repos\Demo\Demo\Views\Reportes\ReportePedidos.cshtml"
                               Write(ped.total.ToString("#,##0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 57 "C:\Users\PROGRAMACION\source\repos\Demo\Demo\Views\Reportes\ReportePedidos.cshtml"
                               Write(ped.establecimiento);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>\r\n");
#nullable restore
#line 59 "C:\Users\PROGRAMACION\source\repos\Demo\Demo\Views\Reportes\ReportePedidos.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n");
#nullable restore
#line 62 "C:\Users\PROGRAMACION\source\repos\Demo\Demo\Views\Reportes\ReportePedidos.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>
        </div>
    </div>
</div>
<div class=""modal fade bd-example-modal-lg"" id=""modalDetalle"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
  <div class=""modal-dialog modal-lg"" role=""document"">
    <div class=""modal-content"">
      <div class=""modal-header"">
        <h5 class=""modal-title"" id=""exampleModalLabel"">Detalles del Pedido</h5>
        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
          <span aria-hidden=""true"">&times;</span>
        </button>
      </div>
      <div class=""modal-body"" id=""datosProductos"">
        
      </div>
      <div class=""modal-footer"">
        <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Cerrar</button>
      </div>
    </div>
  </div>
</div>
<script>
    $(document).ready(function () {
        $('#tabla').DataTable();
        $('#FechaInicial').datetimepicker({
            format: 'L'
        });
        $('#FechaFinal').datetimep");
            WriteLiteral("icker({\r\n            format: \'L\'\r\n        });\r\n    });\r\n\r\n    function detallePedido(folio){\r\n        $(\"#datosProductos\").empty();\r\n        $.ajax({\r\n            type:\"GET\",\r\n            url:\"");
#nullable restore
#line 101 "C:\Users\PROGRAMACION\source\repos\Demo\Demo\Views\Reportes\ReportePedidos.cshtml"
            Write(Url.Action("DetallePedido","Reportes"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""" + ""?folio="" + folio,
            success:function(data){
                $(""#datosProductos"").append(data);
                $('#modalDetalle').modal('show');
            },
            error: function (xhr,ajaxOptions,thrownError){alert(xhr.responseText);}
        });
    }
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Demo.Models.ReportePedidosModelView> Html { get; private set; }
    }
}
#pragma warning restore 1591