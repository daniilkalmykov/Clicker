using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Assembly-CSharp")]
namespace Sources.Scripts.Runtime.Models.Clients.Wallets
{
    internal sealed class Wallet : IWallet
    {
        public Wallet(int coins = 0)
        {
            Value = coins;
        }

        public int Value { get; private set; }

        public bool TryAddMoney(int value)
        {
            if (value <= 0)
                return false;

            Value += value;

            return true;
        }
    }
}