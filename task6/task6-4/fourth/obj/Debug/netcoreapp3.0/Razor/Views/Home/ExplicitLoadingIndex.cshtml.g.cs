#pragma checksum "C:\Users\Arina\Desktop\web-2-master\sixth_task\fourth\Views\Home\ExplicitLoadingIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "81fe6b39569d63d8a64da737c17906145c3316e2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ExplicitLoadingIndex), @"mvc.1.0.view", @"/Views/Home/ExplicitLoadingIndex.cshtml")]
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
#line 1 "C:\Users\Arina\Desktop\web-2-master\sixth_task\fourth\Views\_ViewImports.cshtml"
using fourth;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Arina\Desktop\web-2-master\sixth_task\fourth\Views\_ViewImports.cshtml"
using fourth.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81fe6b39569d63d8a64da737c17906145c3316e2", @"/Views/Home/ExplicitLoadingIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06a10ecd68abbe6754e4faf7e6df9c7fda3c9415", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ExplicitLoadingIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Arina\Desktop\web-2-master\sixth_task\fourth\Views\Home\ExplicitLoadingIndex.cshtml"
  
    ViewData["Title"] = "Book catalog";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>Explicit loading</h2>\n\n<table width=\"100%\" class=\"table table-striped table-bordered table-hover\">\n    <tr>\n        <th>Book</th>\n        <th>Type</th>\n        <th>Price</th>\n    </tr>\n\n");
#nullable restore
#line 14 "C:\Users\Arina\Desktop\web-2-master\sixth_task\fourth\Views\Home\ExplicitLoadingIndex.cshtml"
     foreach (var toy in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>");
#nullable restore
#line 17 "C:\Users\Arina\Desktop\web-2-master\sixth_task\fourth\Views\Home\ExplicitLoadingIndex.cshtml"
           Write(toy.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 18 "C:\Users\Arina\Desktop\web-2-master\sixth_task\fourth\Views\Home\ExplicitLoadingIndex.cshtml"
           Write(toy.Type.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 19 "C:\Users\Arina\Desktop\web-2-master\sixth_task\fourth\Views\Home\ExplicitLoadingIndex.cshtml"
           Write(toy.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n");
#nullable restore
#line 21 "C:\Users\Arina\Desktop\web-2-master\sixth_task\fourth\Views\Home\ExplicitLoadingIndex.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
