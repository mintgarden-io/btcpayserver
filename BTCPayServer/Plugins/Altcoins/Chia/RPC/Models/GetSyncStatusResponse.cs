using Newtonsoft.Json;

namespace BTCPayServer.Plugins.Altcoins.Chia.RPC.Models
{
    public partial class GetSyncStatusResponse
    {
        [JsonProperty("synced")] public bool Synced { get; set; }
        [JsonProperty("syncing")] public bool Syncing { get; set; }
    }
}
