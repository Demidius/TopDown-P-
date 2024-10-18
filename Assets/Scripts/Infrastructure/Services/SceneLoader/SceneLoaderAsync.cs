using System.Threading.Tasks;
using Extensions;

namespace Infrastructure.Services.SceneLoader
{
    public class SceneLoaderAsync : SceneLoaderBase, ISceneLoaderAsync
    {
        public async Task LoadAsync(SceneData scene)
        {
            if (IsCurrentScene(scene))
                return;

            await GetAsyncLoad(scene);
        }

        public async Task UnLoadAsync(SceneData scene) =>
            await GetAsyncUnLoad(scene);
    }
}


