namespace Infrastructure.Services
{
    public interface ISwitchableService : IService
    {
        void SetActive(bool active);
    }
}
