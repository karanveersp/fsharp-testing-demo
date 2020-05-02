module Tests

open Expecto
open Code 

[<Tests>]
let simpleTest =
  testCase "gcd works correctly" (fun () ->
    let expected = 6
    Expect.equal (gcd 18 48) expected "gcd of 18 and 48 is 6 (Expecto)")