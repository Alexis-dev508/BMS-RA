#pragma checksum "C:\Users\PROGRAMACION\source\repos\Demo\Demo\Views\Catalogos\EditarAroma.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bed2ebbab97b29406fd08bdf5046e832a47fc411"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Catalogos_EditarAroma), @"mvc.1.0.view", @"/Views/Catalogos/EditarAroma.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bed2ebbab97b29406fd08bdf5046e832a47fc411", @"/Views/Catalogos/EditarAroma.cshtml")]
    public class Views_Catalogos_EditarAroma : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Demo.Models.AromasModelView>
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
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bed2ebbab97b29406fd08bdf5046e832a47fc4112814", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Editar Aroma</title>\r\n");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bed2ebbab97b29406fd08bdf5046e832a47fc4113880", async() => {
                WriteLiteral("\r\n\r\n<h4>Aromas</h4>\r\n<hr />\r\n<div class=\"container-fluid\">\r\n    <div>\r\n    <a");
                BeginWriteAttribute("href", " href=\"", 290, "\"", 330, 1);
#nullable restore
#line 20 "C:\Users\PROGRAMACION\source\repos\Demo\Demo\Views\Catalogos\EditarAroma.cshtml"
WriteAttributeValue("", 297, Url.Action("Aromas","Catalogos"), 297, 33, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Regresar</a>\r\n</div>\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n");
#nullable restore
#line 24 "C:\Users\PROGRAMACION\source\repos\Demo\Demo\Views\Catalogos\EditarAroma.cshtml"
             using (Html.BeginForm("EditarAroma","Catalogos",FormMethod.Post)){

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div asp-validation-summary=\"ModelOnly\" class=\"text-danger\"></div>\r\n                <div class=\"form-group\">\r\n                ");
#nullable restore
#line 27 "C:\Users\PROGRAMACION\source\repos\Demo\Demo\Views\Catalogos\EditarAroma.cshtml"
           Write(Html.Label("aroma","C??digo",new {@class="control-label"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
#nullable restore
#line 28 "C:\Users\PROGRAMACION\source\repos\Demo\Demo\Views\Catalogos\EditarAroma.cshtml"
           Write(Html.TextBoxFor(model=> model.aroma,new {@class="form-control",@readonly ="readonly"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("  \r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 31 "C:\Users\PROGRAMACION\source\repos\Demo\Demo\Views\Catalogos\EditarAroma.cshtml"
           Write(Html.Label("nombre","Nombre",new {@class="control-label"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
#nullable restore
#line 32 "C:\Users\PROGRAMACION\source\repos\Demo\Demo\Views\Catalogos\EditarAroma.cshtml"
           Write(Html.TextBoxFor(model=> model.nombre,new {@class="form-control"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                \r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 36 "C:\Users\PROGRAMACION\source\repos\Demo\Demo\Views\Catalogos\EditarAroma.cshtml"
           Write(Html.Label("abreviatura","Abrev",new {@class="control-label"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
#nullable restore
#line 37 "C:\Users\PROGRAMACION\source\repos\Demo\Demo\Views\Catalogos\EditarAroma.cshtml"
           Write(Html.TextBoxFor(model=> model.abreviatura,new {@class="form-control"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 40 "C:\Users\PROGRAMACION\source\repos\Demo\Demo\Views\Catalogos\EditarAroma.cshtml"
           Write(Html.Label("status","Status",new {@class="control-label"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
#nullable restore
#line 41 "C:\Users\PROGRAMACION\source\repos\Demo\Demo\Views\Catalogos\EditarAroma.cshtml"
           Write(Html.DropDownList("status",Model.StatusList,new {@class="form-control"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
                WriteLiteral("            </div>\r\n            <div class=\"form-group\">\r\n                <input type=\"submit\" value=\"Create\" class=\"btn btn-primary\" />\r\n            </div>\r\n");
#nullable restore
#line 47 "C:\Users\PROGRAMACION\source\repos\Demo\Demo\Views\Catalogos\EditarAroma.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"text-danger\">\r\n");
#nullable restore
#line 49 "C:\Users\PROGRAMACION\source\repos\Demo\Demo\Views\Catalogos\EditarAroma.cshtml"
             if(ViewBag.Errores != null)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "C:\Users\PROGRAMACION\source\repos\Demo\Demo\Views\Catalogos\EditarAroma.cshtml"
                   Write(ViewBag.Errores);

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "C:\Users\PROGRAMACION\source\repos\Demo\Demo\Views\Catalogos\EditarAroma.cshtml"
                                        
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n</div>\r\n\r\n\r\n\r\n\r\n");
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
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Demo.Models.AromasModelView> Html { get; private set; }
    }
}
#pragma warning restore 1591
