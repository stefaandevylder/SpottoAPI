using SpottoAPI.Models.Property;
using SpottoAPI.Models.Resource;
using SpottoAPI.Models.Transaction;

namespace SpottoAPI.Models {

    public class SpottoListing {

        public SpottoProperty PropertyInfo { get; set; }

        public SpottoTransaction TransactionInfo { get; set; }

        public SpottoResource ResourcesInfo { get; set; }

        public SpottoListing(SpottoProperty property, SpottoTransaction transaction, SpottoResource resource) {
            PropertyInfo = property;
            TransactionInfo = transaction;
            ResourcesInfo = resource;
        }

    }

}
