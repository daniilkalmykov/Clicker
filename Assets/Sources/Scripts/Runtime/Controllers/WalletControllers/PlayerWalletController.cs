using Sources.Scripts.Runtime.Models.Clients.Wallets;
using Sources.Scripts.Runtime.Views.WalletViews;

namespace Sources.Scripts.Runtime.Controllers.WalletControllers
{
    internal sealed class PlayerWalletController : IWalletController
    {
        private readonly IWalletController _walletController;
        private readonly IWallet _wallet;
        private readonly IWalletView _walletView;

        public PlayerWalletController(IWalletController walletController, IWalletView walletView, IWallet wallet)
        {
            _walletController = walletController;
            _walletView = walletView;
            _wallet = wallet;
        }

        public void AddMoney(int money)
        {
            _walletController.AddMoney(money);
            _walletView.UpdateText(_wallet.Value);
        }
    }
}