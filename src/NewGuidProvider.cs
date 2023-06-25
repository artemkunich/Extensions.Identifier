using System;

namespace Akunich.Extensions.Identifier;

internal class GuidIdentifierProvider : IIdentifierProvider<Guid>
{
    public Guid CreateNewId() => Guid.NewGuid();
}