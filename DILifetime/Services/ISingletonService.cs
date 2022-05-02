using System;

namespace DILifetime.Services
{
    public interface ISingletonService
    {
        Guid GetID();
    }
}