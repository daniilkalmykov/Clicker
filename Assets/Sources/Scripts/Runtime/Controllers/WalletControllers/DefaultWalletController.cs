using System.Runtime.CompilerServices;
using Sources.Scripts.Runtime.Models.Clients.Wallets;
using UnityEngine;

[assembly: InternalsVisibleTo("Assembly-CSharp")]
namespace Sources.Scripts.Runtime.Controllers.WalletControllers
{
    internal sealed class DefaultWalletController : IWalletController
    {
        private readonly IWallet _wallet;

        public DefaultWalletController(IWallet wallet)
        {
            _wallet = wallet;
        }
        
        public void AddMoney(int money)
        {
            if (_wallet.TryAddMoney(money) == false)
                Debug.LogError("Couldn't give money");
        }
    }
}