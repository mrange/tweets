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

namespace GeneratingExceptionClasses
{
    using System.Runtime.Serialization;

    public partial class AuthorizationRequiredException
    {
        public string ResourceReferenceProperty { get; set; }

        partial void Serialize_AuthorizationRequiredException(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("ResourceReferenceProperty", ResourceReferenceProperty);
        }

        partial void Unserialize_AuthorizationRequiredException(SerializationInfo info)
        {
             ResourceReferenceProperty = info.GetString("ResourceReferenceProperty");
        } 
    }
}