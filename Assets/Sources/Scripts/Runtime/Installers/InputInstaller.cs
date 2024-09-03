using Reflex.Core;
using Sources.Scripts.Runtime.Models.Systems.Input;
using UnityEngine;

namespace Sources.Scripts.Runtime.Installers
{
    internal sealed class InputInstaller : MonoBehaviour, IInstaller
    {
        private IInput _input;

        private void Update()
        {
            _input.OnUpdated();
        }

        public void InstallBindings(ContainerBuilder containerBuilder)
        {
            _input = new MobileInput();

            containerBuilder.AddSingleton(_input, typeof(IInput));
        }
    }
}