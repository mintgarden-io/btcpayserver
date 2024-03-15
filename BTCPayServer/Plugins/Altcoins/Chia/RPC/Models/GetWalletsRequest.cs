using Newtonsoft.Json;

namespace BTCPayServer.Plugins.Altcoins.Chia.RPC.Models
{
    public partial class GetWalletsRequest
    {
        [JsonProperty("type")] public int Type { get; set; }
    }
}
