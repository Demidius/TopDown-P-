using UnityEngine;

namespace Infrastructure.Services.Providers
{
    public interface ICameraProvider
    {
        public Camera Camera { get; set; }
    }
}