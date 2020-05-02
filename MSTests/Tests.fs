module TestsMSTest

open Code

open Microsoft.VisualStudio.TestTools.UnitTesting

// MS Test requires putting tests inside a class

[<TestClass>]
type TestingClass () =

    // Double tick marks make it easy to read output
    [<TestMethod>]
    member x.``gcd of 18 and 42 is 6 (MSTest)`` () =

        // Assemble and Act
        let result = gcd 18 42

        Assert.AreEqual(result, 6)
