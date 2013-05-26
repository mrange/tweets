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

namespace GeneratingExceptionClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine (@"
Hi there!

The purpose of this program is to show how to generate proper exceptions using 
T4.

This is a response to the excellent blog post: 
http://blogs.msdn.com/b/agileer/archive/2013/05/17/the-right-way-to-write-a-custom-exception-class.aspx


The blog post told us how an exception needs to look but didn't tell us how 
to avoid maintaining code pattern duplication that is intrinsic of exceptions 
classes 
(because C# lacks constructor forwarding).

Code-snippets is not the answer as they are the dark-side equivalent of 
programming.

Stay on the light-side and use a MetaProgramming tool like T4 to generate 
exceptions.

T4 is shipped in VS2008+ and the crucial difference between MetaProgramming and
snippets is that you don't lose the connection between the model and the 
generated code.

This is essential in order to refactor the generated code.

The T4 template is split into two parts.

Model   - Generated_Exceptions.tt  -    Contains *what* exceptions we like 
                                        to have generated.
Template- Exceptions.ttinclude     -    Reusuable exception generator 
                                        template, can be shared between 
                                        projects

In addition the example demonstrate how to use partial to extend generated 
exceptions with custom properties.

Have fun @marten_range (twitter)

Press any key to continue
");

            Console.ReadKey ();
            // Sample on how to use the generated exception.
            // Just like you normally would
            //throw new BasicHttpAuthorizationRequiredException
            //    {
            //        ResourceReferenceProperty = "This is the resource reference"        ,
            //    };
        }
    }
}
