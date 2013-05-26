Hi there!

The purpose of this sample is to demonstrate how one could build checked 
regular expressions using T4.

The inspiration to this came from: 
http://msdn.microsoft.com/en-us/library/hh361034.aspx

The link above showed among other things how to build checked regular 
expressions using Type Providers in F#. T4 can be used to solve similar
scenarios as those Type Providers aim to solve but T4 also supports C#,
VB, C++ and so on. Ie any textual programming language.

Checked regular expressions are great as they provide:

1. Compile-time/Design-time checking of the regular expression
2. Type-safe accessors to captured groups.

In practice this mean that for this expression:
```csharp
"(?<Year>[0-9]{4})\-(?<Month>[0-9]{2})\-(?<Day>[0-9]{2})"
```

You would typically access the captured groups as this:
```csharp
var year    = match.Groups["Year"].Value;
var month   = match.Groups["Month"].Value;
var day     = match.Groups["Day"].Value;
```

This code is fragile because if someone changes the names of the groups
in the regular expression the code breaks. 

Instead if one uses checked regular expressions you would access the 
groups as this:
```csharp
var year    = match.Year        ;
var month   = match.Month       ;
var day     = match.Day         ;
```

The interesting bits of this sample is:

+ Model   - Generated_CheckedRegex.tt -   Contains *what* checked regex
                                        to generate.
+ Template- Exceptions.ttinclude      -   Reusuable checked regex generator 
                                        template, can be shared between 
                                        projects

For example consider the first entry in the Model:
```csharp
R ("IniVariable"        , @"^(?<Variable>\S*)\s*\=\s*(?<Value>.*)$"),
````

This means we wish to parse an ini variable using the regular expression 
above.

The Template will then:

1. Validate the regular expression during design-time
2. Generate a couple of helper methods as extension methods
3. Generate a wrapper class around the Match with two properties; Variable and Value

The developer then can parse an ini variable row like this:
```csharp
var iniVariable = @"Path = C:\temp".Match_IniVariable ();
Console.WriteLine (iniVariable.GetSuccess ());
Console.WriteLine (iniVariable.Variable);
Console.WriteLine (iniVariable.Value);
```

This is what we want to achieve with Checked Regular Expressions.

Have fun @marten_range (twitter)
