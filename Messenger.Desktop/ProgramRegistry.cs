using JetBrains.Annotations;
using Messenger.Core;
using StructureMap;

namespace Messenger.Desktop
{
    [UsedImplicitly]
    public sealed class ProgramRegistry : Registry
    {
        public ProgramRegistry()
        {
            Scan(s =>
            {
                s.TheCallingAssembly();
                s.Convention<Scanner<ProgramRegistry>>();
            });
        }
    }
}