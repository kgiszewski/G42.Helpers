using System;
using System.IO;

namespace G42.Helpers.Resources
{
    public class EmbeddedResourceHelper : IEmbeddedResourceHelper
    {
        public string GetResource(string resourceLocation, Type type = null)
        {
            using (var stream = GetResourceStream(resourceLocation, type))
            {
                if (stream == null)
                {
                    return string.Empty;
                }

                using (var reader = new StreamReader(stream))
                {
                    return reader.ReadToEnd();
                }
            }
        }

        public Stream GetResourceStream(string resourceLocation, Type type = null)
        {
            var assembly = type == null ? System.Reflection.Assembly.GetExecutingAssembly() : System.Reflection.Assembly.GetAssembly(type);

            return assembly.GetManifestResourceStream(resourceLocation);
        }
    }
}
