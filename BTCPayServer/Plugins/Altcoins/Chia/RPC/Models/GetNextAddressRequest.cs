using Newtonsoft.Json;

namespace BTCPayServer.Plugins.Altcoins.Chia.RPC.Models
{
    public partial class GetNextAddressRequest
    {
        [JsonProperty("wallet_id")] public int WalletId { get; set; }
        [JsonProperty("new_address")] public bool NewAddress { get; set; }
    }
}
