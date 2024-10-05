using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

[assembly: InternalsVisibleTo("Assembly-CSharp")]
namespace Sources.Scripts.Runtime.Views.WalletViews
{
    internal sealed class WalletView : MonoBehaviour, IWalletView
    {
        [SerializeField] private TMP_Text _text;
        
        public void UpdateText(int value)
        {
            _text.text = value.ToString();
        }
    }
}