module Main

open Feliz
open App
open Browser.Dom
open Fable.Core.JsInterop


console.log("Fable is up and running...");

ReactDOM.render(
    Components.HelloWorld(),
    document.getElementById "feliz-app"
)