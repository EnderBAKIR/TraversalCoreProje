#pragma checksum "C:\Users\Ender\OneDrive\Masaüstü\Masaüstü\TraversalProject-master\TraversalProject\Views\Shared\_UILayout.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1a4b8eecfba006fe84bd157fd1297fba9ba871061356c6cada1c05eebc6fb678"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__UILayout), @"mvc.1.0.view", @"/Views/Shared/_UILayout.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Ender\OneDrive\Masaüstü\Masaüstü\TraversalProject-master\TraversalProject\Views\_ViewImports.cshtml"
using TraversalProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ender\OneDrive\Masaüstü\Masaüstü\TraversalProject-master\TraversalProject\Views\_ViewImports.cshtml"
using TraversalProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ender\OneDrive\Masaüstü\Masaüstü\TraversalProject-master\TraversalProject\Views\_ViewImports.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Ender\OneDrive\Masaüstü\Masaüstü\TraversalProject-master\TraversalProject\Views\_ViewImports.cshtml"
using TraversalProject.Areas.Member.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Ender\OneDrive\Masaüstü\Masaüstü\TraversalProject-master\TraversalProject\Views\_ViewImports.cshtml"
using DTOLayer.DTOs.ContactDTOs;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"1a4b8eecfba006fe84bd157fd1297fba9ba871061356c6cada1c05eebc6fb678", @"/Views/Shared/_UILayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"b5668328aef60d664de0b95ac105868715041d617560202702853ad53b0f74f3", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__UILayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 2 "C:\Users\Ender\OneDrive\Masaüstü\Masaüstü\TraversalProject-master\TraversalProject\Views\Shared\_UILayout.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<!doctype html>\n<html lang=\"zxx\">\n\n");
#nullable restore
#line 9 "C:\Users\Ender\OneDrive\Masaüstü\Masaüstü\TraversalProject-master\TraversalProject\Views\Shared\_UILayout.cshtml"
Write(await Html.PartialAsync("/Views/LayoutPartial/_HeaderPartial.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a4b8eecfba006fe84bd157fd1297fba9ba871061356c6cada1c05eebc6fb6784644", async() => {
                WriteLiteral("\n\n    ");
#nullable restore
#line 13 "C:\Users\Ender\OneDrive\Masaüstü\Masaüstü\TraversalProject-master\TraversalProject\Views\Shared\_UILayout.cshtml"
Write(await Html.PartialAsync("/Views/LayoutPartial/_NavbarPartial.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n\n    ");
#nullable restore
#line 15 "C:\Users\Ender\OneDrive\Masaüstü\Masaüstü\TraversalProject-master\TraversalProject\Views\Shared\_UILayout.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\n\n    ");
#nullable restore
#line 17 "C:\Users\Ender\OneDrive\Masaüstü\Masaüstü\TraversalProject-master\TraversalProject\Views\Shared\_UILayout.cshtml"
Write(await Html.PartialAsync("/Views/LayoutPartial/_FooterPartial.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n\n    ");
#nullable restore
#line 19 "C:\Users\Ender\OneDrive\Masaüstü\Masaüstü\TraversalProject-master\TraversalProject\Views\Shared\_UILayout.cshtml"
Write(await Html.PartialAsync("/Views/LayoutPartial/_ScriptsPartial.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n      \n");
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
            WriteLiteral("\n\n</html>\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591