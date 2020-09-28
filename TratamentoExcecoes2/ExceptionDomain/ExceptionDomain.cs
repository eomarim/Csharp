using System;
using System.Collections;
using System.Runtime.Serialization;

namespace TratamentoExcecoes2.ExceptionDomain
{
    public class ExceptionDomain : ApplicationException{
        public ExceptionDomain(string message):base(message){}

        public override string GetMessage()
        {
            return base.GetMessage();
        }

        public override IDictionary Data
        {
            get
            {
                return base.Data;
            }
        }

        public override string GetStackTrace()
        {
            return base.GetStackTrace();
        }

        public override string GetHelpLink()
        {
            return base.GetHelpLink();
        }

        public override void SetHelpLink(string value)
        {
            base.SetHelpLink(value);
        }

        public override string GetSource()
        {
            return base.GetSource();
        }

        public override void SetSource(string value)
        {
            base.SetSource(value);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override Exception GetBaseException()
        {
            return base.GetBaseException();
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}