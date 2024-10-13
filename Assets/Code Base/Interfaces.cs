using System;
using UnityEngine;

namespace Code_Base
{
    public interface IPlayer
    {
        public Transform Transform {get; set;}
        public float TimeModifare { get; set; }

        public void AddBullet();

    }
    
    public interface IEnemy
    {
        Transform Transform { get;  }
        
    }
    
    public interface IBulletSpawner
    {
        public event Action Shooting;
    }
    
    public interface IBulletsManager
    {
        public int BulletsScore { get; set; }
        public void Reload();
    }
    
    public interface IKillCounter
    {
        public void AddKill();
        public int CurrentKillScore { get; set; }
    }
    
    public interface ITimer
    {
        public void StopTimer();
        public string CurrentTimeOnString { get; set; }
        public float CurrentTimerValue { get; set; }
    }
    
    public interface IGameOver
    {
        public void OnGameOver();
    }
}
