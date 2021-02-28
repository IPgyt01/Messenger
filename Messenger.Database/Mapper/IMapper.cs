namespace Messenger.Database.Mapper
{
    public interface IMapper<in TSource, out TResult>
    {
        TResult Map(TSource source);
    }
}