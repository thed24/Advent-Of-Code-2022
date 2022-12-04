module Helpers

let parse (str:string) =
    match System.Int32.TryParse str with
    | true,int -> int
    | _ -> 0

let tryParse (str:string) =
    match System.Int32.TryParse str with
    | true,int -> Some int
    | _ -> None