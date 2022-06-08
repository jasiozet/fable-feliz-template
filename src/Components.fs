namespace App

open Feliz
open Feliz.DaisyUI

type Components =
    /// <summary>
    /// The simplest possible React component.
    /// Shows a header with the text Hello World
    /// </summary>
    [<ReactComponent>]
    static member HelloWorld() =
        let (count, setCount) = React.useState(0)
        Html.div [
            Daisy.button.button [
                button.primary
                prop.onClick (fun _ -> setCount(count + 1))
                prop.text ("Increment: " + string count)
            ]
        ]
