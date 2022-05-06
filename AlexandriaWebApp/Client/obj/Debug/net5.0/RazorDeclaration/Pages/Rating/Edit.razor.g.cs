// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace AlexandriaWebApp.Client.Pages.Rating
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
#line 13 "/Users/guccigod/Documents/SD134ImmersionFT/alexandriaAudiobooks/AlexandriaWebApp/AlexandriaWebApp/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/guccigod/Documents/SD134ImmersionFT/alexandriaAudiobooks/AlexandriaWebApp/AlexandriaWebApp/Client/Pages/Rating/Edit.razor"
using AlexandriaWebApp.Shared.Models.Rating;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/guccigod/Documents/SD134ImmersionFT/alexandriaAudiobooks/AlexandriaWebApp/AlexandriaWebApp/Client/Pages/Rating/Edit.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/guccigod/Documents/SD134ImmersionFT/alexandriaAudiobooks/AlexandriaWebApp/AlexandriaWebApp/Client/Pages/Rating/Edit.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/rating/edit/{RatingId:int}")]
    public partial class Edit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "/Users/guccigod/Documents/SD134ImmersionFT/alexandriaAudiobooks/AlexandriaWebApp/AlexandriaWebApp/Client/Pages/Rating/Edit.razor"
       
    [Parameter]
    public int RatingId { get; set; }
    private RatingEdit Model { get; set; }
    private string ErrorMessage { get; set; }

    protected override async Task OnInitializedAsync()
    {
        Model = await http.GetFromJsonAsync<RatingEdit>($"/api/rating/{RatingId}");
    }

    private async void HandleSubmit()
    {
        var createRes = await http.PutAsJsonAsync<RatingEdit>($"/api/rating/edit/{RatingId}", Model);
        if(createRes.IsSuccessStatusCode)
        {
            navigation.NavigateTo($"/rating/{RatingId}");
        }
        else
        {
            ErrorMessage = "Could not update your rating right now, please try again later.";
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
