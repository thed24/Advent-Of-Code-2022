
module Main

[<EntryPoint>]
let main args =
    let day = Helpers.tryParse args[0]
    let part = Helpers.tryParse args[1]

    match day, part with
    | Some(1), Some(1) -> printfn "%d" Day1.solutionOne
    | Some(1), Some(2) -> printfn "%d" Day1.solutionTwo
    | None, _ -> printfn "An argument for the given day is either missing or incorrect. Try again!"
    | _, None -> printfn "An argument for the given part is either missing or incorrect. Try again!"
    | _ -> printfn "An unsupported combo was received. Try again!"
    
    0
