#pragma checksum "C:\Users\AzureCerulean\Desktop\CSharp\MvcMovie\Views\Hello\Allowed.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a450216b1f7a5163adc9bc66d21ceb24915b50d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Hello_Allowed), @"mvc.1.0.view", @"/Views/Hello/Allowed.cshtml")]
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
#line 1 "C:\Users\AzureCerulean\Desktop\CSharp\MvcMovie\Views\_ViewImports.cshtml"
using MvcMovie;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\AzureCerulean\Desktop\CSharp\MvcMovie\Views\_ViewImports.cshtml"
using MvcMovie.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a450216b1f7a5163adc9bc66d21ceb24915b50d", @"/Views/Hello/Allowed.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"686ad2e38abb871af45be971520cc6c3156da389", @"/Views/_ViewImports.cshtml")]
    public class Views_Hello_Allowed : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\AzureCerulean\Desktop\CSharp\MvcMovie\Views\Hello\Allowed.cshtml"
  
    ViewData["Title"] = "Allowed";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1> Welcome to a pleasurable experience here at Fantasy Restobar.</h1>\r\n<div>\r\n");
#nullable restore
#line 7 "C:\Users\AzureCerulean\Desktop\CSharp\MvcMovie\Views\Hello\Allowed.cshtml"
     if((int)ViewData["Age"] >= 18)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>");
#nullable restore
#line 9 "C:\Users\AzureCerulean\Desktop\CSharp\MvcMovie\Views\Hello\Allowed.cshtml"
      Write(ViewData["Success"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
        <img src=""https://images.unsplash.com/photo-1581417478175-a9ef18f210c2?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=750&q=80""
             alt=""club""
             width=500px
             height=400px/>
");
#nullable restore
#line 14 "C:\Users\AzureCerulean\Desktop\CSharp\MvcMovie\Views\Hello\Allowed.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>");
#nullable restore
#line 17 "C:\Users\AzureCerulean\Desktop\CSharp\MvcMovie\Views\Hello\Allowed.cshtml"
      Write(ViewData["Not18"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
         <img src=""https://images.unsplash.com/photo-1570395623789-d9c9a31598a6?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=750&q=80""
             alt=""not allowed""
             width=500px
             height=400px/>
");
#nullable restore
#line 22 "C:\Users\AzureCerulean\Desktop\CSharp\MvcMovie\Views\Hello\Allowed.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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