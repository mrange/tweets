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



// ReSharper disable InvocationIsSkipped
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart

namespace GeneratingExceptionClasses
{
    using System;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

 

    /// <summary>
    /// Represents AuthorizationRequired errors that occur during application execution.
     /// </summary>
    [Serializable]
    public partial class AuthorizationRequiredException : Exception
    {
        partial void Construct_AuthorizationRequiredException();
        partial void Serialize_AuthorizationRequiredException(SerializationInfo info, StreamingContext context);
        partial void Unserialize_AuthorizationRequiredException(SerializationInfo info);

        public AuthorizationRequiredException()
        {
            Construct_AuthorizationRequiredException();
        }
 
        public AuthorizationRequiredException(string message)
            : base(message)
        {
            Construct_AuthorizationRequiredException();
        }
 
        public AuthorizationRequiredException(string message, Exception inner)
            : base(message, inner)
        {
            Construct_AuthorizationRequiredException();
        }
 
        protected AuthorizationRequiredException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
            Unserialize_AuthorizationRequiredException(info);
            Construct_AuthorizationRequiredException();
        }
 
        [SecurityPermission(SecurityAction.Demand, SerializationFormatter = true)]
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            if (info == null)
            {
                throw new ArgumentNullException("info");
            }

            Serialize_AuthorizationRequiredException(info, context);

            base.GetObjectData(info, context);
        }
 
    }


    /// <summary>
    /// Represents BasicHttpAuthorizationRequired errors that occur during application execution.
     /// </summary>
    [Serializable]
    public partial class BasicHttpAuthorizationRequiredException : AuthorizationRequiredException
    {
        partial void Construct_BasicHttpAuthorizationRequiredException();
        partial void Serialize_BasicHttpAuthorizationRequiredException(SerializationInfo info, StreamingContext context);
        partial void Unserialize_BasicHttpAuthorizationRequiredException(SerializationInfo info);

        public BasicHttpAuthorizationRequiredException()
        {
            Construct_BasicHttpAuthorizationRequiredException();
        }
 
        public BasicHttpAuthorizationRequiredException(string message)
            : base(message)
        {
            Construct_BasicHttpAuthorizationRequiredException();
        }
 
        public BasicHttpAuthorizationRequiredException(string message, Exception inner)
            : base(message, inner)
        {
            Construct_BasicHttpAuthorizationRequiredException();
        }
 
        protected BasicHttpAuthorizationRequiredException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
            Unserialize_BasicHttpAuthorizationRequiredException(info);
            Construct_BasicHttpAuthorizationRequiredException();
        }
 
        [SecurityPermission(SecurityAction.Demand, SerializationFormatter = true)]
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            if (info == null)
            {
                throw new ArgumentNullException("info");
            }

            Serialize_BasicHttpAuthorizationRequiredException(info, context);

            base.GetObjectData(info, context);
        }
 
    }


    /// <summary>
    /// Represents WindowsAuthorizationRequired errors that occur during application execution.
     /// </summary>
    [Serializable]
    public partial class WindowsAuthorizationRequiredException : AuthorizationRequiredException
    {
        partial void Construct_WindowsAuthorizationRequiredException();
        partial void Serialize_WindowsAuthorizationRequiredException(SerializationInfo info, StreamingContext context);
        partial void Unserialize_WindowsAuthorizationRequiredException(SerializationInfo info);

        public WindowsAuthorizationRequiredException()
        {
            Construct_WindowsAuthorizationRequiredException();
        }
 
        public WindowsAuthorizationRequiredException(string message)
            : base(message)
        {
            Construct_WindowsAuthorizationRequiredException();
        }
 
        public WindowsAuthorizationRequiredException(string message, Exception inner)
            : base(message, inner)
        {
            Construct_WindowsAuthorizationRequiredException();
        }
 
        protected WindowsAuthorizationRequiredException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
            Unserialize_WindowsAuthorizationRequiredException(info);
            Construct_WindowsAuthorizationRequiredException();
        }
 
        [SecurityPermission(SecurityAction.Demand, SerializationFormatter = true)]
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            if (info == null)
            {
                throw new ArgumentNullException("info");
            }

            Serialize_WindowsAuthorizationRequiredException(info, context);

            base.GetObjectData(info, context);
        }
 
    }


    /// <summary>
    /// Represents FormsAuthorizationRequired errors that occur during application execution.
     /// </summary>
    [Serializable]
    public partial class FormsAuthorizationRequiredException : AuthorizationRequiredException
    {
        partial void Construct_FormsAuthorizationRequiredException();
        partial void Serialize_FormsAuthorizationRequiredException(SerializationInfo info, StreamingContext context);
        partial void Unserialize_FormsAuthorizationRequiredException(SerializationInfo info);

        public FormsAuthorizationRequiredException()
        {
            Construct_FormsAuthorizationRequiredException();
        }
 
        public FormsAuthorizationRequiredException(string message)
            : base(message)
        {
            Construct_FormsAuthorizationRequiredException();
        }
 
        public FormsAuthorizationRequiredException(string message, Exception inner)
            : base(message, inner)
        {
            Construct_FormsAuthorizationRequiredException();
        }
 
        protected FormsAuthorizationRequiredException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
            Unserialize_FormsAuthorizationRequiredException(info);
            Construct_FormsAuthorizationRequiredException();
        }
 
        [SecurityPermission(SecurityAction.Demand, SerializationFormatter = true)]
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            if (info == null)
            {
                throw new ArgumentNullException("info");
            }

            Serialize_FormsAuthorizationRequiredException(info, context);

            base.GetObjectData(info, context);
        }
 
    }


    /// <summary>
    /// Represents ClaimsAuthorizationRequired errors that occur during application execution.
     /// </summary>
    [Serializable]
    public partial class ClaimsAuthorizationRequiredException : AuthorizationRequiredException
    {
        partial void Construct_ClaimsAuthorizationRequiredException();
        partial void Serialize_ClaimsAuthorizationRequiredException(SerializationInfo info, StreamingContext context);
        partial void Unserialize_ClaimsAuthorizationRequiredException(SerializationInfo info);

        public ClaimsAuthorizationRequiredException()
        {
            Construct_ClaimsAuthorizationRequiredException();
        }
 
        public ClaimsAuthorizationRequiredException(string message)
            : base(message)
        {
            Construct_ClaimsAuthorizationRequiredException();
        }
 
        public ClaimsAuthorizationRequiredException(string message, Exception inner)
            : base(message, inner)
        {
            Construct_ClaimsAuthorizationRequiredException();
        }
 
        protected ClaimsAuthorizationRequiredException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
            Unserialize_ClaimsAuthorizationRequiredException(info);
            Construct_ClaimsAuthorizationRequiredException();
        }
 
        [SecurityPermission(SecurityAction.Demand, SerializationFormatter = true)]
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            if (info == null)
            {
                throw new ArgumentNullException("info");
            }

            Serialize_ClaimsAuthorizationRequiredException(info, context);

            base.GetObjectData(info, context);
        }
 
    }

}

