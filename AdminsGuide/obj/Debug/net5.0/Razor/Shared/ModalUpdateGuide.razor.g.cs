#pragma checksum "C:\Users\uothy\source\repos\AdminsGuide\AdminsGuide\Shared\ModalUpdateGuide.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a6461bf132baa09c46a203257789be9fe2a708d9"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "modal fade show");
            __builder.AddAttribute(2, "id", "myModal");
            __builder.AddAttribute(3, "style", "display:block; background-color: rgba(10,10,10,.8);");
            __builder.AddAttribute(4, "aria-modal", "true");
            __builder.AddAttribute(5, "role", "dialog");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "modal-dialog");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "modal-content");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "modal-header");
            __builder.AddMarkupContent(12, "<h4 class=\"modal-title\">??????????????????</h4>\r\n                ");
            __builder.OpenElement(13, "button");
            __builder.AddAttribute(14, "type", "button");
            __builder.AddAttribute(15, "class", "close");
            __builder.AddAttribute(16, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "C:\Users\uothy\source\repos\AdminsGuide\AdminsGuide\Shared\ModalUpdateGuide.razor"
                                                               ModalCancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(17, "??");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "modal-body");
            __builder.OpenElement(21, "input");
            __builder.AddAttribute(22, "type", "text");
            __builder.AddAttribute(23, "class", "form-control");
            __builder.AddAttribute(24, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 10 "C:\Users\uothy\source\repos\AdminsGuide\AdminsGuide\Shared\ModalUpdateGuide.razor"
                                                              Question

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Question = __value, Question));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                ");
            __builder.OpenElement(27, "textarea");
            __builder.AddAttribute(28, "class", "form-control");
            __builder.AddAttribute(29, "rows", "5");
            __builder.AddAttribute(30, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 11 "C:\Users\uothy\source\repos\AdminsGuide\AdminsGuide\Shared\ModalUpdateGuide.razor"
                                                      Answer

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(31, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Answer = __value, Answer));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n            ");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "modal-footer");
            __builder.OpenElement(35, "button");
            __builder.AddAttribute(36, "type", "button");
            __builder.AddAttribute(37, "class", "btn");
            __builder.AddAttribute(38, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\uothy\source\repos\AdminsGuide\AdminsGuide\Shared\ModalUpdateGuide.razor"
                                                             ModalCancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(39, "Cancel");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                ");
            __builder.OpenElement(41, "button");
            __builder.AddAttribute(42, "type", "button");
            __builder.AddAttribute(43, "class", "btn btn-primary");
            __builder.AddAttribute(44, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "C:\Users\uothy\source\repos\AdminsGuide\AdminsGuide\Shared\ModalUpdateGuide.razor"
                                                                        ModalOk

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(45, "OK");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
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
