#pragma checksum "C:\Users\Ender\OneDrive\Masaüstü\Masaüstü\TraversalProject-master\TraversalProject\Views\Shared\Components\_LastDestinations\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "29de613e14d257bc0d44bd5c065d8f305de7985647914f654f24e66ad133923e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__LastDestinations_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_LastDestinations/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"29de613e14d257bc0d44bd5c065d8f305de7985647914f654f24e66ad133923e", @"/Views/Shared/Components/_LastDestinations/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"b5668328aef60d664de0b95ac105868715041d617560202702853ad53b0f74f3", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components__LastDestinations_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Destination>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""col-12 mt-4"">
    <div class=""card mb-4"">
        <div class=""card-header pb-0 p-3"">
            <h6 class=""mb-1"">Son Rotalar</h6>
            <p class=""text-sm"">Traversal Şirketinin En Son Eklenen Seyahat Rotaları</p>
        </div>
        <div class=""card-body p-3"">
            <div class=""row"">
");
#nullable restore
#line 11 "C:\Users\Ender\OneDrive\Masaüstü\Masaüstü\TraversalProject-master\TraversalProject\Views\Shared\Components\_LastDestinations\Default.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""col-xl-3 col-md-6 mb-xl-0 mb-4"">
                        <div class=""card card-blog card-plain"">
                            <div class=""position-relative"">
                                <a class=""d-block shadow-xl border-radius-xl"">
                                    <img");
            BeginWriteAttribute("src", " src=\"", 709, "\"", 731, 1);
#nullable restore
#line 17 "C:\Users\Ender\OneDrive\Masaüstü\Masaüstü\TraversalProject-master\TraversalProject\Views\Shared\Components\_LastDestinations\Default.cshtml"
WriteAttributeValue("", 715, item.CoverImage, 715, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""img-blur-shadow"" style=""width:400px; height:200px;"" class=""img-fluid shadow border-radius-xl"">
                                </a>
                            </div>
                            <div class=""card-body px-1 pb-0"">
                                <p class=""text-gradient text-dark mb-2 text-sm"">");
#nullable restore
#line 21 "C:\Users\Ender\OneDrive\Masaüstü\Masaüstü\TraversalProject-master\TraversalProject\Views\Shared\Components\_LastDestinations\Default.cshtml"
                                                                           Write(item.DayNight);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 21 "C:\Users\Ender\OneDrive\Masaüstü\Masaüstü\TraversalProject-master\TraversalProject\Views\Shared\Components\_LastDestinations\Default.cshtml"
                                                                                            Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ₺</p>\n                                <a href=\"javascript:;\">\n                                    <h5>\n                                        ");
#nullable restore
#line 24 "C:\Users\Ender\OneDrive\Masaüstü\Masaüstü\TraversalProject-master\TraversalProject\Views\Shared\Components\_LastDestinations\Default.cshtml"
                                   Write(item.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                    </h5>\n                                </a>\n                                <p class=\"mb-4 text-sm\">\n");
#nullable restore
#line 28 "C:\Users\Ender\OneDrive\Masaüstü\Masaüstü\TraversalProject-master\TraversalProject\Views\Shared\Components\_LastDestinations\Default.cshtml"
                                     if (item != null && !string.IsNullOrEmpty(item.Details1))
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\Ender\OneDrive\Masaüstü\Masaüstü\TraversalProject-master\TraversalProject\Views\Shared\Components\_LastDestinations\Default.cshtml"
                                   Write(item.Details1.Substring(0, Math.Min(100, item.Details1.Length)));

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\Ender\OneDrive\Masaüstü\Masaüstü\TraversalProject-master\TraversalProject\Views\Shared\Components\_LastDestinations\Default.cshtml"
                                                                                                        
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </p>\n                                <div class=\"d-flex align-items-center justify-content-between\">\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 1814, "\"", 1872, 2);
            WriteAttributeValue("", 1821, "/destination/destinationdetails/", 1821, 32, true);
#nullable restore
#line 34 "C:\Users\Ender\OneDrive\Masaüstü\Masaüstü\TraversalProject-master\TraversalProject\Views\Shared\Components\_LastDestinations\Default.cshtml"
WriteAttributeValue("", 1853, item.DestinationID, 1853, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-primary btn-sm mb-0\">Tur Detayları</a>\n");
            WriteLiteral("                                </div>\n                            </div>\n                        </div>\n                    </div>\n");
#nullable restore
#line 53 "C:\Users\Ender\OneDrive\Masaüstü\Masaüstü\TraversalProject-master\TraversalProject\Views\Shared\Components\_LastDestinations\Default.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\n        </div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Destination>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
