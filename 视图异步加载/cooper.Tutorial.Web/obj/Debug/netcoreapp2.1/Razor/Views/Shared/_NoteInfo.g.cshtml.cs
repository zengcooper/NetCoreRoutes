#pragma checksum "D:\code\NetCore\chapter-07\Ken.Tutorial\cooper.Tutorial.Web\Views\Shared\_NoteInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e1ad61ad88c440911530627ed5cfc52a8ec7a73"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__NoteInfo), @"mvc.1.0.view", @"/Views/Shared/_NoteInfo.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_NoteInfo.cshtml", typeof(AspNetCore.Views_Shared__NoteInfo))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e1ad61ad88c440911530627ed5cfc52a8ec7a73", @"/Views/Shared/_NoteInfo.cshtml")]
    public class Views_Shared__NoteInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Ken.Tutorial.Web.Models.NoteViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 5, true);
            WriteLiteral("\n<h3>");
            EndContext();
            BeginContext(52, 11, false);
#line 3 "D:\code\NetCore\chapter-07\Ken.Tutorial\cooper.Tutorial.Web\Views\Shared\_NoteInfo.cshtml"
Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(63, 12, true);
            WriteLiteral("</h3>\n<span>");
            EndContext();
            BeginContext(76, 49, false);
#line 4 "D:\code\NetCore\chapter-07\Ken.Tutorial\cooper.Tutorial.Web\Views\Shared\_NoteInfo.cshtml"
 Write(Model.PublishTime.ToString("yyyy-MM-dd hh:mm:ss"));

#line default
#line hidden
            EndContext();
            BeginContext(125, 11, true);
            WriteLiteral("</span>\n<p>");
            EndContext();
            BeginContext(137, 10, false);
#line 5 "D:\code\NetCore\chapter-07\Ken.Tutorial\cooper.Tutorial.Web\Views\Shared\_NoteInfo.cshtml"
Write(Model.Body);

#line default
#line hidden
            EndContext();
            BeginContext(147, 4, true);
            WriteLiteral("</p>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Ken.Tutorial.Web.Models.NoteViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
