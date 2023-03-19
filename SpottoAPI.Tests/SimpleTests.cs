using SpottoAPI.Models;
using SpottoAPI.Models.Property;
using SpottoAPI.Models.Resource;
using SpottoAPI.Models.Transaction;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace SpottoAPI.Tests {

    public class SimpleTests {

        private readonly ITestOutputHelper _output;
        private readonly SpottoClient _client;

        public SimpleTests(ITestOutputHelper output) {
            _output = output;
            _client = new SpottoClient("SubscriptionKey", "PartnerId", true);
        }

        [Fact]
        public async Task TestUploadAsync() {
            SpottoListing listing = new SpottoListing(
                new SpottoProperty() {
                    Type = PropertyType.Apartment,
                    SubType = PropertySubType.Penthouse,
                    PurposeType = PropertyPorposeType.Unknown,
                    NewBuildType = PropertyNewBuildType.NoNewBuild,
                    Descriptions = new List<Description> {
                        new Description(DescriptionType.Title, "NL", "Dit is een test."),
                        new Description(DescriptionType.DetailedDescription, "NL", "Dit is een tesdfsdfsdfsdfst."),
                    },
                    Location = new LocationInfo {
                        Address = new AddressInfo {
                            Street = "Ten Bos",
                            StreetNumber = "11",
                            MunicipalityPostalCode = "9100",
                            MunicipalityName = "Sint-Niklaas",
                        }
                    }
                },
                new SpottoTransaction() {
                    Type = TransactionType.Sale,
                    AvailabilityStatusType = AvailabilityStatusType.Available,
                    HidePriceDetails = false,
                    ContactInfo = new ContactInfo {
                        ContactReference = "D&A Vastgoed",
                        ContactPerson = new ContactPerson {
                            Email = "info@dnavastgoed.be",
                            Name = "D&A Vastgoed",
                            PhoneNumber = "03 776 19 22",
                            PictureUrl = "https://dnavastgoed.be/wp-content/uploads/2020/09/Logo-7x7-PNG.png"
                        }
                    },
                    SaleTypeInfo = new SaleTypeInfo {
                        Price = 900000
                    }
                },
                new SpottoResource() {
                    Images = new List<Image> {
                        new Image {
                            DisplayOrder = 0,
                            FileName = "image",
                            FileType = ".png",
                            Url = "https://dnavastgoed.be/wp-content/uploads/2020/09/Logo-7x7-PNG.png"
                        }
                    },
                    PublicationInfo = new PublicationInfo {
                        BrokerWebsiteUrl = "https://dnavastgoed.be/"
                    }
                }
             );

            var result = await _client.CreatePublication(listing, "TEST1");
            _output.WriteLine(result.Content);
            Assert.True(result.IsSuccessful);
        }

    }
}