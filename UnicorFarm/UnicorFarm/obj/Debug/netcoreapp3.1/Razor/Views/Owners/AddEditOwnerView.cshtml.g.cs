#pragma checksum "C:\Users\admin\Desktop\UnicorFarm\UnicorFarm\Views\Owners\AddEditOwnerView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db76e61e6874bc21f80ed64c03a376b530a729ad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Owners_AddEditOwnerView), @"mvc.1.0.view", @"/Views/Owners/AddEditOwnerView.cshtml")]
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
#line 1 "C:\Users\admin\Desktop\UnicorFarm\UnicorFarm\Views\Owners\AddEditOwnerView.cshtml"
using Unicore.Services.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db76e61e6874bc21f80ed64c03a376b530a729ad", @"/Views/Owners/AddEditOwnerView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"199e62e5d3d9a88713b4b95bd67fd6196554b643", @"/Views/_ViewImports.cshtml")]
    public class Views_Owners_AddEditOwnerView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Owner>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\admin\Desktop\UnicorFarm\UnicorFarm\Views\Owners\AddEditOwnerView.cshtml"
  
    ViewData["Title"] = "AddEditOwnerView";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\admin\Desktop\UnicorFarm\UnicorFarm\Views\Owners\AddEditOwnerView.cshtml"
 if (Model.Id > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>Edit</h1>\r\n");
#nullable restore
#line 11 "C:\Users\admin\Desktop\UnicorFarm\UnicorFarm\Views\Owners\AddEditOwnerView.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>Add</h1>\r\n");
#nullable restore
#line 15 "C:\Users\admin\Desktop\UnicorFarm\UnicorFarm\Views\Owners\AddEditOwnerView.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<hr />\r\n");
#nullable restore
#line 17 "C:\Users\admin\Desktop\UnicorFarm\UnicorFarm\Views\Owners\AddEditOwnerView.cshtml"
 using (Html.BeginForm("SaveData", "Owners", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\admin\Desktop\UnicorFarm\UnicorFarm\Views\Owners\AddEditOwnerView.cshtml"
Write(Html.HiddenFor(x => x.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\">\r\n    <div class=\"row\">\r\n        ");
#nullable restore
#line 22 "C:\Users\admin\Desktop\UnicorFarm\UnicorFarm\Views\Owners\AddEditOwnerView.cshtml"
   Write(Html.TextBoxFor(x => x.Name, null, new { @class = "form-control col-md-12", @placeholder = "Owner Name" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"row\">\r\n        ");
#nullable restore
#line 25 "C:\Users\admin\Desktop\UnicorFarm\UnicorFarm\Views\Owners\AddEditOwnerView.cshtml"
   Write(Html.TextBoxFor(x => x.Mobile, null, new { @class = "form-control col-md-12", @placeholder = "Mobile" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"row\">\r\n        ");
#nullable restore
#line 28 "C:\Users\admin\Desktop\UnicorFarm\UnicorFarm\Views\Owners\AddEditOwnerView.cshtml"
   Write(Html.TextBoxFor(x => x.Email, null, new { @class = "form-control col-md-12", @placeholder = "Email" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"row\">\r\n        ");
#nullable restore
#line 31 "C:\Users\admin\Desktop\UnicorFarm\UnicorFarm\Views\Owners\AddEditOwnerView.cshtml"
   Write(Html.TextBoxFor(x => x.Address, null, new { @class = "form-control col-md-12", @placeholder = "Address" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <br />\r\n    <div class=\"row\">\r\n        <button type=\"submit\" class=\"btn btn-success col-md-3\">Submit</button>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 1084, "\"", 1111, 1);
#nullable restore
#line 36 "C:\Users\admin\Desktop\UnicorFarm\UnicorFarm\Views\Owners\AddEditOwnerView.cshtml"
WriteAttributeValue("", 1091, Url.Action("Index"), 1091, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary col-md-3 offset-1\">Cancel</a>\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 39 "C:\Users\admin\Desktop\UnicorFarm\UnicorFarm\Views\Owners\AddEditOwnerView.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Owner> Html { get; private set; }
    }
}
#pragma warning restore 1591
