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



// ############################################################################
// #                                                                          #
// #        ---==>  T H I S  F I L E  I S   G E N E R A T E D  <==---         #
// #                                                                          #
// # This means that any edits to the .cs file will be lost when its          #
// # regenerated. Changes should instead be applied to the corresponding      #
// # template file (.tt)                                                      #
// ############################################################################





// ReSharper disable InconsistentNaming

namespace StaticDapper
{
    using System;
    using System.Collections.Generic;
    using System.Data;


    partial class Customer
    {
        public Int64  Id        { get; set; }
        public String FirstName { get; set; }
        public String LastName  { get; set; }
    }
    
    static partial class SqlExtensions
    {

        /// <summary>
        /// Reads Customer instances from a IDataReader. 
        /// This method requires the order of fields to match the order of the columns
        /// </summary>
        /// <param name="dataReader">A IDataReader instance</param>
        /// <returns>A sequence of Customer instances</returns>
        public static IEnumerable<Customer> ReadFixedPos_Customer (this IDataReader dataReader)
        {
            if (dataReader == null)
            {
                yield break;
            }

            while (dataReader.Read ())
            {
                yield return new Customer
                {
                    Id        = dataReader.IsDBNull (0) ? default (Int64)          : dataReader.GetInt64                 (0),
                    FirstName = dataReader.IsDBNull (1) ? ""                       : dataReader.GetString                (1),
                    LastName  = dataReader.IsDBNull (2) ? ""                       : dataReader.GetString                (2),
                };
            }
        }

        /// <summary>
        /// Reads Customer instances from a IDataReader. 
        /// This method maps the fields with the columns by name.
        /// Additional and missing columns are ignored
        /// </summary>
        /// <param name="dataReader">A IDataReader instance</param>
        /// <returns>A sequence of Customer instances</returns>
        public static IEnumerable<Customer> Read_Customer (this IDataReader dataReader)
        {
            if (dataReader == null)
            {
                yield break;
            }

            var remapped_Id = -1;
            var remapped_FirstName = -1;
            var remapped_LastName = -1;

            var fieldCount = dataReader.FieldCount;
            for (var iter = 0; iter < fieldCount; ++iter)
            {
                switch (dataReader.GetName (iter) ?? "")
                {
                case @"ID":
                    remapped_Id = iter;
                    break;
                case @"FirstName":
                    remapped_FirstName = iter;
                    break;
                case @"LastName":
                    remapped_LastName = iter;
                    break;
                }
            }

            while (dataReader.Read ())
            {
                var result = new Customer ();

                if (remapped_Id > -1)
                {
                    result.Id        = dataReader.IsDBNull (remapped_Id) ? default (Int64) : dataReader.GetInt64 (remapped_Id);
                }

                if (remapped_FirstName > -1)
                {
                    result.FirstName = dataReader.IsDBNull (remapped_FirstName) ? "" : dataReader.GetString (remapped_FirstName);
                }

                if (remapped_LastName > -1)
                {
                    result.LastName  = dataReader.IsDBNull (remapped_LastName) ? "" : dataReader.GetString (remapped_LastName);
                }


                yield return result;
            }
        }

    }



    partial class Order
    {
        public Int64     Id          { get; set; }
        public String    InvoiceNo   { get; set; }
        public Decimal   TotalAmount { get; set; }
        public DateTime? Paid        { get; set; }
    }
    
    static partial class SqlExtensions
    {

        /// <summary>
        /// Reads Order instances from a IDataReader. 
        /// This method requires the order of fields to match the order of the columns
        /// </summary>
        /// <param name="dataReader">A IDataReader instance</param>
        /// <returns>A sequence of Order instances</returns>
        public static IEnumerable<Order> ReadFixedPos_Order (this IDataReader dataReader)
        {
            if (dataReader == null)
            {
                yield break;
            }

            while (dataReader.Read ())
            {
                yield return new Order
                {
                    Id          = dataReader.IsDBNull (0) ? default (Int64)          : dataReader.GetInt64                 (0),
                    InvoiceNo   = dataReader.IsDBNull (1) ? ""                       : dataReader.GetString                (1),
                    TotalAmount = dataReader.IsDBNull (2) ? default (Decimal)        : dataReader.GetDecimal               (2),
                    Paid        = dataReader.IsDBNull (3) ? default (DateTime?)      : dataReader.GetDateTime              (3),
                };
            }
        }

        /// <summary>
        /// Reads Customer instances from a IDataReader. 
        /// This method maps the fields with the columns by name.
        /// Additional and missing columns are ignored
        /// </summary>
        /// <param name="dataReader">A IDataReader instance</param>
        /// <returns>A sequence of Customer instances</returns>
        public static IEnumerable<Order> Read_Order (this IDataReader dataReader)
        {
            if (dataReader == null)
            {
                yield break;
            }

            var remapped_Id = -1;
            var remapped_InvoiceNo = -1;
            var remapped_TotalAmount = -1;
            var remapped_Paid = -1;

            var fieldCount = dataReader.FieldCount;
            for (var iter = 0; iter < fieldCount; ++iter)
            {
                switch (dataReader.GetName (iter) ?? "")
                {
                case @"ID":
                    remapped_Id = iter;
                    break;
                case @"InvoiceNo":
                    remapped_InvoiceNo = iter;
                    break;
                case @"TotalAmount":
                    remapped_TotalAmount = iter;
                    break;
                case @"Paid":
                    remapped_Paid = iter;
                    break;
                }
            }

            while (dataReader.Read ())
            {
                var result = new Order ();

                if (remapped_Id > -1)
                {
                    result.Id          = dataReader.IsDBNull (remapped_Id) ? default (Int64) : dataReader.GetInt64 (remapped_Id);
                }

                if (remapped_InvoiceNo > -1)
                {
                    result.InvoiceNo   = dataReader.IsDBNull (remapped_InvoiceNo) ? "" : dataReader.GetString (remapped_InvoiceNo);
                }

                if (remapped_TotalAmount > -1)
                {
                    result.TotalAmount = dataReader.IsDBNull (remapped_TotalAmount) ? default (Decimal) : dataReader.GetDecimal (remapped_TotalAmount);
                }

                if (remapped_Paid > -1)
                {
                    result.Paid        = dataReader.IsDBNull (remapped_Paid) ? default (DateTime?) : dataReader.GetDateTime (remapped_Paid);
                }


                yield return result;
            }
        }

    }



}


