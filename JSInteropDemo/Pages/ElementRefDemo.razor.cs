using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JSInteropDemo.Extensions;

namespace JSInteropDemo.Pages
{
    public class ElementRefDemoBase : ComponentBase
    {
        public ElementReference inputRef;

        [Inject]
        protected IJSRuntime _jsRunTime { get; set; }

        async protected void HaveSJShowValueAsync()
        {
            await inputRef.ShowValueAsync(_jsRunTime);
        }

    }
}
