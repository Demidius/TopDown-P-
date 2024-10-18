using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code_Base
{
    public class BulletsManager : Sounds, IBulletsManager
    {
        private IPlayer _player;
        [SerializeField] private Text _bulletsScoreText;
        private IBulletSpawner _bulletSpawner;

        [SerializeField] private Slider ammoSlider; // Ссылка на слайдер


        public int BulletsScore { get; set; } = 10;
        public int maxAmmo { get; set; } = 10;

        [Inject]
        private void Construct(IPlayer player, IBulletSpawner _bulletSpawner)
        {
            this._player = player;
            this._bulletSpawner = _bulletSpawner;
        }

        void Start()
        {
            _bulletSpawner.Shooting += Shoot;

            ammoSlider.maxValue = maxAmmo;
            ammoSlider.value = BulletsScore;
        }


        private void UpdateScore()
        {
            _bulletsScoreText.text = BulletsScore.ToString();
        }

        private void Shoot()
        {
            BulletsScore--;
            UpdateScore();
            ammoSlider.value = BulletsScore;
        }

        public void Reload()
        {
            if (BulletsScore < maxAmmo)
            {
                BulletsScore++;
                UpdateScore();
                PlaySound(0, volume: 0.5f);
            }
            else
            {
                PlaySound(1);
                StartCoroutine(FlashRedText());
            }

            ammoSlider.value = BulletsScore;
        }

        private IEnumerator FlashRedText()
        {
            Color originalColor = _bulletsScoreText.color;
            _bulletsScoreText.color = Color.red;
            yield return new WaitForSeconds(1f);
            _bulletsScoreText.color = originalColor;
        }

        private void OnDestroy()
        {
            _bulletSpawner.Shooting -= Shoot;
        }
    }
}