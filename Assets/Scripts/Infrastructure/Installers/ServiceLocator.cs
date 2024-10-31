using Infrastructure.Services.Inputs;

namespace Infrastructure.Installers
{
    public class ServiceLocator
    {
        public IInputService InputService { get; }

        // Конструктор, принимающий зависимости напрямую
        public ServiceLocator(IInputService inputService)
        {
            InputService = inputService;
        }
    }
}