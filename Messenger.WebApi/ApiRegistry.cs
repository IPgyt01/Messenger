using System;
using JetBrains.Annotations;
using Messenger.Core;
using Messenger.WebApi.Helpers;
using StructureMap;

namespace Messenger.WebApi
{
    [UsedImplicitly]
    public sealed class ApiRegistry : Registry
    {
        public ApiRegistry()
        {
            Scan(s =>
            {
                s.TheCallingAssembly();
                s.Convention<Scanner<ApiRegistry>>();
            });

            For(typeof(IUserHelper)).Singleton();
            For(typeof(IChatHelper)).Singleton();
        }
    }
}