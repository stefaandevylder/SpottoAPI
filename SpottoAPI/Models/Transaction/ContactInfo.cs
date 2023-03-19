namespace SpottoAPI.Models.Transaction {

    public class ContactInfo {

        public string? ContactReference { get; set; }

        public ContactPerson? ContactPerson { get; set; }

    }

    public class ContactPerson {

        public string? Email { get; set; }

        public string? Name { get; set; }

        public string? PhoneNumber { get; set; }

        public string? PictureUrl { get; set; }

    }
}
