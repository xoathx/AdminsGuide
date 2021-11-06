#pragma checksum "C:\Users\uothy\source\repos\AdminsGuide\AdminsGuide\Pages\PageAddGuide.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3bc8a5c4863b6065eaea7a95f3c88f16cb4f36bd"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/add")]
    public partial class PageAddGuide : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>PageAddGuide</h3>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.OpenElement(5, "input");
            __builder.AddAttribute(6, "type", "text");
            __builder.AddAttribute(7, "class", "form-control");
            __builder.AddAttribute(8, "placeholder", "Вопрос");
            __builder.AddAttribute(9, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 7 "C:\Users\uothy\source\repos\AdminsGuide\AdminsGuide\Pages\PageAddGuide.razor"
                                                                            Question

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Question = __value, Question));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n        ");
            __builder.AddMarkupContent(12, "<label for=\"answer-field\">Ответ на вопрос:</label>\r\n        ");
            __builder.OpenElement(13, "textarea");
            __builder.AddAttribute(14, "class", "form-control");
            __builder.AddAttribute(15, "rows", "7");
            __builder.AddAttribute(16, "id", "answer-field");
            __builder.AddAttribute(17, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 9 "C:\Users\uothy\source\repos\AdminsGuide\AdminsGuide\Pages\PageAddGuide.razor"
                                                                         Answer

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Answer = __value, Answer));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n        ");
            __builder.OpenElement(20, "button");
            __builder.AddAttribute(21, "class", "btn btn-secondary");
            __builder.AddAttribute(22, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\uothy\source\repos\AdminsGuide\AdminsGuide\Pages\PageAddGuide.razor"
                                                     AddToDb

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(23, "Добавить");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "C:\Users\uothy\source\repos\AdminsGuide\AdminsGuide\Pages\PageAddGuide.razor"
       
    private string Question;
    private string Answer;
    private string message;
    private void AddToDb()
    {
        if(string.IsNullOrWhiteSpace(Question) || string.IsNullOrWhiteSpace(Answer))
        {
            message = "Заполните все поля";
        }
        else
        {
            if(Answer.Contains("\n"))
            {
                Answer = Answer.Replace("\n", "<br>");
            }
            Guide guide = new Guide()
            {
                Question = Question,
                Answer = Answer
            };
            SqlGuide.AddGuide(guide);
            Question = "";
            Answer = "";
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AdminsGuide.Data.Repository.IGuide SqlGuide { get; set; }
    }
}
#pragma warning restore 1591