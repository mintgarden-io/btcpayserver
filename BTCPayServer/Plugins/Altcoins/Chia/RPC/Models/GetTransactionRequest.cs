using Newtonsoft.Json;

namespace BTCPayServer.Plugins.Altcoins.Chia.RPC.Models
{
    public class GetTransactionRequest
    {
        [JsonProperty("transaction_id")] public string TransactionId { get; set; }
    }
}
