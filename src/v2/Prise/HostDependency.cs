using System.Reflection;

namespace Prise.V2
{
    public class HostDependency
    {
        public AssemblyName DependencyName { get; set; }
        public bool AllowDowngrade { get; set; }
    }
}