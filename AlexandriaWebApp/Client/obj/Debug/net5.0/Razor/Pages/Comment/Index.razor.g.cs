#pragma checksum "/Users/guccigod/Documents/SD134ImmersionFT/alexandriaAudiobooks/AlexandriaWebApp/AlexandriaWebApp/Client/Pages/Comment/Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3718813998312334a0c0090c0febcb556477a8e8"
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
#line 2 "/Users/guccigod/Documents/SD134ImmersionFT/alexandriaAudiobooks/AlexandriaWebApp/AlexandriaWebApp/Client/Pages/Comment/Index.razor"
using AlexandriaWebApp.Shared.Models.Comment;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/comment")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>All Comments</h3>\n");
            __builder.AddMarkupContent(1, "<a href=\"/comment/create\">Create a New Comment</a>");
#nullable restore
#line 10 "/Users/guccigod/Documents/SD134ImmersionFT/alexandriaAudiobooks/AlexandriaWebApp/AlexandriaWebApp/Client/Pages/Comment/Index.razor"
 if (_comments == null)
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>");
#nullable restore
#line 13 "/Users/guccigod/Documents/SD134ImmersionFT/alexandriaAudiobooks/AlexandriaWebApp/AlexandriaWebApp/Client/Pages/Comment/Index.razor"
}
else
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "/Users/guccigod/Documents/SD134ImmersionFT/alexandriaAudiobooks/AlexandriaWebApp/AlexandriaWebApp/Client/Pages/Comment/Index.razor"
                 foreach (var comment in _comments)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "a");
            __builder.AddAttribute(4, "href", 
#nullable restore
#line 18 "/Users/guccigod/Documents/SD134ImmersionFT/alexandriaAudiobooks/AlexandriaWebApp/AlexandriaWebApp/Client/Pages/Comment/Index.razor"
          $"comment/{comment.Id}"

#line default
#line hidden
#nullable disable
            );
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "container");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "card");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "card-body");
            __builder.OpenElement(11, "h5");
            __builder.AddAttribute(12, "class", "card-title");
            __builder.AddContent(13, 
#nullable restore
#line 22 "/Users/guccigod/Documents/SD134ImmersionFT/alexandriaAudiobooks/AlexandriaWebApp/AlexandriaWebApp/Client/Pages/Comment/Index.razor"
                                        comment.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\n                ");
            __builder.OpenElement(15, "p");
            __builder.AddAttribute(16, "class", "text-left");
            __builder.AddContent(17, 
#nullable restore
#line 23 "/Users/guccigod/Documents/SD134ImmersionFT/alexandriaAudiobooks/AlexandriaWebApp/AlexandriaWebApp/Client/Pages/Comment/Index.razor"
                                      comment.NovelName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 26 "/Users/guccigod/Documents/SD134ImmersionFT/alexandriaAudiobooks/AlexandriaWebApp/AlexandriaWebApp/Client/Pages/Comment/Index.razor"
                 if (comment.IsReview == true)
                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(18, "<p class=\"text-muted\">This Comment is a review!</p>");
#nullable restore
#line 29 "/Users/guccigod/Documents/SD134ImmersionFT/alexandriaAudiobooks/AlexandriaWebApp/AlexandriaWebApp/Client/Pages/Comment/Index.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(19, "p");
            __builder.AddContent(20, 
#nullable restore
#line 31 "/Users/guccigod/Documents/SD134ImmersionFT/alexandriaAudiobooks/AlexandriaWebApp/AlexandriaWebApp/Client/Pages/Comment/Index.razor"
                    comment.Comments

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 32 "/Users/guccigod/Documents/SD134ImmersionFT/alexandriaAudiobooks/AlexandriaWebApp/AlexandriaWebApp/Client/Pages/Comment/Index.razor"
                 if (comment.ModifiedUtc == null)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(21, "p");
            __builder.AddAttribute(22, "class", "text-left");
            __builder.AddContent(23, "Posted at: ");
            __builder.AddContent(24, 
#nullable restore
#line 34 "/Users/guccigod/Documents/SD134ImmersionFT/alexandriaAudiobooks/AlexandriaWebApp/AlexandriaWebApp/Client/Pages/Comment/Index.razor"
                                                     comment.CreatedUtc

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 35 "/Users/guccigod/Documents/SD134ImmersionFT/alexandriaAudiobooks/AlexandriaWebApp/AlexandriaWebApp/Client/Pages/Comment/Index.razor"
                }
                else
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(25, "p");
            __builder.AddAttribute(26, "class", "text-left");
            __builder.AddContent(27, "Edited at: ");
            __builder.AddContent(28, 
#nullable restore
#line 38 "/Users/guccigod/Documents/SD134ImmersionFT/alexandriaAudiobooks/AlexandriaWebApp/AlexandriaWebApp/Client/Pages/Comment/Index.razor"
                                                     comment.ModifiedUtc

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 39 "/Users/guccigod/Documents/SD134ImmersionFT/alexandriaAudiobooks/AlexandriaWebApp/AlexandriaWebApp/Client/Pages/Comment/Index.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(29, "p");
            __builder.AddAttribute(30, "class", "text-right");
            __builder.AddContent(31, 
#nullable restore
#line 40 "/Users/guccigod/Documents/SD134ImmersionFT/alexandriaAudiobooks/AlexandriaWebApp/AlexandriaWebApp/Client/Pages/Comment/Index.razor"
                                       comment.Likes

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
#line 45 "/Users/guccigod/Documents/SD134ImmersionFT/alexandriaAudiobooks/AlexandriaWebApp/AlexandriaWebApp/Client/Pages/Comment/Index.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "/Users/guccigod/Documents/SD134ImmersionFT/alexandriaAudiobooks/AlexandriaWebApp/AlexandriaWebApp/Client/Pages/Comment/Index.razor"
     
    }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 48 "/Users/guccigod/Documents/SD134ImmersionFT/alexandriaAudiobooks/AlexandriaWebApp/AlexandriaWebApp/Client/Pages/Comment/Index.razor"
           
private IEnumerable<CommentListItem> _comments;

protected override async Task OnInitializedAsync()
{
    _comments = await http.GetFromJsonAsync<List<CommentListItem>>("/api/comment");
}
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
