using Reflex.Attributes;
using Sources.Scripts.Runtime.Controllers.WalletControllers;
using Sources.Scripts.Runtime.Models.Clients.Wallets;
using Sources.Scripts.Runtime.Models.Systems.Input;

namespace Sources.Scripts.Runtime.Binders
{
    internal sealed class PlayerBinder : Binder
    {
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
            _wallet = new Wallet();
            
            _walletController = new DefaultWalletController(_wallet);
        }

        private void OnClicked()
        {
            _walletController.AddMoney(1);
        }
    }
}