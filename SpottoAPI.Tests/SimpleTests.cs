using SpottoAPI.Models;
using SpottoAPI.Models.Property;
using SpottoAPI.Models.Resource;
using SpottoAPI.Models.Transaction;
using System.Collections.Generic;
using Xunit;
using Xunit.Abstractions;

namespace SpottoAPI.Tests {

    public class SimpleTests {

        private readonly ITestOutputHelper _output;
        private readonly SpottoClient _client;

        public SimpleTests(ITestOutputHelper output) {
            _output = output;
            _client = new SpottoClient("subcriptionKey", "partnerId");
        }

        [Fact]
        public void TestUpload() {
            SpottoListing listing = new SpottoListing(
                new SpottoProperty() {
                    Type = PropertyType.Apartment,
                    Descriptions = new List<Description> {
                        new Description(DescriptionType.ShortDescription, "nl", "Dit is een test.")
                    },
                    LocationInfo = new LocationInfo {
                        Address = new AddressInfo {
                            Street = "Ten Bos",
                            StreetNumber = "11",
                            MunicipalityPostalCode = "9100",
                            MunicipalityName = "Sint-Niklaas",
                        }
                    }
                }, 
                new SpottoTransaction() {
                    Type = TransactionType.Rent,
                    AvailabilityStatusType = AvailabilityStatusType.Available,
                    HidePriceDetails = false,
                    ContactInfo = new ContactInfo {
                        ContactPerson = new ContactPerson {
                            Email = "info@dnavastgoed.be",
                            Name = "D&A Vastgoed",
                            PhoneNumber = "03 776 19 22",
                            PictureUrl = "https://dnavastgoed.be/wp-content/uploads/2020/09/Logo-7x7-PNG.png"
                        }
                    },
                    RentTypeInfo = new RentTypeInfo {
                        Price = 800,
                        PricePeriod = RentalPricePeriod.Month,
                    }
                },
                new SpottoResource() {
                    Images = new List<Image> {
                        new Image {
                            IsMainImage = true,
                            DisplayOrder = 1,
                            FileName = "image.jpg",
                            Url = "https://dnavastgoed.be/wp-content/uploads/2020/09/Logo-7x7-PNG.png"
                        }
                    },
                    PublicationInfo = new PublicationInfo {
                        BrokerWebsiteUrl = "https://dnavastgoed.be/"
                    }
                }
             );
            _output.WriteLine(listing.ToString());
            Assert.NotNull(listing);
        }

    }
}