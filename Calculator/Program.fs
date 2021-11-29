module Program 
open System
(* This is a multi-line comment *)
// This is a single-line comment

let Add numbers =
   if numbers = "" then 0
   else numbers|> int

let main() =
   Console.WriteLine("sign 5: {0}", (Add ""))

main()





