module NUnitTests

open Code

open FsUnit
open NUnit.Framework 

[<Test>]
let ``gcd of 18 and 42 is 6 (NUnit)`` () =
    // Assemble and Act
    let result = gcd 18 42
    // Assert.That(gcd 18 42, Is.EqualTo 6)  // NUnit syntax
    result |> should equal 6