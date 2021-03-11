namespace Messenger.Core.Mapping
{
    public interface IMapper<in TSource, out TResult>
    {
        TResult Map(TSource source);
    }
}