#pragma checksum "C:\code\StrategicFS\StrategicFS Code Test\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e7961290aedb8b3342ae1343f323d72f996ede52"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(StrategicFS_Code_Test.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace StrategicFS_Code_Test.Pages
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
#line 1 "C:\code\StrategicFS\StrategicFS Code Test\Pages\_ViewImports.cshtml"
using StrategicFS_Code_Test;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7961290aedb8b3342ae1343f323d72f996ede52", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"977973283bad99f543771416ff2ab519c1abd245", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "AddItem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\code\StrategicFS\StrategicFS Code Test\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""text-center"">
    <h1 class=""display-4"">StrategicFS Code Test</h1>
    <h3>Credit Account Information</h3>

    <table class=""tbl-spaced"">
        <thead>
            <tr class=""header"">
                <td class=""selection"">
                    <input type=""checkbox"" checked id=""select_all"" />
                </td>
                <td class=""left"">Creditor</td>
                <td class=""left"">First Name</td>
                <td class=""left"">Last Name</td>
                <td class=""right"">Min Pay %</td>
                <td class=""right"">Balance</td>
            </tr>
        </thead>
        <tbody class=""table_data"">
");
#nullable restore
#line 24 "C:\code\StrategicFS\StrategicFS Code Test\Pages\Index.cshtml"
             foreach (var item in Model.CreditAccountInfo)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr class=\"data-row\">\r\n                    <td class=\"selection\">");
#nullable restore
#line 27 "C:\code\StrategicFS\StrategicFS Code Test\Pages\Index.cshtml"
                                     Write(Html.CheckBoxFor(m => item.IsSelected, new[] { "name", "'isSelected'" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"left\">");
#nullable restore
#line 28 "C:\code\StrategicFS\StrategicFS Code Test\Pages\Index.cshtml"
                                Write(Html.DisplayTextFor(m => item.CreditorName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"left\">");
#nullable restore
#line 29 "C:\code\StrategicFS\StrategicFS Code Test\Pages\Index.cshtml"
                                Write(Html.DisplayTextFor(m => item.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"left\">");
#nullable restore
#line 30 "C:\code\StrategicFS\StrategicFS Code Test\Pages\Index.cshtml"
                                Write(Html.DisplayTextFor(m => item.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"right\">");
#nullable restore
#line 31 "C:\code\StrategicFS\StrategicFS Code Test\Pages\Index.cshtml"
                                 Write(Html.DisplayTextFor(m => item.MinPaymentPercentage));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"right\">");
#nullable restore
#line 32 "C:\code\StrategicFS\StrategicFS Code Test\Pages\Index.cshtml"
                                 Write(Html.DisplayTextFor(m => item.Balance));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 34 "C:\code\StrategicFS\StrategicFS Code Test\Pages\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr class=\"control-row\">\r\n            <td class=\"cmd-btn\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e7961290aedb8b3342ae1343f323d72f996ede526511", async() => {
                WriteLiteral("Add Debt");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.PageHandler = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </td>\r\n\r\n\r\n        </tr>\r\n        <tr class=\"total-row\">\r\n        </tr>\r\n        <tr class=\"summary-row\">\r\n        </tr>\r\n        </tbody>\r\n    </table>\r\n</div>\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script type=""text/javascript"">
        $(function () {
            $('#select_all').change(function () {
                var isChecked = $(this)[0].checked;
                $('tbody.table_data').find('input[type=""checkbox""]').prop('checked', isChecked);
            });
        }
        );</script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
