// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Blazor_app_tutorial.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Cata Bastanu\Documents\GitHub\SEP6_FrontEnd\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Cata Bastanu\Documents\GitHub\SEP6_FrontEnd\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Cata Bastanu\Documents\GitHub\SEP6_FrontEnd\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Cata Bastanu\Documents\GitHub\SEP6_FrontEnd\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Cata Bastanu\Documents\GitHub\SEP6_FrontEnd\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Cata Bastanu\Documents\GitHub\SEP6_FrontEnd\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Cata Bastanu\Documents\GitHub\SEP6_FrontEnd\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Cata Bastanu\Documents\GitHub\SEP6_FrontEnd\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Cata Bastanu\Documents\GitHub\SEP6_FrontEnd\_Imports.razor"
using Blazor_app_tutorial;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Cata Bastanu\Documents\GitHub\SEP6_FrontEnd\_Imports.razor"
using Blazor_app_tutorial.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/movie")]
    public partial class Movie : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "C:\Users\Cata Bastanu\Documents\GitHub\SEP6_FrontEnd\Pages\Movie.razor"
       
    private List<MovieItem> movies = new();
    private void AddInitialMovie(){
        MovieItem D = new();
        D.Title = "Tenacious D";
        D.Year = 2003;
        D.Rating = 10;
        D.PersonalRate = 0;
        movies.Add(D);
    }
        private void AddSecondMovie(){
        MovieItem D = new();
        D.Title = "Jackass";
        D.Year = 2003;
        D.Rating = 10;
        D.PersonalRate = 0;
        movies.Add(D);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
