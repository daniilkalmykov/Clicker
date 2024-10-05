namespace Sources.Scripts.Runtime.Models.Clients.Wallets
{
    public interface IWallet
    {
        int Value { get; }
        
        bool TryAddMoney(int value);
    }
}