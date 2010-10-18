﻿#light
namespace FSharp.Javascript.Tests

open NUnit.Framework
open FSharp.Javascript.Printer
open TestNamespace.ComputationModule
open QuotationsTestHelper
open TestModule
open FSharp.Javascript.Dom
open FSharp.Javascript.Jquery

[<TestFixture>]
type DomTests() =
    
    [<Test>]
    member this.``Test``() =
        test <@ seq { for i in 1..10 do document.write(i) } |> Seq.toArray @>

    [<Test>]
    member this.``Test1``() =
        test <@ let results = seq { for i in 1..10 -> (fun () -> document.write(i.ToString() + " ")) }
                seq { for x in results do x() } |> Seq.toArray @>

    [<Test>]
    member this.``Test2``() =
        test <@ (jquery "div").find("").find("").parent().addClass("") @>