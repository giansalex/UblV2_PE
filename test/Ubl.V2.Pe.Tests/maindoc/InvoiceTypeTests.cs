using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using Ubl.V2.Pe.common;
using Ubl.V2.Pe.maindoc;
using Xunit;

namespace Ubl.V2.Pe.Tests.maindoc
{
    public class InvoiceTypeTests
    {
        [Fact]
        private static void CreateInvoiceTest()
        {
            var invoice = CreateInvoiceSample();

            var serializer = new XmlSerializer(typeof(InvoiceType));
            var doc = new XmlDocument();

            using (var memXml = new MemoryStream())
            {
                serializer.Serialize(memXml, invoice);
                memXml.Seek(0, SeekOrigin.Begin);
                doc.Load(memXml);
            }

            var nameSpace = new XmlNamespaceManager(doc.NameTable);
            nameSpace.AddNamespace("cbc", "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2");
            var nodes = doc.DocumentElement.SelectNodes("//cbc:ID", nameSpace);

            Assert.True(nodes.Count > 0);
        }

        private static InvoiceType CreateInvoiceSample()
        {
            // Default that shpould be set when you load the library. Don't need to set it for each document.
            UblBaseDocumentType.GlbCustomizationID =
                "urn:oasis:names:specification:ubl:xpath:Invoice-2.0:sbs-1.0-draft";
            UblBaseDocumentType.GlbProfileID =
                "bpid:urn:oasis:names:draft:bpss:ubl-2-sbs-invoice-notification-draft";

            // Default value assinged to all amounts in this thread
            AmountType.TlsDefaultCurrencyID = "GBP";


            // This initialization will only work with C# 3.0 and above
            var res = new InvoiceType
            {
                // UBLVersionID = "2.0", Don't need to set this one. hardcoded in the library
                ID = "A00095678",
                CopyIndicator = false,
                UUID = "849FBBCE-E081-40B4-906C-94C5FF9D1AC3",
                IssueDate = new DateTime(2005, 6, 21),
                InvoiceTypeCode = "SalesInvoice",
                Note = new TextType[] { "sample" },
                TaxPointDate = new DateTime(2005, 6, 21),
                UBLExtensions = new[]
                {
                    new UBLExtensionType{
                        ExtensionContent = new AdditionalsInformationType
                                {
                                    AdditionalInformation = new AdditionalInformationType{
                                        AdditionalMonetaryTotal = new AdditionalMonetaryTotalType[]
                                          {
                                                new AdditionalMonetaryTotalType
                                                {
                                                    ID = "10001",
                                                    PayableAmount = 122.33M
                                                },
                                                new AdditionalMonetaryTotalType
                                                {
                                                    ID = "10002",
                                                    PayableAmount = 132.34M
                                                }
                                          },
                                        AdditionalProperty = new AdditionalPropertyType[]
                                        {
                                            new AdditionalPropertyType{
                                                ID = "1000",
                                                Value = "xxxxxxxxxxxxxxxxxxxxxx"
                                            }
                                        },
                                        SUNATEmbededDespatchAdvice = new SUNATEmbededDespatchAdviceType()
                                        {
                                            SUNATRoadTransport = new SUNATRoadTransportType[]
                                            {
                                                new SUNATRoadTransportType()
                                                {
                                                    LicensePlateID = "21312",
                                                    BrandName = "CHOF"
                                                }
                                            },
                                            SUNATCarrierParty = new SUNATCarrierPartyType()
                                            {
                                                AdditionalAccountID = new IdentifierType[]
                                                {
                                                    "2312"
                                                },
                                                CustomerAssignedAccountID = "432423"
                                            },
                                            OriginAddress = new AddressType()
                                            {
                                                CityName = "LIMA",
                                                Department = "LIMA"
                                            }
                                        },
                                        SUNATTransaction = new SUNATTransactionType()
                                        {
                                            ID = "DSFAS"
                                        }
                                    }
                                }
                    }
                },
                OrderReference = new OrderReferenceType
                {
                    ID = "AEG012345",
                    SalesOrderID = "CON0095678",
                    UUID = "6E09886B-DC6E-439F-82D1-7CCAC7F4E3B1",
                    IssueDate = new DateTime(2005, 6, 20)
                },
                AccountingSupplierParty = new SupplierPartyType
                {
                    CustomerAssignedAccountID = "CO001",
                    Party = new PartyType
                    {
                        PartyName = new PartyNameType[] { "Consortial" },
                        PostalAddress = new AddressType
                        {
                            StreetName = "Busy Street",
                            BuildingName = "Thereabouts",
                            BuildingNumber = "56A",
                            CityName = "Farthing",
                            PostalZone = "AA99 1BB",
                            CountrySubentity = "Heremouthshire",
                            AddressLine = new AddressLineType[] { "The Roundabout" },
                            Country = new CountryType { IdentificationCode = "GB" }
                        },
                        PartyTaxScheme = new PartyTaxSchemeType[]
                        {
                            new PartyTaxSchemeType
                            {
                                RegistrationName = "Farthing Purchasing Consortia",
                                CompanyID = "175 269 2355",
                                ExemptionReason = "N/A",
                                TaxScheme = new TaxSchemeType
                                {
                                    ID = "VAT",
                                    TaxTypeCode = "VAT"
                                }
                            }
                        },
                        Contact = new ContactType
                        {
                            Name = "Mrs Bouquet",
                            Telephone = "0158 1233714",
                            Telefax = "0158 1233856",
                            ElectronicMail = "bouquet@fpconsortial.co.uk",
                        }
                    }
                },
                AccountingCustomerParty = new CustomerPartyType
                {
                    CustomerAssignedAccountID = "XFB01",
                    SupplierAssignedAccountID = "GT00978567",
                    Party = new PartyType
                    {
                        PartyName = new PartyNameType[] { "IYT Corporation" },
                        PostalAddress = new AddressType
                        {
                            StreetName = "Avon Way",
                            BuildingName = "Thereabouts",
                            BuildingNumber = "56A",
                            CityName = "Bridgtow",
                            PostalZone = "ZZ99 1ZZ",
                            CountrySubentity = "Avon",
                            AddressLine = new AddressLineType[] { "3rd Floor, Room 5" },
                            Country = new CountryType { IdentificationCode = "GB" }
                        },
                        PartyTaxScheme = new PartyTaxSchemeType[]
                        {
                            new PartyTaxSchemeType
                            {
                                RegistrationName = "Bridgtow District Council",
                                CompanyID = "12356478",
                                ExemptionReason = "Local Authority",
                                TaxScheme = new TaxSchemeType { ID = "UK VAT", TaxTypeCode="VAT" }
                            }
                        },
                        Contact = new ContactType
                        {
                            Name = "Mr Fred Churchill",
                            Telephone = "0127 2653214",
                            Telefax = "0127 2653215",
                            ElectronicMail = "fred@iytcorporation.gov.uk"
                        }
                    }
                },
                Delivery = new DeliveryType[]
                {
                    new DeliveryType
                    {
                        ActualDeliveryDate = new DateTime(2005,6,20),
                        //ActualDeliveryTime = new DateTime(DateTime.Parse("11:30:00.0Z", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.AssumeUniversal).Ticks, DateTimeKind.Utc),
                        ActualDeliveryTime = new DateTime(2005,6,20,11,30,00,DateTimeKind.Utc), // MS DateTime xml serializing have a bug! Won't serialize time as utc, always local. 
                        DeliveryAddress = new AddressType
                        {
                            StreetName = "Avon Way",
                            BuildingName = "Thereabouts",
                            BuildingNumber = "56A",
                            CityName = "Bridgtow",
                            PostalZone = "ZZ99 1ZZ",
                            CountrySubentity = "Avon",
                            AddressLine = new AddressLineType[] { "3rd Floor, Room 5" },
                            Country = new CountryType { IdentificationCode = "GB"}
                        }
                    }
                },
                PaymentMeans = new PaymentMeansType[]
                {
                    new PaymentMeansType
                    {
                        PaymentMeansCode = "20",
                        PaymentDueDate = new DateTime(2005,7,21),
                        PayeeFinancialAccount = new FinancialAccountType
                        {
                            ID = "12345678",
                            Name = "Farthing Purchasing Consortia",
                            AccountTypeCode = "Current",
                            CurrencyCode = "GBP",
                            FinancialInstitutionBranch = new BranchType
                            {
                                ID = "10-26-58",
                                Name = "Open Bank Ltd, Bridgstow Branch ",
                                FinancialInstitution = new FinancialInstitutionType
                                {
                                    ID = "10-26-58",
                                    Name = "Open Bank Ltd",
                                    Address = new AddressType
                                    {
                                        StreetName = "City Road",
                                        BuildingName = "Banking House",
                                        BuildingNumber = "12",
                                        CityName = "London",
                                        PostalZone = "AQ1 6TH",
                                        CountrySubentity = "London",
                                        AddressLine = new AddressLineType[] {  "5th Floor" },
                                        Country = new CountryType { IdentificationCode = "GB" }
                                    }
                                },
                                Address = new AddressType
                                {
                                    StreetName = "Busy Street",
                                    BuildingName = "The Mall",
                                    BuildingNumber = "152",
                                    CityName = "Farthing",
                                    PostalZone = "AA99 1BB",
                                    CountrySubentity = "Heremouthshire",
                                    AddressLine = new AddressLineType[] { "West Wing" },
                                    Country = new CountryType {  IdentificationCode = "GB" }
                                }
                            },
                            Country = new CountryType { IdentificationCode = "GB" }
                        }
                    }
                },
                PaymentTerms = new PaymentTermsType[]
                {
                    new PaymentTermsType
                    {
                        Note = new TextType[] { "Payable within 1 calendar month from the invoice date" },
                    }
                },
                AllowanceCharge = new AllowanceChargeType[]
                {
                    new AllowanceChargeType
                    {
                        ChargeIndicator = false,
                        AllowanceChargeReasonCode = "17",
                        MultiplierFactorNumeric = 0.10M,
                        Amount = 10.00M
                    }
                },
                TaxTotal = new TaxTotalType[]
                {
                    new TaxTotalType
                    {
                        TaxAmount = 17.50M,
                        TaxEvidenceIndicator = true,
                        TaxSubtotal = new TaxSubtotalType[]
                        {
                            new TaxSubtotalType
                            {
                                TaxableAmount = 100.00M,
                                TaxAmount = 17.50M,
                                TaxCategory = new TaxCategoryType
                                {
                                    ID = "A",
                                    TaxScheme = new TaxSchemeType { ID = "UK VAT", TaxTypeCode = "VAT"}
                                }
                            }
                        }
                    }
                },
                LegalMonetaryTotal = new MonetaryTotalType
                {
                    LineExtensionAmount = 100.00M,
                    TaxExclusiveAmount = 90.00M,
                    AllowanceTotalAmount = 10.00M,
                    PayableAmount = 107.50M
                },
                InvoiceLine = new InvoiceLineType[]
                {
                    new InvoiceLineType
                    {
                        ID = "A",
                        InvoicedQuantity = new QuantityType{ unitCode="KG", Value=100 },
                        LineExtensionAmount = 100.00M,
                        OrderLineReference = new OrderLineReferenceType[]
                        {
                            new OrderLineReferenceType
                            {
                                LineID = "1",
                                SalesOrderLineID = "A",
                                LineStatusCode = "NoStatus",
                                OrderReference = new OrderReferenceType
                                {
                                    ID = "AEG012345",
                                    SalesOrderID = "CON0095678",
                                    UUID = "6E09886B-DC6E-439F-82D1-7CCAC7F4E3B1",
                                    IssueDate = new DateTime(2005,6,20)
                                }
                            }
                        },
                        TaxTotal = new TaxTotalType[]
                        {
                            new TaxTotalType
                            {
                                TaxAmount = 17.50M,
                                TaxEvidenceIndicator = true,
                                TaxSubtotal = new TaxSubtotalType[]
                                {
                                    new TaxSubtotalType
                                    {
                                        TaxableAmount = 100.00M,
                                        TaxAmount = 17.50M,
                                        TaxCategory = new TaxCategoryType
                                        {
                                            ID = "A",
                                            Percent = 17.5M,
                                            TaxScheme = new TaxSchemeType { ID = "UK VAT", TaxTypeCode = "VAT"}
                                        }
                                    }
                                }
                            }
                        },
                        Item = new ItemType
                        {
                            Description = new TextType[] { "Acme beeswax" },
                            Name = "beeswax",
                            BuyersItemIdentification = new ItemIdentificationType { ID = "6578489" },
                            SellersItemIdentification = new ItemIdentificationType { ID = "17589683" },
                            ItemInstance = new ItemInstanceType[]
                            {
                                new ItemInstanceType
                                {
                                    LotIdentification = new LotIdentificationType { LotNumberID = "546378239", ExpiryDate = new DateTime(2010,1,1) }
                                }
                            }
                        },
                        Price = new PriceType
                        {
                            PriceAmount = 1.00M,
                            BaseQuantity = new QuantityType{ unitCode="KG", Value = 1 }
                        }
                    }
                }
            };

            return res;
        }

    }
}
