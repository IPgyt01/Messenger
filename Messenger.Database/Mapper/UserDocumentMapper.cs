using JetBrains.Annotations;
using Messenger.Database.Documents;
using Messenger.Database.Models;

namespace Messenger.Database.Mapper
{
    public sealed class UserDocumentMapper : IMapper<User, UserDocument>, IMapper<UserDocument, User>
    {
        [CanBeNull]
        public UserDocument Map([CanBeNull] User source) => source is null 
            ? null 
            : new UserDocument
            {
                Id = source.Id,
                UserName = source.UserName,
                Login = source.Login,
                Password = source.Password,
                Chats = source.Chats,
                ProfileImage = source.ProfileImage,
            };

        [CanBeNull]
        public User Map([CanBeNull] UserDocument source) => source is null
            ? null
            : new User
            {
                Id = source.Id,
                UserName = source.UserName,
                Login = source.Login,
                Password = source.Password,
                Chats = source.Chats,
                ProfileImage = source.ProfileImage,
            };
    }
}