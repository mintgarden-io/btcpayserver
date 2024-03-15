namespace BTCPayServer.Plugins.Altcoins;

public class ChiaLikeSpecificBtcPayNetwork : BTCPayNetworkBase
{
    public int MaxTrackedConfirmation = 10;
    public string UriScheme { get; set; }
}
