namespace Code_Base
{
    public class Music : Sounds, IMusic
    {
      
        void Start()
        {
            PlaySound(0, p1: 1.2f, volume: 0.4f);
        }

        public void GameOverMusic()
        {
            StopSound();
            PlaySound(1, p1: 1f, volume: 0.5f);
        }
 
    }

    public interface IMusic
    {
        public void GameOverMusic();
    }
}