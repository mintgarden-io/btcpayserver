using NBitcoin;

namespace BTCPayServer
{
    public partial class AltcoinsPlugin
    {
        public void InitChia(IServiceCollection services)
        {
            var network = new ChiaLikeSpecificBtcPayNetwork()
            {
                CryptoCode = "XCH",
                DisplayName = "Chia",
                Divisibility = 12,
                DefaultRateRules = new[]
                {
                    "XCH_X = XCH_USD * USD_X",
                    "XCH_USD = 23"
                },
                CryptoImagePath = "/imlegacy/chia.png",
                UriScheme = "chia"
            };

            var blockExplorerLink = ChainName == ChainName.Mainnet
                        ? "https://www.spacescan.io/coin/{0}"
                        : "https://testnet11.spacescan.io/coin/{0}";

            services.AddBTCPayNetwork(network)
                    .AddTransactionLinkProvider(new Payments.PaymentMethodId("XCH", PaymentTypes.BTCLike), new SimpleTransactionLinkProvider(blockExplorerLink));
        }
    }
    class SimpleTransactionLinkProvider : DefaultTransactionLinkProvider
    {
        public SimpleTransactionLinkProvider(string blockExplorerLink) : base(blockExplorerLink)
        {
        }

        public override string? GetTransactionLink(string paymentId)
        {
            if (string.IsNullOrEmpty(BlockExplorerLink))
                return null;
            return string.Format(CultureInfo.InvariantCulture, BlockExplorerLink, paymentId);
        }
    }
}
