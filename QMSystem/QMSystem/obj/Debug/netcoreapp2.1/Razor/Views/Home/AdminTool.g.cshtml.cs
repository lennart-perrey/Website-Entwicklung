#pragma checksum "C:\Users\Marcel\Documents\WPM\Website-Entwicklung\QMSystem\QMSystem\Views\Home\AdminTool.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c02904682a50c3aaf94dc3525d1570773cacdf7a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AdminTool), @"mvc.1.0.view", @"/Views/Home/AdminTool.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/AdminTool.cshtml", typeof(AspNetCore.Views_Home_AdminTool))]
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
#line 1 "C:\Users\Marcel\Documents\WPM\Website-Entwicklung\QMSystem\QMSystem\Views\_ViewImports.cshtml"
using QMSystem;

#line default
#line hidden
#line 2 "C:\Users\Marcel\Documents\WPM\Website-Entwicklung\QMSystem\QMSystem\Views\_ViewImports.cshtml"
using QMSystem.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c02904682a50c3aaf94dc3525d1570773cacdf7a", @"/Views/Home/AdminTool.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2835d0fb51788698076eafcc556569c432560e7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_AdminTool : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<QMSystem.Models.Documents>>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(40, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 4 "C:\Users\Marcel\Documents\WPM\Website-Entwicklung\QMSystem\QMSystem\Views\Home\AdminTool.cshtml"
  
    ViewData["Title"] = "AdminTool";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(136, 230, true);
            WriteLiteral("\r\n<style>\r\n\r\n    td, th {\r\n        border: 1px solid #dddddd;\r\n        text-align: left;\r\n        padding: 8px;\r\n    }\r\n\r\n    tr:nth-child(even) {\r\n        background-color: #dddddd;\r\n    }\r\n</style>\r\n\r\n<h2>Änderungsanträge</h2>\r\n");
            EndContext();
            BeginContext(366, 1448, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c81047282d0040019b388994dd741141", async() => {
                BeginContext(372, 371, true);
                WriteLiteral(@"
    <table style=""font-family: arial, sans-serif; border-collapse: collapse; width: 100%;"">

        <tr>
            <th>Dokumentname</th>
            <th>Dokumentpfad</th>
            <th>Antragsdatum</th>
            <th>Antragsteller</th>
            <th>Betreff</th>
            <th>Beschreibung</th>
            <th>Freigabestatus</th>
        </tr>

");
                EndContext();
#line 36 "C:\Users\Marcel\Documents\WPM\Website-Entwicklung\QMSystem\QMSystem\Views\Home\AdminTool.cshtml"
         foreach (Documents document in Model)
        {

#line default
#line hidden
                BeginContext(802, 60, true);
                WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(863, 21, false);
#line 40 "C:\Users\Marcel\Documents\WPM\Website-Entwicklung\QMSystem\QMSystem\Views\Home\AdminTool.cshtml"
               Write(document.DocumentName);

#line default
#line hidden
                EndContext();
                BeginContext(884, 69, true);
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 953, "\"", 982, 1);
#line 43 "C:\Users\Marcel\Documents\WPM\Website-Entwicklung\QMSystem\QMSystem\Views\Home\AdminTool.cshtml"
WriteAttributeValue("", 960, document.DocumentPath, 960, 22, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(983, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(985, 21, false);
#line 43 "C:\Users\Marcel\Documents\WPM\Website-Entwicklung\QMSystem\QMSystem\Views\Home\AdminTool.cshtml"
                                                Write(document.DocumentPath);

#line default
#line hidden
                EndContext();
                BeginContext(1006, 71, true);
                WriteLiteral("</a>\r\n                </td>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(1078, 20, false);
#line 46 "C:\Users\Marcel\Documents\WPM\Website-Entwicklung\QMSystem\QMSystem\Views\Home\AdminTool.cshtml"
               Write(document.RequestDate);

#line default
#line hidden
                EndContext();
                BeginContext(1098, 67, true);
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(1166, 17, false);
#line 49 "C:\Users\Marcel\Documents\WPM\Website-Entwicklung\QMSystem\QMSystem\Views\Home\AdminTool.cshtml"
               Write(document.UserName);

#line default
#line hidden
                EndContext();
                BeginContext(1183, 67, true);
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(1251, 16, false);
#line 52 "C:\Users\Marcel\Documents\WPM\Website-Entwicklung\QMSystem\QMSystem\Views\Home\AdminTool.cshtml"
               Write(document.Betreff);

#line default
#line hidden
                EndContext();
                BeginContext(1267, 67, true);
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(1335, 20, false);
#line 55 "C:\Users\Marcel\Documents\WPM\Website-Entwicklung\QMSystem\QMSystem\Views\Home\AdminTool.cshtml"
               Write(document.Anmerkungen);

#line default
#line hidden
                EndContext();
                BeginContext(1355, 148, true);
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <select class=\"form-control\" id=\"Status\" name=\"Status\">\r\n                        ");
                EndContext();
                BeginContext(1503, 34, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aee5d27495114e05a83c9303b4bbebb5", async() => {
                    BeginContext(1511, 17, true);
                    WriteLiteral("Nicht freigegeben");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1537, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
                BeginContext(1563, 33, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a6407e891bc944649ff0b720031622ac", async() => {
                    BeginContext(1571, 16, true);
                    WriteLiteral("Direkte Freigabe");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1596, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
                BeginContext(1622, 33, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a456b4cc17e545beb7bd32a21b7b2439", async() => {
                    BeginContext(1630, 16, true);
                    WriteLiteral("Weitergabe an GF");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1655, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
                BeginContext(1681, 26, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8436ccf873b6490588a021b6cd89b97b", async() => {
                    BeginContext(1689, 9, true);
                    WriteLiteral("Abgelehnt");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1707, 75, true);
                WriteLiteral("\r\n                    </select>\r\n                </td>\r\n            </tr>\r\n");
                EndContext();
#line 66 "C:\Users\Marcel\Documents\WPM\Website-Entwicklung\QMSystem\QMSystem\Views\Home\AdminTool.cshtml"
        }

#line default
#line hidden
                BeginContext(1793, 14, true);
                WriteLiteral("    </table>\r\n");
                EndContext();
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
            EndContext();
            BeginContext(1814, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<QMSystem.Models.Documents>> Html { get; private set; }
    }
}
#pragma warning restore 1591
