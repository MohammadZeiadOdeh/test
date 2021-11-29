module Tests

open System
open Xunit

let Add numbers =
   if numbers = "" then 0
   elif numbers.Length=1 then
   numbers|> int
   else 
   let index=numbers.IndexOf(",")|> int
   let num1=numbers.Substring(0,index)|> int
   let num2=numbers.Substring(index+1,1)|> int
   num1+num2|> int
   

//let result=Add ""
//let result=Add "1"
let result=Add "1,5"
[<Fact>]
let ``Add test`` () =
    Assert.Equal(6,result)
