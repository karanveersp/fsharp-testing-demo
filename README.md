# Testing F# using MSTest, NUnit and XUnit

Create a test project alongside your F# project.

Then add both projects to the solution. This will load the required libraries for both and allow intellisense in
each project's .fs files.

`dotnet sln add projectName`

Add a reference in the test project to the project you want to test.

Then define a test.

# Running a test while generating a report

Run a test using the dotnet cli.

`dotnet test MSTests/ --logger html`

Create a TestResults directory under your TestProject, else the html file won't get generated under there.
This will also generate tests with a timestamp in the name.

To log to a specific test file

`dotnet test NUnitTests/ --logger "html;LogFileName=TestResults.html"`

To run all tests in solution

`dotnet test -v n`


## Advanced Unit Testing

FSUnit and UnQuote are F# unit testing frameworks.

## FSUnit

* Provides an english-like assertion syntax, but it's entirely F# code.
* Relies on an underlying testing framework to run the tests.
* Works with NUnit, XUnit, and MbUnit

Just add this to your regular NUnitTests.fsproj file. The nuget package for FsUnit.

`<PackageReference Include="FsUnit" Version="3.8.1" />`

Run dotnet restore and you can `open FsUnit`.

## UnQuote

* Uses F# quotations for writing test assertions.
* Quotations are in the form `<@ .. @>`.
* Inside a quotation you write plain F# expressions.

