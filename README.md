![alt text](https://github.com/Viincenttt/MollieApi/workflows/Run%20automated%20tests/badge.svg "Automated Tests")

# SpottoAPI for Dotnet Core in C#

An unofficial .NET wrapper for the Spotto.be API.

## Contributions

Have you spotted a bug or want to add a missing feature? All pull requests are welcome! Please provide a description of the bug or feature you have fixed/added. Make sure to target the latest development branch.

## 1. Installation

The easiest way to install is through the [NuGet](https://www.nuget.org/packages/SpottoAPI/) package.
```
PM> Install-Package SpottoAPI
```

## 2. Library limitations

The library has currently some limitations, only creating listings is possible. If this needs to be extended, please contact me or DIT ;)

## 3. Documentation

Official documentation can be found on the [Spotto](https://oris-prod-immox-apim.developer.azure-api.net/api-details#api=partner-uat&operation=CreatePublicationImport) API documentation.

## Examples
### Basic Example
```cs
// Create the client
SpottoClient client = new SpottoClient("SubscriptionKey", "PartnerId", isSandbox: true);

// Create the listing
SpottoListing listing = new SpottoListing(
    new SpottoProperty() {
        Type = PropertyType.Apartment,
        SubType = PropertySubType.Penthouse,
        PurposeType = PropertyPorposeType.Unknown,
        NewBuildType = PropertyNewBuildType.NoNewBuild,
        Descriptions = new List<Description> {
            new Description(DescriptionType.Title, "NL", "Dit is een test."),
            new Description(DescriptionType.DetailedDescription, "NL", "Dit is een lange test."),
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

//Post the listing
await client.CreatePublication(listing, "ID123");
```
This only contains the most basic options, there are a lot more, the documentation will get updated soon.
