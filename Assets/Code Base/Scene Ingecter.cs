using UnityEngine;
using UnityEngine.Serialization;
using Zenject;

namespace Code_Base
{
    public class SceneIngecter : MonoInstaller
    {
       [SerializeField]
        private Player player;

        [SerializeField]
        private BulletSpawner bulletSpawner;
        
        [SerializeField]
        private BulletsManager bulletsManager;
        
         [SerializeField]
        private GameOver gameOver;
        
        [SerializeField]
        private Timer timer;
      
        [SerializeField]
        private KillCounter killCounter;
        
       [SerializeField]
        private Music music;
      
        public override void InstallBindings()
        {
            Container
                .Bind<IPlayer>()
                .To<Player>()
                .FromInstance(player) 
                .AsSingle();
         
            Container
                .Bind<IBulletSpawner>()
                .To<BulletSpawner>()
                .FromInstance(bulletSpawner) 
                .AsSingle();
            
            Container
                .Bind<IBulletsManager>()
                .To<BulletsManager>()
                .FromInstance(bulletsManager) 
                .AsSingle();
            
            Container
                .Bind<IGameOver>()
                .To<GameOver>()
                .FromInstance(gameOver) 
                .AsSingle();

            Container
                .Bind<ITimer>()
                .To<Timer>()
                .FromInstance(timer)
                .AsSingle();
            
            Container
                .Bind<IKillCounter>()
                .To<KillCounter>()
                .FromInstance(killCounter)
                .AsSingle();
            
             Container
                .Bind<IMusic>()
                .To<Music>()
                .FromInstance(music)
                .AsSingle();
            
            

            
        }
    }
}