#pragma checksum "/Users/guccigod/Documents/SD134ImmersionFT/alexandriaAudiobooks/AlexandriaWebApp/AlexandriaWebApp/Client/Pages/Novel/Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "495977b898b31b51f1b3670fe61ac53ce31f86eb"
// <auto-generated/>
#pragma warning disable 1591
namespace AlexandriaWebApp.Client.Pages.Novel
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/guccigod/Documents/SD134ImmersionFT/alexandriaAudiobooks/AlexandriaWebApp/AlexandriaWebApp/Client/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/guccigod/Documents/SD134ImmersionFT/alexandriaAudiobooks/AlexandriaWebApp/AlexandriaWebApp/Client/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/guccigod/Documents/SD134ImmersionFT/alexandriaAudiobooks/AlexandriaWebApp/AlexandriaWebApp/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/guccigod/Documents/SD134ImmersionFT/alexandriaAudiobooks/AlexandriaWebApp/AlexandriaWebApp/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/guccigod/Documents/SD134ImmersionFT/alexandriaAudiobooks/AlexandriaWebApp/AlexandriaWebApp/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/guccigod/Documents/SD134ImmersionFT/alexandriaAudiobooks/AlexandriaWebApp/AlexandriaWebApp/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/guccigod/Documents/SD134ImmersionFT/alexandriaAudiobooks/AlexandriaWebApp/AlexandriaWebApp/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/guccigod/Documents/SD134ImmersionFT/alexandriaAudiobooks/AlexandriaWebApp/AlexandriaWebApp/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/guccigod/Documents/SD134ImmersionFT/alexandriaAudiobooks/AlexandriaWebApp/AlexandriaWebApp/Client/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/guccigod/Documents/SD134ImmersionFT/alexandriaAudiobooks/AlexandriaWebApp/AlexandriaWebApp/Client/_Imports.razor"
using AlexandriaWebApp.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/guccigod/Documents/SD134ImmersionFT/alexandriaAudiobooks/AlexandriaWebApp/AlexandriaWebApp/Client/_Imports.razor"
using AlexandriaWebApp.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/guccigod/Documents/SD134ImmersionFT/alexandriaAudiobooks/AlexandriaWebApp/AlexandriaWebApp/Client/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/Users/guccigod/Documents/SD134ImmersionFT/alexandriaAudiobooks/AlexandriaWebApp/AlexandriaWebApp/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/guccigod/Documents/SD134ImmersionFT/alexandriaAudiobooks/AlexandriaWebApp/AlexandriaWebApp/Client/Pages/Novel/Index.razor"
using AlexandriaWebApp.Shared.Models.Novel;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/novel")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Our Catalog</h3>\n");
            __builder.AddMarkupContent(1, "<a href=\"/novel/create\">Add a new Novel to our Catalog</a>");
#nullable restore
#line 10 "/Users/guccigod/Documents/SD134ImmersionFT/alexandriaAudiobooks/AlexandriaWebApp/AlexandriaWebApp/Client/Pages/Novel/Index.razor"
 if (_novel == null)
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>");
#nullable restore
#line 13 "/Users/guccigod/Documents/SD134ImmersionFT/alexandriaAudiobooks/AlexandriaWebApp/AlexandriaWebApp/Client/Pages/Novel/Index.razor"
}
else
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "container");
#nullable restore
#line 17 "/Users/guccigod/Documents/SD134ImmersionFT/alexandriaAudiobooks/AlexandriaWebApp/AlexandriaWebApp/Client/Pages/Novel/Index.razor"
                     foreach (var novel in _novel)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(5, "a");
            __builder.AddAttribute(6, "href", "novel/{novel.Id}");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "col-xl-3 col-lg-4 col-md-6");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "card");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "card-body");
            __builder.OpenElement(13, "h5");
            __builder.AddAttribute(14, "class", "card-title");
            __builder.AddContent(15, 
#nullable restore
#line 23 "/Users/guccigod/Documents/SD134ImmersionFT/alexandriaAudiobooks/AlexandriaWebApp/AlexandriaWebApp/Client/Pages/Novel/Index.razor"
                                                            novel.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\n                                    ");
            __builder.OpenElement(17, "p");
            __builder.AddAttribute(18, "class", "card-text");
            __builder.AddContent(19, "By: ");
            __builder.AddContent(20, 
#nullable restore
#line 24 "/Users/guccigod/Documents/SD134ImmersionFT/alexandriaAudiobooks/AlexandriaWebApp/AlexandriaWebApp/Client/Pages/Novel/Index.razor"
                                                              novel.Author

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\n                                    ");
            __builder.OpenElement(22, "a");
            __builder.AddAttribute(23, "class", "card-text");
            __builder.AddAttribute(24, "href", "/Novel/NovelsInCategory/{" + (
#nullable restore
#line 25 "/Users/guccigod/Documents/SD134ImmersionFT/alexandriaAudiobooks/AlexandriaWebApp/AlexandriaWebApp/Client/Pages/Novel/Index.razor"
                                                                                         novel.CategoryId

#line default
#line hidden
#nullable disable
            ) + "}");
            __builder.AddContent(25, 
#nullable restore
#line 25 "/Users/guccigod/Documents/SD134ImmersionFT/alexandriaAudiobooks/AlexandriaWebApp/AlexandriaWebApp/Client/Pages/Novel/Index.razor"
                                                                                                             novel.CategoryName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\n                                    ");
            __builder.OpenElement(27, "p");
            __builder.AddAttribute(28, "class", "card-text>");
            __builder.AddContent(29, "Average Rating: ");
            __builder.AddContent(30, 
#nullable restore
#line 26 "/Users/guccigod/Documents/SD134ImmersionFT/alexandriaAudiobooks/AlexandriaWebApp/AlexandriaWebApp/Client/Pages/Novel/Index.razor"
                                                                           novel.AverageRating

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 31 "/Users/guccigod/Documents/SD134ImmersionFT/alexandriaAudiobooks/AlexandriaWebApp/AlexandriaWebApp/Client/Pages/Novel/Index.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 33 "/Users/guccigod/Documents/SD134ImmersionFT/alexandriaAudiobooks/AlexandriaWebApp/AlexandriaWebApp/Client/Pages/Novel/Index.razor"
            }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 35 "/Users/guccigod/Documents/SD134ImmersionFT/alexandriaAudiobooks/AlexandriaWebApp/AlexandriaWebApp/Client/Pages/Novel/Index.razor"
       
    private IEnumerable<NovelListItem> _novel;

    protected override async Task OnInitializedAsync()
    {
        _novel = await http.GetFromJsonAsync<List<NovelListItem>>("/api/novel");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
