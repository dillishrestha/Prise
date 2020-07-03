using Prise.Infrastructure;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.Versioning;

namespace Prise
{
    [DebuggerDisplay("{ProvideHostFramework()}")]
    public class HostFrameworkProvider : IHostFrameworkProvider
    {
        public virtual string ProvideHostFramework() => Assembly
            .GetEntryAssembly()?
            .GetCustomAttribute<TargetFrameworkAttribute>()?
            .FrameworkName;
    }
}
