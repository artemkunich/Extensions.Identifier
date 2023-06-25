using System;

namespace Akunich.Extensions.Identifier;

internal sealed class GuidIdentifierProvider : IIdentifierProvider<Guid>
{
    public Guid CreateNewId() => Guid.NewGuid();
}