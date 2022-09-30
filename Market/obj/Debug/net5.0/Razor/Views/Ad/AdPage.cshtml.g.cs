#pragma checksum "C:\Users\anvah\source\repos\Market\Market\Views\Ad\AdPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "84717b50056ae223b28c70e13c30db757595d328"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ad_AdPage), @"mvc.1.0.view", @"/Views/Ad/AdPage.cshtml")]
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
#line 1 "C:\Users\anvah\source\repos\Market\Market\Views\_ViewImports.cshtml"
using Market;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84717b50056ae223b28c70e13c30db757595d328", @"/Views/Ad/AdPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"922275eefe983be585cb7889b8c9e8836d404394", @"/Views/_ViewImports.cshtml")]
    public class Views_Ad_AdPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Market.Models.Ad>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "84717b50056ae223b28c70e13c30db757595d3283901", async() => {
                WriteLiteral(@"
    <title>Магазин</title>
    <link rel=""shortcut icon"" href=""https://opencagedata.com/favicon.ico"" type=""image/x-icon"">

    <meta name='viewport' content='width=device-width, user-scalable=no initial-scale=1, maximum-scale=1'>
    <meta charset=""utf-8"">
    <link rel=""stylesheet"" href=""https://unpkg.com/leaflet@1.7.1/dist/leaflet.css"" />
    <link rel=""stylesheet""
          href=""https://cdn.jsdelivr.net/gh/opencagedata/leaflet-opencage-geocoding@v2.0.0/dist/css/L.Control.OpenCageGeocoding.min.css"" />

    <script src=""https://unpkg.com/leaflet@1.7.1/dist/leaflet.js""></script>
    <script src=""https://cdn.jsdelivr.net/gh/opencagedata/leaflet-opencage-geocoding@v2.0.0/dist/js/L.Control.OpenCageGeocoding.min.js""></script>

    <style type=""text/css"">
        body {
            margin: 0;
        }

        #map {
            top: 0;
            bottom: 0;
            left: 0;
            right: 0;
            height: 480px;
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "84717b50056ae223b28c70e13c30db757595d3285875", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "84717b50056ae223b28c70e13c30db757595d3286137", async() => {
                    WriteLiteral("\r\n        <div class=\"container\">\r\n            <div class=\"row\">\r\n                <div class=\"col\">\r\n                    <h1>");
#nullable restore
#line 36 "C:\Users\anvah\source\repos\Market\Market\Views\Ad\AdPage.cshtml"
                   Write(Model.Name);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</h1>\r\n                    <p><img");
                    BeginWriteAttribute("src", " src=\"", 1275, "\"", 1306, 1);
#nullable restore
#line 37 "C:\Users\anvah\source\repos\Market\Market\Views\Ad\AdPage.cshtml"
WriteAttributeValue("", 1281, Url.Content(Model.Image), 1281, 25, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" width=\"30%\" height=\"30%\"></p>\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"col\">\r\n                    <h1>Цена: ");
#nullable restore
#line 42 "C:\Users\anvah\source\repos\Market\Market\Views\Ad\AdPage.cshtml"
                         Write(String.Format("{0:C}", Model.Price));

#line default
#line hidden
#nullable disable
                    WriteLiteral("</h1>\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <h1>Контактная информация:</h1>\r\n                <h2> Имя: ");
#nullable restore
#line 47 "C:\Users\anvah\source\repos\Market\Market\Views\Ad\AdPage.cshtml"
                     Write(Model.User.Name);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</h2>\r\n                <div class=\"col\">\r\n                    <h2>Email</h2>\r\n                    <p>");
#nullable restore
#line 50 "C:\Users\anvah\source\repos\Market\Market\Views\Ad\AdPage.cshtml"
                  Write(Model.User.Email);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</p>\r\n                </div>\r\n                <div class=\"col\">\r\n                    <h2>Телефон</h2>\r\n                    <p>");
#nullable restore
#line 54 "C:\Users\anvah\source\repos\Market\Market\Views\Ad\AdPage.cshtml"
                  Write(Model.User.Phone);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</p>\r\n                </div>\r\n                <div class=\"col\">\r\n                    <h2>Город</h2>\r\n                    <p>");
#nullable restore
#line 58 "C:\Users\anvah\source\repos\Market\Market\Views\Ad\AdPage.cshtml"
                  Write(Model.City);

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"</p>
                </div>
            </div>
            <div class=""row"">
                <div class=""col"">
                    <div id=""map""></div>
                </div>
               
            </div>
        </div>
       

        <script type=""text/javascript"">
            var map = L.map('map').setView([55.7522, 37.6156], 13);
            var options = {
                key: '3c38d15e76c02545181b07d3f8cfccf0', // REPLACE WITH YOUR API-KEY. This key might go away any time!
                limit: 10
            };
            var geocoder = L.Control.OpenCageGeocoding.geocoder(options);
            var control = L.Control.openCageGeocoding(options).addTo(map);
            var marker;

            /*L.tileLayer('https://{s}.tile.osm.org/{z}/{x}/{y}.png', {
              attribution: '&copy; <a href=""https://osm.org/copyright"">OpenStreetMap</a> contributors'
            }).addTo(map);*/

            L.tileLayer('https://{s}.tile.thunderforest.com/atlas/{z}/{x}/{y}{r}.png?api");
                    WriteLiteral(@"key=224e9cefe709416d953c7c9177ef3ff7', {
                attribution: 'Data <a href=""https://www.openstreetmap.org/copyright"" target=""_blank"">OpenStreetMap</a> contributors, Map tiles &copy; <a href=""https://www.thunderforest.com/"">Thunderforest</a>',
                minZoom: 4,
                maxZoom: 18
            }).addTo(map);

            map.on('click', function (e) {
                var query = e.latlng.lat.toString() + ',' + e.latlng.lng.toString();
                geocoder.geocode(query, function (results) {
                    var r = results[0];
                    if (r) {
                        if (marker) {
                            marker.setLatLng(r.center).setPopupContent(r.name).openPopup();
                        } else {
                            marker = L.marker(r.center).bindPopup(r.name).addTo(map).openPopup();
                        }
                    }
                })
            })
        </script>
    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Market.Models.Ad> Html { get; private set; }
    }
}
#pragma warning restore 1591