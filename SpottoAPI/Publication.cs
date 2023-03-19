using SpottoAPI.Models;

namespace SpottoAPI {

    public class Publication {

        public string UniqueReference { get; set; }

        public string PartnerId { get; set; }

        public InputModel InputModel { get; set; }

        public bool? IsToBeArchived { get; set; }

        public Publication(string uniqueReference, string partnerId, InputModel model, bool isToBeArchived = false) {
            UniqueReference = uniqueReference;
            PartnerId = partnerId;
            InputModel = model;
            IsToBeArchived = isToBeArchived;
        }

    }

}
