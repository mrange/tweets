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





// ReSharper disable InconsistentNaming
// ReSharper disable PartialTypeWithSinglePart

namespace CheckedFormatStrings
{
    using System.Globalization;
    using System.Threading;


    static partial class Format
    {

        public static CultureInfo DefaultCulture = Thread.CurrentThread.CurrentCulture;



        public const string FormatString_OneValue = @"Printing a value: {0}";

        public static string OneValue (
                object p0
        )
        {
            return string.Format (
                    DefaultCulture
                ,   FormatString_OneValue
                ,   p0
                );
        }



        public const string FormatString_TwoValues = @"Printing two values: {0}.{1}";

        public static string TwoValues (
                object p0
            ,   object p1
        )
        {
            return string.Format (
                    DefaultCulture
                ,   FormatString_TwoValues
                ,   p0
                ,   p1
                );
        }



        public const string FormatString_TrickyCase = @"{{{0}";

        public static string TrickyCase (
                object p0
        )
        {
            return string.Format (
                    DefaultCulture
                ,   FormatString_TrickyCase
                ,   p0
                );
        }

    }
}


