using System.Linq;
using System.Reflection;
using JetBrains.Annotations;
using StructureMap;
using StructureMap.Graph;
using StructureMap.Graph.Scanning;

namespace Messenger.Core
{
    [UsedImplicitly]
    public sealed class Scanner<TLocator> : IRegistrationConvention
    {
        public void ScanTypes(TypeSet types, Registry registry)
        {
            var classes = typeof(TLocator).Assembly.GetTypes()
                .Where(type => type.GetCustomAttributes<IoCAttribute>() != null);

            foreach (var @class in classes)
            {
                foreach (var classInterface in @class.GetInterfaces())
                {
                    registry.For(classInterface).Use(@class);
                }
            }
        }
    }
}