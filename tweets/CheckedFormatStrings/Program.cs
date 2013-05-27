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

namespace CheckedFormatStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            // Checked formatting strings
            Console.WriteLine (Format.OneValue (1));
            Console.WriteLine (Format.TwoValues (1,2));
            Console.WriteLine (Format.TrickyCase (1));

        }
    }
}
