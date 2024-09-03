using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[assembly: InternalsVisibleTo("Assembly-CSharp")]
namespace Sources.Scripts.Runtime.Models.Systems.Input
{
    internal sealed class MobileInput : IInput
    {
        public event Action Clicked;
        
        public void OnUpdated()
        {
            if (UnityEngine.Input.touchCount == 0)
                return;

            if (UnityEngine.Input.touches[0].phase == TouchPhase.Began)
                Clicked?.Invoke();
        }
    }
}