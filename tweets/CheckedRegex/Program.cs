// ----------------------------------------------------------------------------------------------
// Copyright (c) Mårten Rånge.
// ----------------------------------------------------------------------------------------------
// This source code is subject to terms and conditions of the Microsoft Public License. A 
// copy of the license can be found in the License.html file at the root of this distribution. 
// If you cannot locate the  Microsoft Public License, please send an email to 
// dlr@microsoft.com. By using this source code in any fashion, you are agreeing to be bound 
//  by the terms of the Microsoft Public License.
// ----------------------------------------------------------------------------------------------
// You must not remove this notice, or any other, from this software.
// ----------------------------------------------------------------------------------------------

using System;

namespace CheckedRegex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine (@"
Hi there!

The purpose of this sample is to demonstrate how one could build checked 
regular expressions using T4.

The inspiration to this came from: 
http://msdn.microsoft.com/en-us/library/hh361034.aspx

The link above showed among other things how to build checked regular 
expressions using Type Providers in F#. T4 can be used to solve similar
scenarios as those Type Providers aim to solve but T4 also supports C#,
VB, C++ and so on. Ie any textual programming language.

Press any key to continue
");

            Console.ReadKey ();
            Console.WriteLine (@"
Checked regular expressions are great as they provide:
1. Compile-time/Design-time checking of the regular expression
2. Type-safe accessors to captured groups.

In practice this mean that for this expression:
(?<Year>[0-9]{4})\-(?<Month>[0-9]{2})\-(?<Day>[0-9]{2})

You would typically access the captured groups as this:
var year    = match.Groups[""Year""].Value;
var month   = match.Groups[""Month""].Value;
var day     = match.Groups[""Day""].Value;

This code is fragile because if someone changes the names of the groups
in the regular expression the code breaks. 

Instead if one uses checked regular expressions you would access the 
groups as this:

var year    = match.Year        ;
var month   = match.Month       ;
var day     = match.Day         ;

Press any key to continue        
");

            Console.ReadKey ();
            Console.WriteLine (@"
The interesting bits of this sample is:

Model   - Generated_CheckedRegex.tt -   Contains *what* checked regex
                                        to generate.
Template- Exceptions.ttinclude      -   Reusuable checked regex generator 
                                        template, can be shared between 
                                        projects

Press any key to continue        
");

            Console.ReadKey ();
            Console.WriteLine (@"
For example consider the first entry in the Model:
R (""IniVariable""        , @""^(?<Variable>\S*)\s*\=\s*(?<Value>.*)$""),

This means we wish to parse an ini variable using the regular expression 
above.

The Template will then:
1. Validate the regular expression during design-time
2. Generate a couple of helper methods as extension methods
3. Generate a wrapper class around the Match with two properties
    3.1. Variable   - The ini variable name
    3.2. Value      - The ini variable value

The developer then can parse an ini variable row like this:
var iniVariable = @""Path = C:\temp"".Match_IniVariable ();
Console.WriteLine (iniVariable.GetSuccess ());
Console.WriteLine (iniVariable.Variable);
Console.WriteLine (iniVariable.Value);

This is what we want to achieve with Checked Regular Expressions.

Have fun @marten_range (twitter)

Press any key to continue
");

            Console.ReadKey ();

            Console.WriteLine ("Sample output:");

            var date        = @"2013-05-23".Match_Date ();
            var dateTime    = @"2013-05-23T13:37:00".Match_DateTime ();
            var iniVariable = @"Path = C:\temp".Match_IniVariable ();

            Console.WriteLine (date);
            Console.WriteLine (dateTime);
            Console.WriteLine (iniVariable);

            Console.WriteLine (iniVariable.GetSuccess ());
            Console.WriteLine (iniVariable.Variable);
            Console.WriteLine (iniVariable.Value);

        }
    }
}
