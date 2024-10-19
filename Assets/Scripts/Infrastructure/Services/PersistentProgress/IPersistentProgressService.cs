using Data;

namespace Infrastructure.Services.PersistentProgress
{
    public interface IPersistentProgressService
    {
        PlayerProgress PlayerProgress { get; set; }
        MapData MapProgress { get; set; }
    }
}
