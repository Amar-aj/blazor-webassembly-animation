#pragma checksum "E:\Amar\dotnet\Blazor\BlazorWebTemplete\BlazorWebTemplete\Admin\AdminPage2.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f779afc84e638ba62e2a6e7662c794fc6ef9d178"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorWebTemplete.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\Amar\dotnet\Blazor\BlazorWebTemplete\BlazorWebTemplete\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Amar\dotnet\Blazor\BlazorWebTemplete\BlazorWebTemplete\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Amar\dotnet\Blazor\BlazorWebTemplete\BlazorWebTemplete\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Amar\dotnet\Blazor\BlazorWebTemplete\BlazorWebTemplete\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Amar\dotnet\Blazor\BlazorWebTemplete\BlazorWebTemplete\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Amar\dotnet\Blazor\BlazorWebTemplete\BlazorWebTemplete\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Amar\dotnet\Blazor\BlazorWebTemplete\BlazorWebTemplete\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Amar\dotnet\Blazor\BlazorWebTemplete\BlazorWebTemplete\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Amar\dotnet\Blazor\BlazorWebTemplete\BlazorWebTemplete\_Imports.razor"
using BlazorWebTemplete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\Amar\dotnet\Blazor\BlazorWebTemplete\BlazorWebTemplete\_Imports.razor"
using BlazorWebTemplete.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\Amar\dotnet\Blazor\BlazorWebTemplete\BlazorWebTemplete\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "E:\Amar\dotnet\Blazor\BlazorWebTemplete\BlazorWebTemplete\_Imports.razor"
using BlazorAnimate;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(AdminLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin2")]
    public partial class AdminPage2 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<BlazorAnimate.Animate>(0);
            __builder.AddAttribute(1, "Animation", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorAnimate.IAnimation>(
#nullable restore
#line 3 "E:\Amar\dotnet\Blazor\BlazorWebTemplete\BlazorWebTemplete\Admin\AdminPage2.razor"
                     Animations.ZoomInUp

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "Duration", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.TimeSpan?>(
#nullable restore
#line 3 "E:\Amar\dotnet\Blazor\BlazorWebTemplete\BlazorWebTemplete\Admin\AdminPage2.razor"
                                                    TimeSpan.FromSeconds(0.3)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "Delay", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.TimeSpan?>(
#nullable restore
#line 3 "E:\Amar\dotnet\Blazor\BlazorWebTemplete\BlazorWebTemplete\Admin\AdminPage2.razor"
                                                                                      TimeSpan.FromSeconds(1)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(5, "<center><h3>Admin Page 2</h3>\r\n          <h3>Admin Page 2</h3>\r\n          <h3>Admin Page 2</h3>\r\n          <h3>Admin Page 2</h3>\r\n          <h3>Admin Page 2</h3>\r\n          <h3>Admin Page 2</h3></center>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
