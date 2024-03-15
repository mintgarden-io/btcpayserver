using Newtonsoft.Json;

namespace BTCPayServer.Plugins.Altcoins.Chia.RPC.Models
{
    public partial class GetHeightInfoResponse
    {
        [JsonProperty("height")] public long Height { get; set; }
    }
}
