#pragma checksum "C:\Git_Repo\DotNet\Linq\Linq\Views\Home\DisplayMaleData.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a8b1efa9be580d155468b8d09330364aba0f1bb9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_DisplayMaleData), @"mvc.1.0.view", @"/Views/Home/DisplayMaleData.cshtml")]
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
#line 1 "C:\Git_Repo\DotNet\Linq\Linq\Views\_ViewImports.cshtml"
using Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Git_Repo\DotNet\Linq\Linq\Views\_ViewImports.cshtml"
using Linq.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8b1efa9be580d155468b8d09330364aba0f1bb9", @"/Views/Home/DisplayMaleData.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d8b82cba3eb567e47c0ebdf89361814a8997e6d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_DisplayMaleData : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EmployeeModel>>
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
            WriteLiteral("\r\n\r\n    <!DOCTYPE html>\r\n    <html>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a8b1efa9be580d155468b8d09330364aba0f1bb93236", async() => {
                WriteLiteral(@"
        <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
        <style>
            table {
                border-collapse: collapse;
                border-spacing: 0;
                width: 100%;
                border: 1px solid #ddd;
            }

            th, td {
                text-align: left;
                padding: 8px;
            }

            tr:nth-child(even) {
                background-color: #f2f2f2
            }
        </style>
    ");
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
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a8b1efa9be580d155468b8d09330364aba0f1bb94712", async() => {
                WriteLiteral("\r\n\r\n        <h2>number of male records=");
#nullable restore
#line 28 "C:\Git_Repo\DotNet\Linq\Linq\Views\Home\DisplayMaleData.cshtml"
                              Write(Model.Count());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h2>
        <p>If you have a table that is too wide, you can add a container element with overflow-x:auto around the table, and it will display a horizontal scroll bar when needed.</p>
        <p>Resize the browser window to see the effect. Try to remove the div element and see what happens to the table.</p>

        <div style=""overflow-x:auto;"">
            <table>

");
#nullable restore
#line 35 "C:\Git_Repo\DotNet\Linq\Linq\Views\Home\DisplayMaleData.cshtml"
                 for (int i = 0; i < @Model.Count(); i++)
                {
                    

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <tr>\r\n                            <th>");
#nullable restore
#line 39 "C:\Git_Repo\DotNet\Linq\Linq\Views\Home\DisplayMaleData.cshtml"
                           Write(Model.ToList()[i].empno);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                            <th>");
#nullable restore
#line 40 "C:\Git_Repo\DotNet\Linq\Linq\Views\Home\DisplayMaleData.cshtml"
                           Write(Model.ToList()[i].first_name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                            <th>");
#nullable restore
#line 41 "C:\Git_Repo\DotNet\Linq\Linq\Views\Home\DisplayMaleData.cshtml"
                           Write(Model.ToList()[i].last_name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                            <th>");
#nullable restore
#line 42 "C:\Git_Repo\DotNet\Linq\Linq\Views\Home\DisplayMaleData.cshtml"
                           Write(Model.ToList()[i].gender);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                            <th>");
#nullable restore
#line 43 "C:\Git_Repo\DotNet\Linq\Linq\Views\Home\DisplayMaleData.cshtml"
                           Write(Model.ToList()[i].hire_date);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                            <th>");
#nullable restore
#line 44 "C:\Git_Repo\DotNet\Linq\Linq\Views\Home\DisplayMaleData.cshtml"
                           Write(Model.ToList()[i].birthdate);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                        </tr>\r\n");
#nullable restore
#line 46 "C:\Git_Repo\DotNet\Linq\Linq\Views\Home\DisplayMaleData.cshtml"

                    
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </table>\r\n        </div>\r\n\r\n    ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EmployeeModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
