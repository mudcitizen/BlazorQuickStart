using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JSInteropDemo.Pages
{
    public class CallNetMethodFromJSModel : ComponentBase
    {
        [Inject]
        protected IJSRuntime _jsRuntime { get; set; }
        public async Task TriggerNetInstanceMethod()
        {
            System.Diagnostics.Debug.WriteLine("CallNetMethodFromJSModel.TriggerNetInstanceMethod()");
            ExampleJsInterop helper = new ExampleJsInterop(_jsRuntime);
            await helper.CallHelloHelperSayHello("Blazor");
        }
    }

    public class ExampleJsInterop
    {
        private readonly IJSRuntime _jsRuntime;

        public ExampleJsInterop(IJSRuntime jsRuntime) {_jsRuntime = jsRuntime;}

        public ValueTask<string> CallHelloHelperSayHello(string name)
        {
            System.Diagnostics.Debug.WriteLine("ExampleJsInterop.CallHelloHelperSayHello() - Before call");
            // sayHello is implemented in wwwroot/js/MyStuff.js
            return _jsRuntime.InvokeAsync<string>(
                "MyStuff.sayHello",
                DotNetObjectReference.Create(new HelloHelper(name)));
        }
    }

    public class HelloHelper
    {
        public HelloHelper(string name) { Name = name;}
        public string Name { get; set; }
        [JSInvokable]
        public string SayHello() {
            System.Diagnostics.Debug.WriteLine("HelloHelper.SayHellow()");

            return $"Hello, {Name}!"; 
        }
    }
}
