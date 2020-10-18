#pragma checksum "/Users/matia/Stacc/Pages/FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e9b88290a9d90b1b53e32ed27a521c700a889b28"
// <auto-generated/>
#pragma warning disable 1591
namespace Stacc.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/matia/Stacc/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/matia/Stacc/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/matia/Stacc/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/matia/Stacc/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/matia/Stacc/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/matia/Stacc/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/matia/Stacc/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/matia/Stacc/_Imports.razor"
using Stacc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/matia/Stacc/_Imports.razor"
using Stacc.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/matia/Stacc/Pages/FetchData.razor"
using Stacc.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/matia/Stacc/Pages/FetchData.razor"
using C1.Chart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/matia/Stacc/Pages/FetchData.razor"
using C1.Blazor.Chart;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Graf</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>This graph shows value of account by date </p>\r\n");
#nullable restore
#line 10 "/Users/matia/Stacc/Pages/FetchData.razor"
    List<Models.AccountView> acc = Program.accountView; 

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Stacc.Pages.Dropdown<string>>(2);
            __builder.AddAttribute(3, "OnSelected", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<string>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<string>(this, 
#nullable restore
#line 11 "/Users/matia/Stacc/Pages/FetchData.razor"
                                      OnSelected

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "InitialTip", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(5, "Choose account");
            }
            ));
            __builder.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(7, "\r\n");
#nullable restore
#line 14 "/Users/matia/Stacc/Pages/FetchData.razor"
         foreach (var acc1 in acc)
        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(8, "            ");
                __Blazor.Stacc.Pages.FetchData.TypeInference.CreateDropdownListItem_0(__builder2, 9, 10, 
#nullable restore
#line 16 "/Users/matia/Stacc/Pages/FetchData.razor"
                                     acc1.name

#line default
#line hidden
#nullable disable
                , 11, (context) => (__builder3) => {
                    __builder3.AddContent(12, " ");
                    __builder3.AddContent(13, 
#nullable restore
#line 16 "/Users/matia/Stacc/Pages/FetchData.razor"
                                                  acc1.name

#line default
#line hidden
#nullable disable
                    );
                }
                );
                __builder2.AddMarkupContent(14, "\r\n");
#nullable restore
#line 17 "/Users/matia/Stacc/Pages/FetchData.razor"
          
        }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(15, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(16, "\r\n");
#nullable restore
#line 22 "/Users/matia/Stacc/Pages/FetchData.razor"
 if(acc1 != null) { 

#line default
#line hidden
#nullable disable
            __builder.OpenElement(17, "table");
            __builder.AddAttribute(18, "class", "table");
            __builder.AddMarkupContent(19, "\r\n    ");
            __builder.AddMarkupContent(20, "<thead>\r\n    </thead>\r\n    ");
            __builder.OpenElement(21, "tbody");
            __builder.AddMarkupContent(22, "\r\n        ");
            __builder.AddMarkupContent(23, @"<tr>
            <th>
                <text> Account </text>
            </th>
            <th>
                <text> Currency </text>
            </th>
            <th>
                <text> Amount </text>

            </th>
            <th>
                <text> Value </text>

            </th>
        </tr>

            ");
            __builder.OpenElement(24, "tr");
            __builder.AddMarkupContent(25, "\r\n                ");
            __builder.OpenElement(26, "th");
            __builder.AddMarkupContent(27, "\r\n                    ");
            __builder.OpenElement(28, "text");
            __builder.AddContent(29, "  ");
            __builder.AddContent(30, 
#nullable restore
#line 46 "/Users/matia/Stacc/Pages/FetchData.razor"
                             acc1.name

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(31, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                ");
            __builder.OpenElement(34, "th");
            __builder.AddMarkupContent(35, "\r\n                    ");
            __builder.OpenElement(36, "text");
            __builder.AddContent(37, " ");
            __builder.AddContent(38, 
#nullable restore
#line 49 "/Users/matia/Stacc/Pages/FetchData.razor"
                            acc1.currency

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(39, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                ");
            __builder.OpenElement(42, "th");
            __builder.AddMarkupContent(43, "\r\n                    ");
            __builder.OpenElement(44, "text");
            __builder.AddContent(45, " ");
            __builder.AddContent(46, 
#nullable restore
#line 52 "/Users/matia/Stacc/Pages/FetchData.razor"
                            double.Parse(acc1.amount).ToString("0.#######")

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(47, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n                ");
            __builder.OpenElement(50, "th");
            __builder.AddMarkupContent(51, "\r\n                    ");
            __builder.OpenElement(52, "text");
            __builder.AddContent(53, " ");
            __builder.AddContent(54, 
#nullable restore
#line 55 "/Users/matia/Stacc/Pages/FetchData.razor"
                            double.Parse(@acc1.value.ToString("0.00"))

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(55, " USD ");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n");
#nullable restore
#line 62 "/Users/matia/Stacc/Pages/FetchData.razor"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "/Users/matia/Stacc/Pages/FetchData.razor"
 if (accountsGraph == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(61, "<p><em>Loading...</em></p> ");
#nullable restore
#line 65 "/Users/matia/Stacc/Pages/FetchData.razor"
                           }
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<C1.Blazor.Chart.FlexChart>(62);
            __builder.AddAttribute(63, "ItemsSource", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 68 "/Users/matia/Stacc/Pages/FetchData.razor"
                        accountsGraph

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(64, "BindingX", "timestamp");
            __builder.AddAttribute(65, "ChartType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<C1.Chart.ChartType>(
#nullable restore
#line 68 "/Users/matia/Stacc/Pages/FetchData.razor"
                                                                       ChartType.SplineSymbols

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(66, "HeaderContent", "Graph");
            __builder.AddAttribute(67, "HeaderStyle", "font-size:24px");
            __builder.AddAttribute(68, "SeriesCollection", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(69, "\r\n        ");
                __builder2.OpenComponent<C1.Blazor.Chart.Series>(70);
                __builder2.AddAttribute(71, "Binding", "value");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(72, "\r\n    ");
            }
            ));
            __builder.AddAttribute(73, "AxisCollection", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(74, "\r\n        ");
                __builder2.OpenComponent<C1.Blazor.Chart.Axis>(75);
                __builder2.AddAttribute(76, "AxisType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<C1.Chart.AxisType>(
#nullable restore
#line 73 "/Users/matia/Stacc/Pages/FetchData.razor"
                        AxisType.X

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(77, "Position", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<C1.Chart.Position>(
#nullable restore
#line 73 "/Users/matia/Stacc/Pages/FetchData.razor"
                                              Position.Bottom

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(78, "AxisLine", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 73 "/Users/matia/Stacc/Pages/FetchData.razor"
                                                                         false

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(79, "Title", "Her skal datoene stå, men gikk tom for tid");
                __builder2.AddAttribute(80, "Format", "MMM-d");
                __builder2.AddAttribute(81, "MajorTickMarks", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<C1.Chart.TickMark>(
#nullable restore
#line 73 "/Users/matia/Stacc/Pages/FetchData.razor"
                                                                                                                                                                  TickMark.None

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(82, "\r\n        ");
                __builder2.OpenComponent<C1.Blazor.Chart.Axis>(83);
                __builder2.AddAttribute(84, "AxisType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<C1.Chart.AxisType>(
#nullable restore
#line 74 "/Users/matia/Stacc/Pages/FetchData.razor"
                        AxisType.Y

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(85, "Position", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<C1.Chart.Position>(
#nullable restore
#line 74 "/Users/matia/Stacc/Pages/FetchData.razor"
                                              Position.Left

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(86, "Title", "Value");
                __builder2.AddAttribute(87, "AxisLine", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 74 "/Users/matia/Stacc/Pages/FetchData.razor"
                                                                                     false

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(88, "MajorTickMarks", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<C1.Chart.TickMark>(
#nullable restore
#line 74 "/Users/matia/Stacc/Pages/FetchData.razor"
                                                                                                            TickMark.None

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(89, "MajorGrid", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 74 "/Users/matia/Stacc/Pages/FetchData.razor"
                                                                                                                                      true

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(90, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 76 "/Users/matia/Stacc/Pages/FetchData.razor"
            }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 78 "/Users/matia/Stacc/Pages/FetchData.razor"
       
    Models.AccountView acc1 = null;
    List<Models.AccountView> acc = Program.accountView;
    String selected = Program.accountView[0].name;
    private void OnSelected(string selection)
    {
        selected = selection;
        OnInitializedAsync();

    }

    private List<Models.tickers> tickers;

    private List<Models.AccountGraph> accountsGraph;

    protected override async Task OnInitializedAsync()
    {
        acc1 = acc.AsEnumerable().Where(x => x.name.ToUpper().Equals(selected.ToUpper())).First();

        accountsGraph = acc1.tickers.AsEnumerable().ToList().ConvertAll(x => new Models.AccountGraph
        {
            timestamp = x.timestamp.Date,
            value = x.converted_last.usd*double.Parse(acc1.amount)
        });

    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.Stacc.Pages.FetchData
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateDropdownListItem_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TItem __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment<TItem> __arg1)
        {
        __builder.OpenComponent<global::Stacc.Pages.DropdownListItem<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Item", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591