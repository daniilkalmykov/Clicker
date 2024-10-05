using Reflex.Attributes;
using Sources.Scripts.Runtime.Controllers.WalletControllers;
using Sources.Scripts.Runtime.Models.Clients.Wallets;
using Sources.Scripts.Runtime.Models.Systems.Input;
using Sources.Scripts.Runtime.Views.WalletViews;
using UnityEngine;

namespace Sources.Scripts.Runtime.Binders
{
    internal sealed class PlayerBinder : Binder
    {
        [SerializeField] private WalletView _walletView;
        
        private IWallet _wallet;
        private IWalletController _walletController;
        private IInput _input;

        private void OnEnable()
        {
            _input.Clicked += OnClicked;
        }

        private void OnDisable()
        {
            _input.Clicked -= OnClicked;
        }

        [Inject]
        public void Construct(IInput input)
        {
            _input = input;
        }

        public override void Bind()
        {
            _walletView.UpdateText(0);
            _wallet = new Wallet();

            IWalletController walletController = new DefaultWalletController(_wallet);
            _walletController = new PlayerWalletController(walletController, _walletView, _wallet);
        }

        private void OnClicked()
        {
            _walletController.AddMoney(1);
        }
    }
}