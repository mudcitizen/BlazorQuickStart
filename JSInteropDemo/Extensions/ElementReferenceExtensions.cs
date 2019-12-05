using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JSInteropDemo.Extensions
{
    public static class ElementReferenceExtensions
    {
        async static public Task ShowValueAsync(this ElementReference eleRef, IJSRuntime jsRuntime) {
            await jsRuntime.InvokeAsync<object>("MyStuff.showValue", eleRef);
        }
    }
}
