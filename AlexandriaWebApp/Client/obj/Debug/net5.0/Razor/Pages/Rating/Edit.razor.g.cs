#pragma checksum "/Users/guccigod/Documents/SD134ImmersionFT/alexandriaAudiobooks/AlexandriaWebApp/AlexandriaWebApp/Client/Pages/Rating/Edit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "19110ef997de5b8b5610912cc43d0ce3057299ff"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.OpenElement(0, "h3");
            __builder.AddContent(1, "Edit Rating for ");
            __builder.AddContent(2, 
#nullable restore
#line 10 "/Users/guccigod/Documents/SD134ImmersionFT/alexandriaAudiobooks/AlexandriaWebApp/AlexandriaWebApp/Client/Pages/Rating/Edit.razor"
                     Model.NovelName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 12 "/Users/guccigod/Documents/SD134ImmersionFT/alexandriaAudiobooks/AlexandriaWebApp/AlexandriaWebApp/Client/Pages/Rating/Edit.razor"
 if (ErrorMessage != null)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "h5");
            __builder.AddAttribute(4, "class", "text-danger");
            __builder.AddContent(5, 
#nullable restore
#line 14 "/Users/guccigod/Documents/SD134ImmersionFT/alexandriaAudiobooks/AlexandriaWebApp/AlexandriaWebApp/Client/Pages/Rating/Edit.razor"
                                         ErrorMessage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 15 "/Users/guccigod/Documents/SD134ImmersionFT/alexandriaAudiobooks/AlexandriaWebApp/AlexandriaWebApp/Client/Pages/Rating/Edit.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "container");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(8);
            __builder.AddAttribute(9, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 18 "/Users/guccigod/Documents/SD134ImmersionFT/alexandriaAudiobooks/AlexandriaWebApp/AlexandriaWebApp/Client/Pages/Rating/Edit.razor"
                      Model

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 18 "/Users/guccigod/Documents/SD134ImmersionFT/alexandriaAudiobooks/AlexandriaWebApp/AlexandriaWebApp/Client/Pages/Rating/Edit.razor"
                                             HandleSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(12);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(13, "\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(14);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\n\n        ");
                __builder2.OpenElement(16, "div");
                __builder2.AddAttribute(17, "class", "form-group");
                __builder2.AddMarkupContent(18, "<label>Rating</label>\n            ");
                __Blazor.AlexandriaWebApp.Client.Pages.Rating.Edit.TypeInference.CreateInputNumber_0(__builder2, 19, 20, "form-control", 21, 
#nullable restore
#line 24 "/Users/guccigod/Documents/SD134ImmersionFT/alexandriaAudiobooks/AlexandriaWebApp/AlexandriaWebApp/Client/Pages/Rating/Edit.razor"
                                                             Model.Ratings

#line default
#line hidden
#nullable disable
                , 22, "1", 23, "5", 24, "0.5", 25, 
#nullable restore
#line 24 "/Users/guccigod/Documents/SD134ImmersionFT/alexandriaAudiobooks/AlexandriaWebApp/AlexandriaWebApp/Client/Pages/Rating/Edit.razor"
                                                                                         Model.Ratings

#line default
#line hidden
#nullable disable
                , 26, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Model.Ratings = __value, Model.Ratings)), 27, () => Model.Ratings);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\n        ");
                __builder2.AddMarkupContent(29, "<button type=\"submit\" class=\"btn btn-primary btn-block mt-5\">Submit</button>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
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
namespace __Blazor.AlexandriaWebApp.Client.Pages.Rating.Edit
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, System.Object __arg3, int __seq4, System.Object __arg4, int __seq5, TValue __arg5, int __seq6, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg6, int __seq7, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg7)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "CurrentValue", __arg1);
        __builder.AddAttribute(__seq2, "min", __arg2);
        __builder.AddAttribute(__seq3, "max", __arg3);
        __builder.AddAttribute(__seq4, "scale", __arg4);
        __builder.AddAttribute(__seq5, "Value", __arg5);
        __builder.AddAttribute(__seq6, "ValueChanged", __arg6);
        __builder.AddAttribute(__seq7, "ValueExpression", __arg7);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591