using System.Reflection;
using System.Runtime.Versioning;
using Prise.Infrastructure;

namespace Prise.IntegrationTestsHost
{
    /// <summary>
    /// This is required for testing
    /// </summary>
    public class AppHostFrameworkProvider : IHostFrameworkProvider
    {
        public string ProvideHostFramework() => typeof(AppHostFrameworkProvider).Assembly
            .GetCustomAttribute<TargetFrameworkAttribute>()?
            .FrameworkName;
    }
}