MyStuff = {

    showAlertBox: () => {
        alert("I am invoked from .NET");
    },

    showPrompt: (message) => {
        alert("You entered : " + message);
    },

    showValue: (eleRef) => {
        alert(eleRef.value);
    },

    sayHello: function (dotnetHelper) {
        return dotnetHelper.invokeMethodAsync('SayHello')
            .then(r => console.log(r));
    }

};