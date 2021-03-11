using JetBrains.Annotations;
using Messenger.Core.Mapping;
using StructureMap;

namespace Messenger.Core
{
    [UsedImplicitly]
    public sealed class IoC : Registry
    {
        public IoC()
        {
            Scan(s =>
            {
                s.TheCallingAssembly();
                s.Convention<Scanner<IoC>>();
            });

            For(typeof(IMapper<,>)).Singleton();
        }
    }
}