#pragma checksum "C:\Users\Admin\source\repos\ZiblinWebb\Pages\DodajKlijenta.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05cdd63ce296330003870fb53c6f8886f52e3d7a"
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
#line 3 "C:\Users\Admin\source\repos\ZiblinWebb\Pages\DodajKlijenta.razor"
using ZiblinWebb.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Admin\source\repos\ZiblinWebb\Pages\DodajKlijenta.razor"
using ZiblinWebb.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/dodajKlijenta")]
    public partial class DodajKlijenta : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>DODAJ NOVOG KLIJENTA </h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<h3> Unesite podatke o klijentu</h3>\r\n\r\n<br>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(2);
            __builder.AddAttribute(3, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 17 "C:\Users\Admin\source\repos\ZiblinWebb\Pages\DodajKlijenta.razor"
                  klijent

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n\r\n    ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "form-group row");
                __builder2.AddMarkupContent(10, "\r\n        ");
                __builder2.AddMarkupContent(11, "<label for=\"txtNazivSalona\" class=\"col-sm-2 col-form-label\">Naziv salona:</label>\r\n        ");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "col-sm-10");
                __builder2.AddMarkupContent(14, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(15);
                __builder2.AddAttribute(16, "id", "txtNazivSalona");
                __builder2.AddAttribute(17, "class", "form-control");
                __builder2.AddAttribute(18, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "C:\Users\Admin\source\repos\ZiblinWebb\Pages\DodajKlijenta.razor"
                                                                              klijent.NazivSalona

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(19, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => klijent.NazivSalona = __value, klijent.NazivSalona))));
                __builder2.AddAttribute(20, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => klijent.NazivSalona));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(21, "\r\n            ");
                __Blazor.ZiblinWebb.Pages.DodajKlijenta.TypeInference.CreateValidationMessage_0(__builder2, 22, 23, 
#nullable restore
#line 24 "C:\Users\Admin\source\repos\ZiblinWebb\Pages\DodajKlijenta.razor"
                                      () => klijent.NazivSalona

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(24, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\r\n\r\n    ");
                __builder2.OpenElement(27, "div");
                __builder2.AddAttribute(28, "class", "form-group row");
                __builder2.AddMarkupContent(29, "\r\n        ");
                __builder2.AddMarkupContent(30, "<label for=\"txtVlasnikSalona\" class=\"col-sm-2 col-form-label\">Ime i prezime vlasnika:</label>\r\n        ");
                __builder2.OpenElement(31, "div");
                __builder2.AddAttribute(32, "class", "col-sm-10");
                __builder2.AddMarkupContent(33, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(34);
                __builder2.AddAttribute(35, "id", "txtVlasnikSalona");
                __builder2.AddAttribute(36, "class", "form-control");
                __builder2.AddAttribute(37, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 31 "C:\Users\Admin\source\repos\ZiblinWebb\Pages\DodajKlijenta.razor"
                                                                                klijent.Vlasnik

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(38, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => klijent.Vlasnik = __value, klijent.Vlasnik))));
                __builder2.AddAttribute(39, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => klijent.Vlasnik));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(40, "\r\n            ");
                __Blazor.ZiblinWebb.Pages.DodajKlijenta.TypeInference.CreateValidationMessage_1(__builder2, 41, 42, 
#nullable restore
#line 32 "C:\Users\Admin\source\repos\ZiblinWebb\Pages\DodajKlijenta.razor"
                                      () => klijent.Vlasnik

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(43, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "\r\n\r\n    ");
                __builder2.OpenElement(46, "div");
                __builder2.AddAttribute(47, "class", "form-group row");
                __builder2.AddMarkupContent(48, "\r\n        ");
                __builder2.AddMarkupContent(49, "<label for=\"txtAdresa\" class=\"col-sm-2 col-form-label\">Adresa salona:</label>\r\n        ");
                __builder2.OpenElement(50, "div");
                __builder2.AddAttribute(51, "class", "col-sm-10");
                __builder2.AddMarkupContent(52, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(53);
                __builder2.AddAttribute(54, "id", "txtAdresa");
                __builder2.AddAttribute(55, "class", "form-control");
                __builder2.AddAttribute(56, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 39 "C:\Users\Admin\source\repos\ZiblinWebb\Pages\DodajKlijenta.razor"
                                                                         klijent.Adresa

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(57, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => klijent.Adresa = __value, klijent.Adresa))));
                __builder2.AddAttribute(58, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => klijent.Adresa));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(59, "\r\n            ");
                __Blazor.ZiblinWebb.Pages.DodajKlijenta.TypeInference.CreateValidationMessage_2(__builder2, 60, 61, 
#nullable restore
#line 40 "C:\Users\Admin\source\repos\ZiblinWebb\Pages\DodajKlijenta.razor"
                                      () => klijent.Adresa

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(62, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(63, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(64, "\r\n\r\n    ");
                __builder2.OpenElement(65, "div");
                __builder2.AddAttribute(66, "class", "form-group row");
                __builder2.AddMarkupContent(67, "\r\n        ");
                __builder2.AddMarkupContent(68, "<label for=\"txtMjesto\" class=\"col-sm-2 col-form-label\">Mjesto:</label>\r\n        ");
                __builder2.OpenElement(69, "div");
                __builder2.AddAttribute(70, "class", "col-sm-10");
                __builder2.AddMarkupContent(71, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(72);
                __builder2.AddAttribute(73, "id", "txtMjesto");
                __builder2.AddAttribute(74, "class", "form-control");
                __builder2.AddAttribute(75, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 47 "C:\Users\Admin\source\repos\ZiblinWebb\Pages\DodajKlijenta.razor"
                                                                         klijent.Mjesto

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(76, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => klijent.Mjesto = __value, klijent.Mjesto))));
                __builder2.AddAttribute(77, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => klijent.Mjesto));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(78, "\r\n            ");
                __Blazor.ZiblinWebb.Pages.DodajKlijenta.TypeInference.CreateValidationMessage_3(__builder2, 79, 80, 
#nullable restore
#line 48 "C:\Users\Admin\source\repos\ZiblinWebb\Pages\DodajKlijenta.razor"
                                      () => klijent.Mjesto

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(81, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(82, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(83, "\r\n\r\n    ");
                __builder2.OpenElement(84, "div");
                __builder2.AddAttribute(85, "class", "form-group row");
                __builder2.AddMarkupContent(86, "\r\n        ");
                __builder2.AddMarkupContent(87, "<label for=\"txtEmail\" class=\"col-sm-2 col-form-label\">Email:</label>\r\n        ");
                __builder2.OpenElement(88, "div");
                __builder2.AddAttribute(89, "class", "col-sm-10");
                __builder2.AddMarkupContent(90, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(91);
                __builder2.AddAttribute(92, "id", "txtEmail");
                __builder2.AddAttribute(93, "class", "form-control");
                __builder2.AddAttribute(94, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 55 "C:\Users\Admin\source\repos\ZiblinWebb\Pages\DodajKlijenta.razor"
                                                                        klijent.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(95, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => klijent.Email = __value, klijent.Email))));
                __builder2.AddAttribute(96, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => klijent.Email));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(97, "\r\n            ");
                __Blazor.ZiblinWebb.Pages.DodajKlijenta.TypeInference.CreateValidationMessage_4(__builder2, 98, 99, 
#nullable restore
#line 56 "C:\Users\Admin\source\repos\ZiblinWebb\Pages\DodajKlijenta.razor"
                                      () => klijent.Email

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(100, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(101, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(102, "\r\n\r\n    ");
                __builder2.OpenElement(103, "div");
                __builder2.AddAttribute(104, "class", "form-group row");
                __builder2.AddMarkupContent(105, "\r\n        ");
                __builder2.AddMarkupContent(106, "<label for=\"txtTelefon\" class=\"col-sm-2 col-form-label\">Telefon:</label>\r\n        ");
                __builder2.OpenElement(107, "div");
                __builder2.AddAttribute(108, "class", "col-sm-10");
                __builder2.AddMarkupContent(109, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(110);
                __builder2.AddAttribute(111, "id", "txtTelefon");
                __builder2.AddAttribute(112, "class", "form-control");
                __builder2.AddAttribute(113, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 63 "C:\Users\Admin\source\repos\ZiblinWebb\Pages\DodajKlijenta.razor"
                                                                          klijent.Telefon

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(114, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => klijent.Telefon = __value, klijent.Telefon))));
                __builder2.AddAttribute(115, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => klijent.Telefon));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(116, "\r\n            ");
                __Blazor.ZiblinWebb.Pages.DodajKlijenta.TypeInference.CreateValidationMessage_5(__builder2, 117, 118, 
#nullable restore
#line 64 "C:\Users\Admin\source\repos\ZiblinWebb\Pages\DodajKlijenta.razor"
                                      () => klijent.Telefon

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(119, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(120, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(121, "\r\n\r\n    ");
                __builder2.OpenElement(122, "div");
                __builder2.AddAttribute(123, "class", "form-group row");
                __builder2.AddMarkupContent(124, "\r\n        ");
                __builder2.AddMarkupContent(125, "<label for=\"txtMobitel\" class=\"col-sm-2 col-form-label\">Mobitel:</label>\r\n        ");
                __builder2.OpenElement(126, "div");
                __builder2.AddAttribute(127, "class", "col-sm-10");
                __builder2.AddMarkupContent(128, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(129);
                __builder2.AddAttribute(130, "id", "txtMobitel");
                __builder2.AddAttribute(131, "class", "form-control");
                __builder2.AddAttribute(132, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 71 "C:\Users\Admin\source\repos\ZiblinWebb\Pages\DodajKlijenta.razor"
                                                                          klijent.Mobitel

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(133, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => klijent.Mobitel = __value, klijent.Mobitel))));
                __builder2.AddAttribute(134, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => klijent.Mobitel));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(135, "\r\n            ");
                __Blazor.ZiblinWebb.Pages.DodajKlijenta.TypeInference.CreateValidationMessage_6(__builder2, 136, 137, 
#nullable restore
#line 72 "C:\Users\Admin\source\repos\ZiblinWebb\Pages\DodajKlijenta.razor"
                                      () => klijent.Mobitel

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(138, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(139, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(140, "\r\n\r\n    ");
                __builder2.OpenElement(141, "div");
                __builder2.AddAttribute(142, "class", "checkbox checkbox-primary");
                __builder2.AddAttribute(143, "id", 
#nullable restore
#line 76 "C:\Users\Admin\source\repos\ZiblinWebb\Pages\DodajKlijenta.razor"
                                                Fb

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(144, "\r\n        ");
                __builder2.OpenElement(145, "label");
                __builder2.OpenElement(146, "input");
                __builder2.AddAttribute(147, "type", "checkbox");
                __builder2.AddAttribute(148, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 77 "C:\Users\Admin\source\repos\ZiblinWebb\Pages\DodajKlijenta.razor"
                                                   Fb

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(149, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Fb = __value, Fb));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(150, "<b> Facebook</b>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(151, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(152, "\r\n    ");
                __builder2.OpenElement(153, "div");
                __builder2.AddAttribute(154, "class", "checkbox checkbox-primary");
                __builder2.AddAttribute(155, "id", 
#nullable restore
#line 79 "C:\Users\Admin\source\repos\ZiblinWebb\Pages\DodajKlijenta.razor"
                                                Ig

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(156, "\r\n        ");
                __builder2.OpenElement(157, "label");
                __builder2.OpenElement(158, "input");
                __builder2.AddAttribute(159, "type", "checkbox");
                __builder2.AddAttribute(160, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 80 "C:\Users\Admin\source\repos\ZiblinWebb\Pages\DodajKlijenta.razor"
                                                   Ig

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(161, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Ig = __value, Ig));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(162, "<b> Instagram</b>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(163, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(164, "\r\n\r\n    ");
                __builder2.OpenElement(165, "div");
                __builder2.AddAttribute(166, "class", "form-group row");
                __builder2.AddMarkupContent(167, "\r\n        ");
                __builder2.OpenElement(168, "button");
                __builder2.AddAttribute(169, "type", "submit");
                __builder2.AddAttribute(170, "class", "btn btn-primary");
                __builder2.AddAttribute(171, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 84 "C:\Users\Admin\source\repos\ZiblinWebb\Pages\DodajKlijenta.razor"
                                                                DohvatiLokaciju

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(172, "Dohvati lokaciju");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(173, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(174, "\r\n\r\n\r\n    ");
                __builder2.OpenElement(175, "div");
                __builder2.AddAttribute(176, "class", "form-group");
                __builder2.AddMarkupContent(177, "\r\n        ");
                __builder2.OpenElement(178, "button");
                __builder2.AddAttribute(179, "type", "submit");
                __builder2.AddAttribute(180, "class", "btn btn-primary");
                __builder2.AddAttribute(181, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 89 "C:\Users\Admin\source\repos\ZiblinWebb\Pages\DodajKlijenta.razor"
                                                                Spremi

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(182, "Spremi");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(183, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(184, "\r\n\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 97 "C:\Users\Admin\source\repos\ZiblinWebb\Pages\DodajKlijenta.razor"
       

    private Klijenti klijent;
    private KlijentiService klijentiService = new KlijentiService();

    protected override void OnInitialized()
    {
        klijent = new Klijenti();
    }

    public bool Fb
    {
        get => klijent.Facebook;
        set
        {
            klijent.Facebook = Fb;
        }
    }

    public bool Ig
    {
        get => klijent.Instagram;
        set
        {
            klijent.Instagram = Ig;
        }
    }

    //Location location;

    protected async Task DohvatiLokaciju()
    {
        //location = await LocationService.GetLocationAsync();

        klijent.Latitude = 43.190155; //double.Parse(location.Latitude.ToString());
        klijent.Longitude = 17.547698; //double.Parse(location.Longitude.ToString());

        //klijent.KlijentaDodao = 5;

        klijent.SifraSalona = 12332.ToString();
        klijent.DatumDodavanja = DateTime.Now.Date;
    }


    protected async Task Spremi()
    {
        klijentiService.KreirajKlijenta(klijent);
        NavigationManager.NavigateTo("/sviKlijenti");
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
namespace __Blazor.ZiblinWebb.Pages.DodajKlijenta
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
