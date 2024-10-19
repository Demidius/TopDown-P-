using System;

namespace Infrastructure.Services.Time
{
    public interface ITimeService : IService
    {
        event Action ChangeTimeScale;
        float TimeScale { get; set; }
        float DeltaTime { get; }
    }
}