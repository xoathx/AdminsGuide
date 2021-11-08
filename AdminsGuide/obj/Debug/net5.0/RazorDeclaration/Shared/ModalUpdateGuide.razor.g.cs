// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace AdminsGuide.Shared
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
    public partial class ModalUpdateGuide : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 23 "C:\Users\uothy\source\repos\AdminsGuide\AdminsGuide\Shared\ModalUpdateGuide.razor"
       
    [Parameter]
    public Guide CurrentGuide { get; set; }
    [Parameter]
    public EventCallback<bool> IsClosed { get; set; }
    private string Question { get; set; }
    private string Answer { get; set; }

    protected override void OnInitialized()
    {
        Question = CurrentGuide.Question;
        Answer = AddSpace(CurrentGuide.Answer);
    }
    private Task ModalCancel()
    {
        return IsClosed.InvokeAsync(false);
    }

    private Task ModalOk()
    {
        CurrentGuide.Answer = Answer;
        CurrentGuide.Question = Question;
        SqlGuide.UpdateGuide(CurrentGuide);
        return IsClosed.InvokeAsync(true);
    }

    private string AddSpace(string str)
    {
        if (str.Contains("<br>"))
        {
            return str.Replace("<br>", "\n");
        }
        return str;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AdminsGuide.Data.Repository.IGuide SqlGuide { get; set; }
    }
}
#pragma warning restore 1591
