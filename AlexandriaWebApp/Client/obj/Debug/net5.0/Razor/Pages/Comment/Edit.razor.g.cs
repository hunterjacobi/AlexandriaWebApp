#pragma checksum "/Users/guccigod/Documents/SD134ImmersionFT/alexandriaAudiobooks/AlexandriaWebApp/AlexandriaWebApp/Client/Pages/Comment/Edit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af2c4f6ae8ec52b4f1badf9eac18e7b8e4d7166d"
// <auto-generated/>
#pragma warning disable 1591
namespace AlexandriaWebApp.Client.Pages.Comment
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
#line 2 "/Users/guccigod/Documents/SD134ImmersionFT/alexandriaAudiobooks/AlexandriaWebApp/AlexandriaWebApp/Client/Pages/Comment/Edit.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/guccigod/Documents/SD134ImmersionFT/alexandriaAudiobooks/AlexandriaWebApp/AlexandriaWebApp/Client/Pages/Comment/Edit.razor"
using AlexandriaWebApp.Shared.Models.Comment;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/guccigod/Documents/SD134ImmersionFT/alexandriaAudiobooks/AlexandriaWebApp/AlexandriaWebApp/Client/Pages/Comment/Edit.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/comment/edit/{CommentId:int}")]
    public partial class Edit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Edit Comment</h3>");
#nullable restore
#line 12 "/Users/guccigod/Documents/SD134ImmersionFT/alexandriaAudiobooks/AlexandriaWebApp/AlexandriaWebApp/Client/Pages/Comment/Edit.razor"
 if(errorMessage != null)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "h5");
            __builder.AddAttribute(2, "class", "text-danger");
            __builder.AddContent(3, 
#nullable restore
#line 14 "/Users/guccigod/Documents/SD134ImmersionFT/alexandriaAudiobooks/AlexandriaWebApp/AlexandriaWebApp/Client/Pages/Comment/Edit.razor"
                                         errorMessage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 15 "/Users/guccigod/Documents/SD134ImmersionFT/alexandriaAudiobooks/AlexandriaWebApp/AlexandriaWebApp/Client/Pages/Comment/Edit.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "container");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(6);
            __builder.AddAttribute(7, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 18 "/Users/guccigod/Documents/SD134ImmersionFT/alexandriaAudiobooks/AlexandriaWebApp/AlexandriaWebApp/Client/Pages/Comment/Edit.razor"
                      model

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 18 "/Users/guccigod/Documents/SD134ImmersionFT/alexandriaAudiobooks/AlexandriaWebApp/AlexandriaWebApp/Client/Pages/Comment/Edit.razor"
                                             HandleSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(10);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(12);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(13, "\n        ");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "form-group");
                __builder2.AddMarkupContent(16, "<label>Comments</label>\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(17);
                __builder2.AddAttribute(18, "class", "form-control");
                __builder2.AddAttribute(19, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "/Users/guccigod/Documents/SD134ImmersionFT/alexandriaAudiobooks/AlexandriaWebApp/AlexandriaWebApp/Client/Pages/Comment/Edit.razor"
                                                             model.Comments

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(20, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.Comments = __value, model.Comments))));
                __builder2.AddAttribute(21, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => model.Comments));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\n\n        ");
                __builder2.AddMarkupContent(23, "<button type=\"submit\" class=\"btn btn-primary btn-block mt-5\">Submit</button>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "/Users/guccigod/Documents/SD134ImmersionFT/alexandriaAudiobooks/AlexandriaWebApp/AlexandriaWebApp/Client/Pages/Comment/Edit.razor"
       
    [Parameter]
    public int CommentId { get; set; }
    private CommentEdit model { get; set; }
    private string errorMessage { get; set; }

    protected override async Task OnInitializedAsync()
    {
        model = await http.GetFromJsonAsync<CommentEdit>($"/api/comment/{CommentId}");
    }

    private async void HandleSubmit()
    {
        var editRes = await http.PutAsJsonAsync<CommentEdit>($"/api/comment/edit/{CommentId}", model);

        if (editRes.IsSuccessStatusCode)
        {
            navigation.NavigateTo($"/comment/{CommentId}");
        }
        else
        {
            errorMessage = "Could not edit coment right now";
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
