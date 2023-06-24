using System;

namespace Akunich.Extensions.Identifier;

public class GuidIdentifierProvider : IIdentifierProvider<Guid>
{
    public Guid CreateNewId() => Guid.NewGuid();
}