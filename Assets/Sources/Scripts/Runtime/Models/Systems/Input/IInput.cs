using System;

namespace Sources.Scripts.Runtime.Models.Systems.Input
{
    public interface IInput
    {
        event Action Clicked;

        void OnUpdated();
    }
}