#pragma checksum "C:\Users\uothy\source\repos\AdminsGuide\AdminsGuide\Pages\PageQuestion.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "71e9863e257725ae075a4a4b92d3d1166879a748"
// <auto-generated/>
#pragma warning disable 1591
namespace AdminsGuide.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\uothy\source\repos\AdminsGuide\AdminsGuide\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\uothy\source\repos\AdminsGuide\AdminsGuide\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\uothy\source\repos\AdminsGuide\AdminsGuide\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\uothy\source\repos\AdminsGuide\AdminsGuide\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\uothy\source\repos\AdminsGuide\AdminsGuide\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\uothy\source\repos\AdminsGuide\AdminsGuide\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\uothy\source\repos\AdminsGuide\AdminsGuide\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\uothy\source\repos\AdminsGuide\AdminsGuide\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\uothy\source\repos\AdminsGuide\AdminsGuide\_Imports.razor"
using AdminsGuide;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\uothy\source\repos\AdminsGuide\AdminsGuide\_Imports.razor"
using AdminsGuide.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\uothy\source\repos\AdminsGuide\AdminsGuide\_Imports.razor"
using AdminsGuide.Data.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/quest/{Id:int}")]
    public partial class PageQuestion : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 6 "C:\Users\uothy\source\repos\AdminsGuide\AdminsGuide\Pages\PageQuestion.razor"
 if(guide == null)
            {
                

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, 
#nullable restore
#line 8 "C:\Users\uothy\source\repos\AdminsGuide\AdminsGuide\Pages\PageQuestion.razor"
                 message

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 8 "C:\Users\uothy\source\repos\AdminsGuide\AdminsGuide\Pages\PageQuestion.razor"
                        
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "h2");
            __builder.AddContent(2, 
#nullable restore
#line 13 "C:\Users\uothy\source\repos\AdminsGuide\AdminsGuide\Pages\PageQuestion.razor"
                     guide.Question

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n                <hr align=\"center\" width=\"500\" size=\"2\" color=\"#B950ED\">");
            __builder.AddContent(4, 
#nullable restore
#line 16 "C:\Users\uothy\source\repos\AdminsGuide\AdminsGuide\Pages\PageQuestion.razor"
                  (MarkupString)guide.Answer

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 16 "C:\Users\uothy\source\repos\AdminsGuide\AdminsGuide\Pages\PageQuestion.razor"
                                             
            }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 19 "C:\Users\uothy\source\repos\AdminsGuide\AdminsGuide\Pages\PageQuestion.razor"
       
    [Parameter]
    public int Id { get; set; }
    private Guide guide;
    private string message;
    protected override void OnInitialized()
    {
        guide = SqlGuide.GetGuideById(Id);
        if(guide == null)
        {
            message = "Такого ответа еще не добавили";
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AdminsGuide.Data.Repository.IGuide SqlGuide { get; set; }
    }
}
#pragma warning restore 1591