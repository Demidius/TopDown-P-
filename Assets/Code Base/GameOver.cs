using System;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code_Base
{
    public class GameOver : MonoBehaviour, IGameOver
    {
        [SerializeField] private GameObject gameOverPanel;
        [SerializeField] private Text gameOverText;
        private IKillCounter _killCounter;
        private ITimer _timer;
        private IMusic _music;

        [Inject]
        private void Construct(IKillCounter killCounter, ITimer timer, IMusic music)
        {
            _killCounter = killCounter;
            _timer = timer;
            _music = music;
        }

        public void OnGameOver()
        {
            
            gameOverPanel.SetActive(true); 
            gameOverText.text = $"Score: {_killCounter.CurrentKillScore} \nTime: {_timer.CurrentTimeOnString} \n \n Kills per second: {_killCounter.CurrentKillScore / _timer.CurrentTimerValue : 0.0}";
            _music.GameOverMusic();
        }
    }
}

