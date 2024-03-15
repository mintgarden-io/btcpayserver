using System.Collections.Generic;
using Newtonsoft.Json;

namespace BTCPayServer.Plugins.Altcoins.Chia.RPC.Models
{
    public class GetFeeEstimateResponse
    {
        [JsonProperty("estimates")] public List<ulong> Estimates { get; set; }
    }
}
