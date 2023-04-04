using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using RestSharp;
using SpottoAPI.Models;

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
                    "https://api.spotto.be/uat" :
                    "https://api.spotto.be/prod";
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
        public SpottoClient(string subscriptionKey, string partnerId, bool isSandbox = false) {
            if (string.IsNullOrWhiteSpace(subscriptionKey) || string.IsNullOrWhiteSpace(partnerId)) {
                throw new ArgumentException("The subscription key or partner id cannot be empty.");
            }

            Sandbox = isSandbox;
            Client = new RestClient(URL);
            SubscriptionKey = subscriptionKey;
            PartnerId = partnerId;
        }

        /// <summary>
        /// Create a publication.
        /// </summary>
        /// <param name="publication">The publication object</param>
        /// <returns>The RestResponse</returns>
        public Task<RestResponse> CreatePublication(SpottoListing listing, string uniqueReference, bool toBeArchived = false) {
            RestRequest req = new RestRequest("/partner/imports");
            req.AddJsonBody(JsonConvert.SerializeObject(new Publication(uniqueReference, PartnerId, listing, toBeArchived),
                new JsonSerializerSettings { 
                    ContractResolver = new CamelCasePropertyNamesContractResolver(),
                    NullValueHandling = NullValueHandling.Ignore,
                }));
            return Client.ExecutePostAsync(CreateRequest(req));
        }

        /// <summary>
        /// Adapt the request object with right subscription keys.
        /// </summary>
        /// <param name="requestMethod">Method to use</param>
        /// <param name="request">The rest request object</param>
        /// <returns>The adapted object to send</returns>
        private RestRequest CreateRequest(RestRequest request) {
            request.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:47.0) Gecko/20100101 Firefox/47.0");
            request.AddHeader("Content-Type", "application/json");
            request.AddQueryParameter("subscription-key", SubscriptionKey);

            return request;
        }

    }

}