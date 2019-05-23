using System;
using System.IO;

namespace G42.Helpers.Resources
{
    public interface IEmbeddedResourceHelper
    {
        string GetResource(string resourceLocation, Type type);
        Stream GetResourceStream(string resourceLocation, Type type);
    }
}
