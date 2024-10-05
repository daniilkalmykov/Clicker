using System.Runtime.CompilerServices;
using Sources.Scripts.Runtime.Models.Clients.Wallets;
using UnityEngine;

[assembly: InternalsVisibleTo("Assembly-CSharp")]
namespace Sources.Scripts.Runtime.Controllers.WalletControllers
{
    internal sealed class DefaultWalletController : IWalletController
    {
        private readonly IWallet _wallet;
        private readonly int _moneyToAdd;

        public DefaultWalletController(int moneyToAdd, IWallet wallet)
        {
            _moneyToAdd = moneyToAdd;
            _wallet = wallet;
        }
        
        public void AddMoney()
        {
            if (_wallet.TryAddMoney(_moneyToAdd) == false)
                Debug.LogError("Couldn't give money");

            Debug.Log(_wallet.Value);
        }
    }
}