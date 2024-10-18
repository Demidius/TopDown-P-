using System.Threading.Tasks;

namespace Infrastructure.Services.SceneLoader
{
    public interface ISceneLoaderAsync : IService
    {
        Task LoadAsync(SceneData scene);
        Task UnLoadAsync(SceneData scene);
    }
}