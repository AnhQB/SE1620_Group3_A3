#pragma checksum "D:\ki_5_2022,may\PRN211\Learn\SE1620_Group3_A3\SE1620_GROUP3_ASS3\Views\Bookings\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2fc2ae696b0247d42e45759a936ea484ee1b72d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Bookings_Edit), @"mvc.1.0.view", @"/Views/Bookings/Edit.cshtml")]
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
#line 1 "D:\ki_5_2022,may\PRN211\Learn\SE1620_Group3_A3\SE1620_GROUP3_ASS3\Views\_ViewImports.cshtml"
using SE1620_GROUP3_ASS3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ki_5_2022,may\PRN211\Learn\SE1620_Group3_A3\SE1620_GROUP3_ASS3\Views\_ViewImports.cshtml"
using SE1620_GROUP3_ASS3.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\ki_5_2022,may\PRN211\Learn\SE1620_Group3_A3\SE1620_GROUP3_ASS3\Views\Bookings\Edit.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2fc2ae696b0247d42e45759a936ea484ee1b72d", @"/Views/Bookings/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c298efd8c4af8a63d2a882df8a67638ac1779bc1", @"/Views/_ViewImports.cshtml")]
    public class Views_Bookings_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SE1620_GROUP3_ASS3.Models.Booking>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "D:\ki_5_2022,may\PRN211\Learn\SE1620_Group3_A3\SE1620_GROUP3_ASS3\Views\Bookings\Edit.cshtml"
      
        ViewData["Title"] = "Edit";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <h1>Create</h1>\r\n\r\n    <h5>Booking</h5>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f2fc2ae696b0247d42e45759a936ea484ee1b72d4098", async() => {
                WriteLiteral("\r\n        <input type=\"hidden\" name=\"bookingid\"");
                BeginWriteAttribute("value", " value=\"", 319, "\"", 353, 1);
#nullable restore
#line 12 "D:\ki_5_2022,may\PRN211\Learn\SE1620_Group3_A3\SE1620_GROUP3_ASS3\Views\Bookings\Edit.cshtml"
WriteAttributeValue("", 327, ViewBag.booking.BookingId, 327, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        <input type=\"hidden\" name=\"showid\"");
                BeginWriteAttribute("value", " value=\"", 401, "\"", 432, 1);
#nullable restore
#line 13 "D:\ki_5_2022,may\PRN211\Learn\SE1620_Group3_A3\SE1620_GROUP3_ASS3\Views\Bookings\Edit.cshtml"
WriteAttributeValue("", 409, ViewBag.booking.ShowId, 409, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
#nullable restore
#line 14 "D:\ki_5_2022,may\PRN211\Learn\SE1620_Group3_A3\SE1620_GROUP3_ASS3\Views\Bookings\Edit.cshtml"
          
            bool[] arr = ViewBag.seatsStatus;
            for (var n = 0; n < 10; n++)
            {
                //int n = 0;
                for (var m = 0; m < 10; m++)
                {
                    int index = n * 10 + m;
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "D:\ki_5_2022,may\PRN211\Learn\SE1620_Group3_A3\SE1620_GROUP3_ASS3\Views\Bookings\Edit.cshtml"
                     if (arr[index] == true)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <input");
                BeginWriteAttribute("name", " name=\"", 793, "\"", 806, 1);
#nullable restore
#line 24 "D:\ki_5_2022,may\PRN211\Learn\SE1620_Group3_A3\SE1620_GROUP3_ASS3\Views\Bookings\Edit.cshtml"
WriteAttributeValue("", 800, index, 800, 6, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"checkbox\" checked onclick=\"increaseAmount(this)\" />\r\n");
#nullable restore
#line 25 "D:\ki_5_2022,may\PRN211\Learn\SE1620_Group3_A3\SE1620_GROUP3_ASS3\Views\Bookings\Edit.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <input");
                BeginWriteAttribute("name", " name=\"", 969, "\"", 982, 1);
#nullable restore
#line 28 "D:\ki_5_2022,may\PRN211\Learn\SE1620_Group3_A3\SE1620_GROUP3_ASS3\Views\Bookings\Edit.cshtml"
WriteAttributeValue("", 976, index, 976, 6, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"checkbox\" onclick=\"increaseAmount(this)\" />\r\n");
#nullable restore
#line 29 "D:\ki_5_2022,may\PRN211\Learn\SE1620_Group3_A3\SE1620_GROUP3_ASS3\Views\Bookings\Edit.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "D:\ki_5_2022,may\PRN211\Learn\SE1620_Group3_A3\SE1620_GROUP3_ASS3\Views\Bookings\Edit.cshtml"
                     


                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                <br />\r\n");
#nullable restore
#line 34 "D:\ki_5_2022,may\PRN211\Learn\SE1620_Group3_A3\SE1620_GROUP3_ASS3\Views\Bookings\Edit.cshtml"
            }
        

#line default
#line hidden
#nullable disable
                WriteLiteral("        Name <br>\r\n        <input type=\"text\" name=\"name\"");
                BeginWriteAttribute("value", " value=\"", 1188, "\"", 1217, 1);
#nullable restore
#line 37 "D:\ki_5_2022,may\PRN211\Learn\SE1620_Group3_A3\SE1620_GROUP3_ASS3\Views\Bookings\Edit.cshtml"
WriteAttributeValue("", 1196, ViewBag.booking.Name, 1196, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        <br>\r\n        Amount <br>\r\n        <input style=\"background-color: aquamarine\" id=\"amountAuto\" type=\"text\" name=\"amount\"");
                BeginWriteAttribute("value", " value=\"", 1351, "\"", 1382, 1);
#nullable restore
#line 40 "D:\ki_5_2022,may\PRN211\Learn\SE1620_Group3_A3\SE1620_GROUP3_ASS3\Views\Bookings\Edit.cshtml"
WriteAttributeValue("", 1359, ViewBag.booking.Amount, 1359, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" readonly />\r\n        <br>\r\n        <button class=\"btn btn-primary\">Save</button>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    <a");
            BeginWriteAttribute("href", " href=\"", 1485, "\"", 1554, 1);
#nullable restore
#line 44 "D:\ki_5_2022,may\PRN211\Learn\SE1620_Group3_A3\SE1620_GROUP3_ASS3\Views\Bookings\Edit.cshtml"
WriteAttributeValue("", 1492, Url.Action("Index","Bookings", new { ViewBag.booking.ShowId}), 1492, 62, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">Back to List</a>

    <script>

        const boolArray = [];
        function increaseAmount(i) {
            let amountAuto = document.getElementById(""amountAuto"").value;
            console.log(i.checked);

            if (i.checked) {
                amountAuto = parseInt(amountAuto) + 10;
            } else {
                if (amountAuto > 0 && boolArray[i.name] == true) {
                    amountAuto = parseInt(amountAuto) - 10;
                }
            }
            boolArray[i.name] = i.checked;

            //console.log(amountAuto);
            document.getElementById(""amountAuto"").setAttribute('value', amountAuto);
        }
    </script>



");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHttpContextAccessor HttpContextAccessor { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SE1620_GROUP3_ASS3.Models.Booking>> Html { get; private set; }
    }
}
#pragma warning restore 1591
