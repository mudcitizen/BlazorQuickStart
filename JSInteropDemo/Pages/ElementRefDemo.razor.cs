using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JSInteropDemo.Pages
{
    public class ElementRefDemoBase : ComponentBase
    {
        public ElementReference inputRef;

        [Inject]
        protected IJSRuntime _jsRunTime { get; set; }

        protected void GetInputValue()
        {
            _jsRunTime.InvokeVoidAsync("MyStuff.showValue", inputRef);
        }

    }
}
