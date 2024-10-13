using UnityEngine;
using UnityEngine.UI;

namespace Code_Base
{
    public class KillCounter : MonoBehaviour, IKillCounter
    {  
        private IPlayer _player;
        [SerializeField] private Text _currentKillScoreText;

        public int CurrentKillScore { get; set; }


        void Start()
        {
            _currentKillScoreText.text = CurrentKillScore.ToString();
        }

        public void AddKill()
        {
            CurrentKillScore ++;
            ScoreUpdate();
        }


        private void ScoreUpdate()
        {
            _currentKillScoreText.text = CurrentKillScore.ToString();
        }
    }

 
}
