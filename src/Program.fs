
module Main

[<EntryPoint>]
let main args =
    let day = Helpers.tryParse args[0]
    let part = Helpers.tryParse args[1]

    match day, part with
    | Some(1), Some(1) -> printfn "%d" Day1.solutionOne
    | Some(1), Some(2) -> printfn "%d" Day1.solutionTwo

    | Some(2), Some(1) -> printfn "%d" Day2.solutionOne
    | Some(2), Some(2) -> printfn "%d" Day2.solutionTwo

    | Some(3), Some(1) -> printfn "%d" Day3.solutionOne
    | Some(3), Some(2) -> printfn "%d" Day3.solutionTwo

    | Some(4), Some(1) -> printfn "%d" Day4.solutionOne
    | Some(4), Some(2) -> printfn "%d" Day4.solutionTwo

    | None, _ -> printfn "An argument for the given day is either missing or incorrect. Try again!"
    | _, None -> printfn "An argument for the given part is either missing or incorrect. Try again!"
    | _ -> printfn "An unsupported combo was received. Try again!"
    
    0
