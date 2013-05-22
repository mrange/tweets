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
using System.Linq.Expressions;
using System.Reflection;

namespace StaticReflection
{
    class Sample
    {
        public void OverloadedMethod (int x)
        {
            
        }

        public void OverloadedMethod (double x)
        {
            
        }
    }

    class Program
    {
      
        //                                  Expression<> <-- This is where the magic happens
        static MethodInfo GetMethodInfo<T> (Expression<Action<T>> expression)
        {
            return ((MethodCallExpression)expression.Body).Method;
        }


        static void Main(string[] args)
        {
            Console.WriteLine(@"
Hi there!

The purpose of this code is to demonstrate static reflection 
aka type-safe reflection.

Reflection is notorious for being fragile due to:
    1. Code obfuscation tools can break the code
    2. Adding an overloaded method can break the code
    3. Renaming methods can break the code

But this can all be avoided by using static reflection!

Static reflection relies on Expression trees introduced in
.NET 3.5.

The idea is to create an expression tree using the same 
technique as Linq to SQL uses to serialize a lambda 
expression into SQL.

The expression tree contains the method info which is 
returned. 

This technique can be extended to support properties, 
onstructors and so on.

See the code for an example on how to use static reflection.

Have fun @marten_range (twitter)
");


            // Note the code in the lambra expression will never be executed. It's implicitly 
            // converted into an expression tree and from that expression tree the method info
            // is extracted.

            // The right overloaded is picked by the compiler based on the standard overload rules
            var firstOverload = GetMethodInfo<Sample> (s => s.OverloadedMethod(default(int)));
            var secondOverload = GetMethodInfo<Sample> (s => s.OverloadedMethod(default(double)));

            Console.WriteLine("First overload: {0}", firstOverload);
            Console.WriteLine("Second overload: {0}", secondOverload);


        }
    }
}
