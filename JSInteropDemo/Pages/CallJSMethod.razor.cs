using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;

namespace JSInteropDemo.Pages
{
    public class CallJSMethodBase : ComponentBase
    {
        [Inject]
        protected IJSRuntime _jsRuntime { get; set; }

        protected string _message = "WTF?";
        protected string message { 
            get { 
                return _message; 
            }
            set {
                _message = value;
            }
        }

      
        protected void CallJSMethod() {
            _jsRuntime.InvokeAsync<bool>("MyStuff.showAlertBox");
        }
        protected void CallJSMethodWithParameters()
        {
            _jsRuntime.InvokeAsync<bool>("MyStuff.showPrompt", message);
        }
    }
}
