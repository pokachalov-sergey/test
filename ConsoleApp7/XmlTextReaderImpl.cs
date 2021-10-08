using System;
using System.Runtime.Serialization;

[Serializable]
internal class XmlTextReaderImpl : Exception
{
    public XmlTextReaderImpl()
    {
    }

    public XmlTextReaderImpl(string message) : base(message)
    {
    }

    public XmlTextReaderImpl(string message, Exception innerException) : base(message, innerException)
    {
    }

    protected XmlTextReaderImpl(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}