using System;
using System.Diagnostics;

namespace G42.Helpers.Assembly
{
    public class AssemblyHelper : IAssemblyHelper
    {
        public string GetDllFileVersion(Type type)
        {
            var asm = System.Reflection.Assembly.GetAssembly(type);
            var fvi = FileVersionInfo.GetVersionInfo(asm.Location);

            return fvi.FileVersion;
        }
    }
}
