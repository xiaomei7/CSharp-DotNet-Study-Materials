#pragma checksum "C:\Users\Xiaomei_Wang\Documents\GitHub\xiaomei7\Week4\OdeToFood\OdeToFood\Pages\Greetings.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bec9716b88691c4bcbd4e3c5077e82ba52ebc6df"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Greetings), @"mvc.1.0.razor-page", @"/Pages/Greetings.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Greetings.cshtml", typeof(AspNetCore.Pages_Greetings), @"{name}")]
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
#line 1 "C:\Users\Xiaomei_Wang\Documents\GitHub\xiaomei7\Week4\OdeToFood\OdeToFood\Pages\_ViewImports.cshtml"
using OdeToFood.Models;

#line default
#line hidden
#line 2 "C:\Users\Xiaomei_Wang\Documents\GitHub\xiaomei7\Week4\OdeToFood\OdeToFood\Pages\_ViewImports.cshtml"
using OdeToFood.ViewModels;

#line default
#line hidden
#line 3 "C:\Users\Xiaomei_Wang\Documents\GitHub\xiaomei7\Week4\OdeToFood\OdeToFood\Pages\_ViewImports.cshtml"
using OdeToFood.Pages;

#line default
#line hidden
#line 4 "C:\Users\Xiaomei_Wang\Documents\GitHub\xiaomei7\Week4\OdeToFood\OdeToFood\Pages\_ViewImports.cshtml"
using OdeToFood.Services;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{name}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bec9716b88691c4bcbd4e3c5077e82ba52ebc6df", @"/Pages/Greetings.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"049668f3ff472e3c13f080721e10f773e99c64d6", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Greetings : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(16, 8, true);
            WriteLiteral("\r\n<!--\r\n");
            EndContext();
            BeginContext(50, 13, true);
            WriteLiteral("\r\n<div>\r\n    ");
            EndContext();
            BeginContext(64, 28, false);
#line 7 "C:\Users\Xiaomei_Wang\Documents\GitHub\xiaomei7\Week4\OdeToFood\OdeToFood\Pages\Greetings.cshtml"
Write(Greeter.GetMessageOfTheDay());

#line default
#line hidden
            EndContext();
            BeginContext(92, 17, true);
            WriteLiteral("\r\n</div>\r\n-->\r\n\r\n");
            EndContext();
            BeginContext(132, 13, true);
            WriteLiteral("\r\n<div>\r\n    ");
            EndContext();
            BeginContext(146, 21, false);
#line 14 "C:\Users\Xiaomei_Wang\Documents\GitHub\xiaomei7\Week4\OdeToFood\OdeToFood\Pages\Greetings.cshtml"
Write(Model.CurrentGreeting);

#line default
#line hidden
            EndContext();
            BeginContext(167, 8, true);
            WriteLiteral("\r\n</div>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IGreeter Greeter { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GreetingsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<GreetingsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<GreetingsModel>)PageContext?.ViewData;
        public GreetingsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591