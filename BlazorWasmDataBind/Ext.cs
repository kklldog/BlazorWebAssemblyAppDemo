using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWasmDataBind
{
    public static class Ext
    {
        public static void Back(this NavigationManager navigation)
        {
            var jsruntime = Program.Services.BuildServiceProvider().GetService<IJSRuntime>();
            jsruntime.InvokeVoidAsync("history.back");
        }
    }
}
