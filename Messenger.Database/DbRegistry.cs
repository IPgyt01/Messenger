using Messenger.Core;
using Messenger.Database.Context.Chats;
using Messenger.Database.Context.Users;
using StructureMap;

namespace Messenger.Database
{
    public sealed class DbRegistry : Registry
    {
        public DbRegistry()
        {
            Scan(s =>
            {
                s.TheCallingAssembly();
                s.Convention<Scanner<DbRegistry>>();
            });

            For(typeof(IChatContext)).Singleton();
            For(typeof(IUserContext)).Singleton();
        }
    }
}