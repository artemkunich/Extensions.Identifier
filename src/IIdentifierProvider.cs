namespace Akunich.Extensions.Identifier;

public interface IIdentifierProvider<out TKey>
{
    TKey CreateNewId();
}