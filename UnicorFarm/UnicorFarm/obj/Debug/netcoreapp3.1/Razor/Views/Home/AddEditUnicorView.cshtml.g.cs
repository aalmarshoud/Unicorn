#pragma checksum "C:\Users\admin\Desktop\UnicorFarm\UnicorFarm\Views\Home\AddEditUnicorView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f85f22bfe4f2ef60795cface8b939a2c42e98293"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AddEditUnicorView), @"mvc.1.0.view", @"/Views/Home/AddEditUnicorView.cshtml")]
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
#line 1 "C:\Users\admin\Desktop\UnicorFarm\UnicorFarm\Views\_ViewImports.cshtml"
using UnicorFarm;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\admin\Desktop\UnicorFarm\UnicorFarm\Views\_ViewImports.cshtml"
using UnicorFarm.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\admin\Desktop\UnicorFarm\UnicorFarm\Views\Home\AddEditUnicorView.cshtml"
using Unicore.Services.Dtos;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f85f22bfe4f2ef60795cface8b939a2c42e98293", @"/Views/Home/AddEditUnicorView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"199e62e5d3d9a88713b4b95bd67fd6196554b643", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_AddEditUnicorView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UnicoreInfoVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\admin\Desktop\UnicorFarm\UnicorFarm\Views\Home\AddEditUnicorView.cshtml"
  
    ViewData["Title"] = "AddEditUnicorView";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\admin\Desktop\UnicorFarm\UnicorFarm\Views\Home\AddEditUnicorView.cshtml"
 if (Model.ID > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>Edit</h1>\r\n");
#nullable restore
#line 11 "C:\Users\admin\Desktop\UnicorFarm\UnicorFarm\Views\Home\AddEditUnicorView.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>Add</h1>\r\n");
#nullable restore
#line 15 "C:\Users\admin\Desktop\UnicorFarm\UnicorFarm\Views\Home\AddEditUnicorView.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<hr />\r\n");
#nullable restore
#line 17 "C:\Users\admin\Desktop\UnicorFarm\UnicorFarm\Views\Home\AddEditUnicorView.cshtml"
 using (Html.BeginForm("SaveData", "Home",FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\admin\Desktop\UnicorFarm\UnicorFarm\Views\Home\AddEditUnicorView.cshtml"
Write(Html.HiddenFor(x => x.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container\">\r\n        <div class=\"row\">\r\n            ");
#nullable restore
#line 22 "C:\Users\admin\Desktop\UnicorFarm\UnicorFarm\Views\Home\AddEditUnicorView.cshtml"
       Write(Html.TextBoxFor(x => x.UnicoreName, null, new { @class = "form-control col-md-12", @placeholder = "Unicore Name" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"row\">\r\n            ");
#nullable restore
#line 25 "C:\Users\admin\Desktop\UnicorFarm\UnicorFarm\Views\Home\AddEditUnicorView.cshtml"
       Write(Html.TextBoxFor(x => x.UnicoreDescription, null, new { @class = "form-control col-md-12", @placeholder = "Unicore Description" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"row\">\r\n            ");
#nullable restore
#line 28 "C:\Users\admin\Desktop\UnicorFarm\UnicorFarm\Views\Home\AddEditUnicorView.cshtml"
       Write(Html.DropDownListFor(x => x.OwnerId,new SelectList(ViewBag.Owners,"Value","Text"), "select Owner",new {@class="form-control col-md-12" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <br />\r\n        <div class=\"row\">\r\n            <button type=\"submit\" class=\"btn btn-success col-md-3\">Submit</button>\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 1059, "\"", 1086, 1);
#nullable restore
#line 33 "C:\Users\admin\Desktop\UnicorFarm\UnicorFarm\Views\Home\AddEditUnicorView.cshtml"
WriteAttributeValue("", 1066, Url.Action("Index"), 1066, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary col-md-3 offset-1\">Cancel</a>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 36 "C:\Users\admin\Desktop\UnicorFarm\UnicorFarm\Views\Home\AddEditUnicorView.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UnicoreInfoVM> Html { get; private set; }
    }
}
#pragma warning restore 1591