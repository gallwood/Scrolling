#pragma checksum "C:\Users\graham allwood\source\repos\Scrolling\Scrolling\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e578a2c51ada44973e60442a4551774da156e0c"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Scrolling.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\graham allwood\source\repos\Scrolling\Scrolling\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\graham allwood\source\repos\Scrolling\Scrolling\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\graham allwood\source\repos\Scrolling\Scrolling\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\graham allwood\source\repos\Scrolling\Scrolling\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\graham allwood\source\repos\Scrolling\Scrolling\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\graham allwood\source\repos\Scrolling\Scrolling\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\graham allwood\source\repos\Scrolling\Scrolling\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\graham allwood\source\repos\Scrolling\Scrolling\_Imports.razor"
using Scrolling;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\graham allwood\source\repos\Scrolling\Scrolling\_Imports.razor"
using Scrolling.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\graham allwood\source\repos\Scrolling\Scrolling\_Imports.razor"
using Blazorise;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "C:\Users\graham allwood\source\repos\Scrolling\Scrolling\Pages\Counter.razor"
       
    private int currentCount = 0;

    private int[] Lines;
    private void IncrementCount()
    {
        currentCount++;
    }

    protected override void OnInitialized()
    {
        base.OnInitialized();

        Lines = new int[32];
        for (int i = 0; i < Lines.Length; i++)
        {
            Lines[i] = i;
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
