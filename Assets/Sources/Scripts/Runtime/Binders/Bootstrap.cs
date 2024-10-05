using UnityEngine;

namespace Sources.Scripts.Runtime.Binders
{
    internal sealed class Bootstrap : MonoBehaviour
    {
        [SerializeField] private Binder[] _binders;

        private void Reset()
        {
            _binders = GetComponentsInChildren<Binder>();
        }

        private void Awake()
        {
            foreach (var binder in _binders)
                binder.Bind();
        }
    }
}