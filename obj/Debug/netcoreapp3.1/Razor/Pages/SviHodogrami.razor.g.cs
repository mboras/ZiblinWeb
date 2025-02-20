#pragma checksum "C:\Users\Admin\source\repos\ZiblinWebb\Pages\SviHodogrami.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ebf091f7e7f5ff909934a6e7de55a2d1b18b18c1"
// <auto-generated/>
#pragma warning disable 1591
namespace ZiblinWebb.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Admin\source\repos\ZiblinWebb\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\source\repos\ZiblinWebb\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\source\repos\ZiblinWebb\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Admin\source\repos\ZiblinWebb\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Admin\source\repos\ZiblinWebb\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Admin\source\repos\ZiblinWebb\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Admin\source\repos\ZiblinWebb\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Admin\source\repos\ZiblinWebb\_Imports.razor"
using ZiblinWebb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Admin\source\repos\ZiblinWebb\_Imports.razor"
using ZiblinWebb.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Admin\source\repos\ZiblinWebb\_Imports.razor"
using Blazored;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Admin\source\repos\ZiblinWebb\_Imports.razor"
using Blazored.Typeahead;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\source\repos\ZiblinWebb\Pages\SviHodogrami.razor"
using ZiblinWebb.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Admin\source\repos\ZiblinWebb\Pages\SviHodogrami.razor"
using ZiblinWebb.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Admin\source\repos\ZiblinWebb\Pages\SviHodogrami.razor"
using ZiblinWebb.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/sviHodogrami")]
    public partial class SviHodogrami : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>HODOGRAMI</h2>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>Prikaz svih hodograma</p>\r\n<hr>\r\n\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddMarkupContent(3, "\r\n");
#nullable restore
#line 17 "C:\Users\Admin\source\repos\ZiblinWebb\Pages\SviHodogrami.razor"
     if (StaticValues.UserId != null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "        ");
            __builder.AddMarkupContent(5, "<a class=\"btn btn-success\" href=\"/dodajHodogram\">Dodaj novi hodogram</a>\r\n");
#nullable restore
#line 21 "C:\Users\Admin\source\repos\ZiblinWebb\Pages\SviHodogrami.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n\r\n<br>\r\n\r\n");
#nullable restore
#line 26 "C:\Users\Admin\source\repos\ZiblinWebb\Pages\SviHodogrami.razor"
 if (hodogrami == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(7, "    ");
            __builder.AddMarkupContent(8, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 29 "C:\Users\Admin\source\repos\ZiblinWebb\Pages\SviHodogrami.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(9, "    ");
            __builder.OpenElement(10, "table");
            __builder.AddAttribute(11, "class", "table");
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.AddMarkupContent(13, @"<thead class=""thead-light"">
            <tr>
                <th scope=""col"">Datum</th>
                <th scope=""col"">Ostali brendovi</th>
                <th scope=""col"">Prez?</th>
                <th scope=""col"">Opis prez</th>
                <th scope=""col"">Zain?</th>
                <th scope=""col"">Brošure?</th>
                <th scope=""col"">Broš/Nijan</th>
                <th scope=""col"">Napomene</th>
                <th scope=""col"">Zaključak</th>
                <th scope=""col"">Akcije</th>
            </tr>
        </thead>
        ");
            __builder.OpenElement(14, "tbody");
            __builder.AddMarkupContent(15, "\r\n");
#nullable restore
#line 50 "C:\Users\Admin\source\repos\ZiblinWebb\Pages\SviHodogrami.razor"
             foreach (var hodogram in hodogrami)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(16, "                ");
            __builder.OpenElement(17, "tr");
            __builder.AddMarkupContent(18, "\r\n                    ");
            __builder.OpenElement(19, "td");
            __builder.AddAttribute(20, "scope", "row");
            __builder.AddContent(21, 
#nullable restore
#line 55 "C:\Users\Admin\source\repos\ZiblinWebb\Pages\SviHodogrami.razor"
                                     hodogram.Datum.ToShortTimeString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                    ");
            __builder.OpenElement(23, "td");
            __builder.AddAttribute(24, "scope", "row");
            __builder.AddContent(25, 
#nullable restore
#line 56 "C:\Users\Admin\source\repos\ZiblinWebb\Pages\SviHodogrami.razor"
                                     hodogram.OstaliBrendovi

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                    ");
            __builder.OpenElement(27, "td");
            __builder.AddAttribute(28, "scope", "row");
            __builder.AddContent(29, 
#nullable restore
#line 57 "C:\Users\Admin\source\repos\ZiblinWebb\Pages\SviHodogrami.razor"
                                     hodogram.KratkaPrezentacija

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                    ");
            __builder.OpenElement(31, "td");
            __builder.AddAttribute(32, "scope", "row");
            __builder.AddContent(33, 
#nullable restore
#line 58 "C:\Users\Admin\source\repos\ZiblinWebb\Pages\SviHodogrami.razor"
                                     hodogram.OpisPrezentacije

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                    ");
            __builder.OpenElement(35, "td");
            __builder.AddAttribute(36, "scope", "row");
            __builder.AddContent(37, 
#nullable restore
#line 59 "C:\Users\Admin\source\repos\ZiblinWebb\Pages\SviHodogrami.razor"
                                     hodogram.ZainteresiraniZaProizvode

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                    ");
            __builder.OpenElement(39, "td");
            __builder.AddAttribute(40, "scope", "row");
            __builder.AddContent(41, 
#nullable restore
#line 60 "C:\Users\Admin\source\repos\ZiblinWebb\Pages\SviHodogrami.razor"
                                     hodogram.OstavljeneBrosure

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                    ");
            __builder.OpenElement(43, "td");
            __builder.AddAttribute(44, "scope", "row");
            __builder.AddContent(45, 
#nullable restore
#line 61 "C:\Users\Admin\source\repos\ZiblinWebb\Pages\SviHodogrami.razor"
                                     hodogram.BrosureNijanseri

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n                    ");
            __builder.OpenElement(47, "td");
            __builder.AddAttribute(48, "scope", "row");
            __builder.AddContent(49, 
#nullable restore
#line 62 "C:\Users\Admin\source\repos\ZiblinWebb\Pages\SviHodogrami.razor"
                                     hodogram.Napomene

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n                    ");
            __builder.OpenElement(51, "td");
            __builder.AddAttribute(52, "scope", "row");
            __builder.AddContent(53, 
#nullable restore
#line 63 "C:\Users\Admin\source\repos\ZiblinWebb\Pages\SviHodogrami.razor"
                                     hodogram.Zakljucak

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n\r\n                    ");
            __builder.OpenElement(55, "td");
            __builder.AddAttribute(56, "scope", "row");
            __builder.AddMarkupContent(57, "\r\n                        ");
            __builder.OpenElement(58, "a");
            __builder.AddAttribute(59, "class", "btn btn-primary");
            __builder.AddAttribute(60, "href", "/urediHodogram/" + (
#nullable restore
#line 66 "C:\Users\Admin\source\repos\ZiblinWebb\Pages\SviHodogrami.razor"
                                                                         hodogram.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(61, "Edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n                        ");
            __builder.OpenElement(63, "a");
            __builder.AddAttribute(64, "class", "btn btn-danger");
            __builder.AddAttribute(65, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 67 "C:\Users\Admin\source\repos\ZiblinWebb\Pages\SviHodogrami.razor"
                                                            () => IzbrisiKorisnika(hodogram)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(66, "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n");
#nullable restore
#line 70 "C:\Users\Admin\source\repos\ZiblinWebb\Pages\SviHodogrami.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(70, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n");
#nullable restore
#line 73 "C:\Users\Admin\source\repos\ZiblinWebb\Pages\SviHodogrami.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 75 "C:\Users\Admin\source\repos\ZiblinWebb\Pages\SviHodogrami.razor"
       

    private List<Hodogrami> hodogrami = new List<Hodogrami>();
    private HodogramiService hodogramiService = new HodogramiService();
    //private KorisniciService korisniciService = new KorisniciService();
    private KlijentiService klijentiService = new KlijentiService();


    protected override async Task OnInitializedAsync()
    {
        hodogrami = hodogramiService.DohvatiHodogrameKorisnika(StaticValues.UserId);
    }

    private async Task IzbrisiKorisnika(Hodogrami hodogram)
    {
        hodogramiService.DeleteHodogram(hodogram);
        await OnInitializedAsync();
    }






















#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
