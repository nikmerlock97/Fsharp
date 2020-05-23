module TwoFer

let twoFer (input: string option) =
    match input with
    | Some input' -> sprintf "One for %s, one for me." input'
    | None -> sprintf "One for you, one for me."
