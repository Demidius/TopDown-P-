using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code_Base
{
    public class Timer : MonoBehaviour, ITimer
    {
        [SerializeField] private Text timerText;
        public float CurrentTimerValue { get; set; }
        private bool isRunning = false;
        private IPlayer _player;
        public string CurrentTimeOnString { get; set; }

        [Inject]
        private void Construct(IPlayer player)
        {
            _player = player;
        }

        void Start()
        {
            ResetTimer();
            StartTimer();
            UpdateTimerUI();
        }

        void Update()
        {
            if (isRunning && _player != null)
            {
                CurrentTimerValue += Time.deltaTime * _player.TimeModifare;
                UpdateTimerUI();
            }
        }

        public void StartTimer()
        {
            CurrentTimerValue = 0f;
            isRunning = true;
        }

        public void StopTimer()
        {
            isRunning = false;
        }

        public void ResetTimer()
        {
            CurrentTimerValue = 0f;
            UpdateTimerUI();
        }

        private void UpdateTimerUI()
        {
            if (timerText == null) return;

            int minutes = Mathf.FloorToInt(CurrentTimerValue / 60);
            int seconds = Mathf.FloorToInt(CurrentTimerValue % 60);
            int milliseconds = Mathf.FloorToInt((CurrentTimerValue * 1000) % 1000);
            
            CurrentTimeOnString = $"{minutes:00}:{seconds:00}:{milliseconds:000}";
            timerText.text = CurrentTimeOnString;
        }
    }
}