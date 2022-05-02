using System;

namespace DILifetime.Services
{
    public interface IScopedService
    {
        Guid GetID();
    }
}