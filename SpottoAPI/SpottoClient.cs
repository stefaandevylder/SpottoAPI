using RestSharp;

namespace SpottoAPI {

    public class SpottoClient {

        private bool Sandbox { get; set; }
        private RestClient Client { get; set; }

        /// <summary>
        /// The URL we use to connect to the Spotto API.
        /// </summary>
        private string URL {
            get {
                return Sandbox ?
                    "https://api.spotto.be/uat/" :
                    "https://api.spotto.be/";
            }
        }

        private string SubscriptionKey { get; set; }
        private string PartnerId { get; set; }

        /// <summary>
        /// Creates the client for the Spotto API.
        /// </summary>
        /// <param name="subscriptionKey">The subscription key to authenticate</param>
        /// <param name="partnerId">The parner ID to authenticate</param>
        /// <param name="isSandbox">Wether to use UAT or not</param>
        /// <exception cref="ArgumentException"></exception>
        public SpottoClient(string subscriptionKey, string partnerId, bool isSandbox) {
            if (string.IsNullOrWhiteSpace(subscriptionKey) || string.IsNullOrWhiteSpace(partnerId)) {
                throw new ArgumentException("The subscription key or partner id cannot be empty.");
            }

            Sandbox = isSandbox;
            Client = new RestClient(URL);
            SubscriptionKey = subscriptionKey;
            PartnerId = partnerId;
        }

    }

}