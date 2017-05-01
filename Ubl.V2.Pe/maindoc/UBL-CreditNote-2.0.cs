using Ubl.V2.Pe.common;

namespace Ubl.V2.Pe.maindoc
{
    /// <summary>
    ///  The document used to specify credits due to the Debtor from the Creditor.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CreditNote-2")]
    [System.Xml.Serialization.XmlRootAttribute("CreditNote", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CreditNote-2", IsNullable=false)]
    public partial class CreditNoteType : UblBaseDocumentType
    {
        
        private IdentifierType idField;
        
        private IndicatorType copyIndicatorField;
        
        private IdentifierType uUIDField;
        
        private DateType issueDateField;
        
        private TimeType issueTimeField;
        
        private DateType taxPointDateField;
        
        private TextType[] noteField;
        
        private CurrencyCodeType documentCurrencyCodeField;
        
        private CurrencyCodeType taxCurrencyCodeField;
        
        private CurrencyCodeType pricingCurrencyCodeField;
        
        private CurrencyCodeType paymentCurrencyCodeField;
        
        private CurrencyCodeType paymentAlternativeCurrencyCodeField;
        
        private CodeType accountingCostCodeField;
        
        private TextType accountingCostField;
        
        private NumericType lineCountNumericField;
        
        private PeriodType[] invoicePeriodField;
        
        private ResponseType[] discrepancyResponseField;
        
        private OrderReferenceType orderReferenceField;
        
        private BillingReferenceType[] billingReferenceField;
        
        private DocumentReferenceType[] despatchDocumentReferenceField;
        
        private DocumentReferenceType[] receiptDocumentReferenceField;
        
        private DocumentReferenceType[] contractDocumentReferenceField;
        
        private DocumentReferenceType[] additionalDocumentReferenceField;
        
        private SignatureType[] signatureField;
        
        private SupplierPartyType accountingSupplierPartyField;
        
        private CustomerPartyType accountingCustomerPartyField;
        
        private PartyType payeePartyField;
        
        private PartyType taxRepresentativePartyField;
        
        private ExchangeRateType taxExchangeRateField;
        
        private ExchangeRateType pricingExchangeRateField;
        
        private ExchangeRateType paymentExchangeRateField;
        
        private ExchangeRateType paymentAlternativeExchangeRateField;
        
        private AllowanceChargeType[] allowanceChargeField;
        
        private TaxTotalType[] taxTotalField;
        
        private MonetaryTotalType legalMonetaryTotalField;
        
        private CreditNoteLineType[] creditNoteLineField;
        
        /// <summary>
        ///  An identifier for the Credit Note assigned by the Creditor.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
        
        /// <summary>
        ///  Indicates whether the Credit Note is a copy (true) or not (false).
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IndicatorType CopyIndicator
        {
            get
            {
                return this.copyIndicatorField;
            }
            set
            {
                this.copyIndicatorField = value;
            }
        }
        
        /// <summary>
        ///  A universally unique identifier for an instance of this ABIE.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType UUID
        {
            get
            {
                return this.uUIDField;
            }
            set
            {
                this.uUIDField = value;
            }
        }
        
        /// <summary>
        ///  The date assigned by the Creditor on which the Credit Note was issued.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DateType IssueDate
        {
            get
            {
                return this.issueDateField;
            }
            set
            {
                this.issueDateField = value;
            }
        }
        
        /// <summary>
        ///  The time assigned by the Creditor at which the Credit Note was issued.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TimeType IssueTime
        {
            get
            {
                return this.issueTimeField;
            }
            set
            {
                this.issueTimeField = value;
            }
        }
        
        /// <summary>
        ///  The date of the Credit Note used Indicates the point at which tax becomes applicable.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DateType TaxPointDate
        {
            get
            {
                return this.taxPointDateField;
            }
            set
            {
                this.taxPointDateField = value;
            }
        }
        
        /// <summary>
        ///  Free-form text applying to the Credit Note. This element may contain notes or any other similar information that is not contained explicitly in another structure.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Note", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType[] Note
        {
            get
            {
                return this.noteField;
            }
            set
            {
                this.noteField = value;
            }
        }
        
        /// <summary>
        ///  The default currency for the Credit Note.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CurrencyCodeType DocumentCurrencyCode
        {
            get
            {
                return this.documentCurrencyCodeField;
            }
            set
            {
                this.documentCurrencyCodeField = value;
            }
        }
        
        /// <summary>
        ///  The currency used for tax amounts in the Credit Note.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CurrencyCodeType TaxCurrencyCode
        {
            get
            {
                return this.taxCurrencyCodeField;
            }
            set
            {
                this.taxCurrencyCodeField = value;
            }
        }
        
        /// <summary>
        ///  The currency used for prices in the Credit Note.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CurrencyCodeType PricingCurrencyCode
        {
            get
            {
                return this.pricingCurrencyCodeField;
            }
            set
            {
                this.pricingCurrencyCodeField = value;
            }
        }
        
        /// <summary>
        ///  The currency used for payment in the Credit Note.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CurrencyCodeType PaymentCurrencyCode
        {
            get
            {
                return this.paymentCurrencyCodeField;
            }
            set
            {
                this.paymentCurrencyCodeField = value;
            }
        }
        
        /// <summary>
        ///  The alternative currency used for payment in the Credit Note.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CurrencyCodeType PaymentAlternativeCurrencyCode
        {
            get
            {
                return this.paymentAlternativeCurrencyCodeField;
            }
            set
            {
                this.paymentAlternativeCurrencyCodeField = value;
            }
        }
        
        /// <summary>
        ///  The Buyer's accounting code applied to the Credit Note as a whole.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType AccountingCostCode
        {
            get
            {
                return this.accountingCostCodeField;
            }
            set
            {
                this.accountingCostCodeField = value;
            }
        }
        
        /// <summary>
        ///  The Buyer's accounting code applied to the Credit Note as a whole, expressed as text.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType AccountingCost
        {
            get
            {
                return this.accountingCostField;
            }
            set
            {
                this.accountingCostField = value;
            }
        }
        
        /// <summary>
        ///  The number of lines in the document.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NumericType LineCountNumeric
        {
            get
            {
                return this.lineCountNumericField;
            }
            set
            {
                this.lineCountNumericField = value;
            }
        }
        
        /// <summary>
        ///  Associates the Credit Note with an Invoicing Period rather than a specific Invoice.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("InvoicePeriod", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PeriodType[] InvoicePeriod
        {
            get
            {
                return this.invoicePeriodField;
            }
            set
            {
                this.invoicePeriodField = value;
            }
        }
        
        /// <summary>
        ///  An association to a reason for the Credit Note as a whole.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("DiscrepancyResponse", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public ResponseType[] DiscrepancyResponse
        {
            get
            {
                return this.discrepancyResponseField;
            }
            set
            {
                this.discrepancyResponseField = value;
            }
        }
        
        /// <summary>
        ///  An association to Order Reference.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public OrderReferenceType OrderReference
        {
            get
            {
                return this.orderReferenceField;
            }
            set
            {
                this.orderReferenceField = value;
            }
        }
        
        /// <summary>
        ///  An association to Billing Reference.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("BillingReference", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public BillingReferenceType[] BillingReference
        {
            get
            {
                return this.billingReferenceField;
            }
            set
            {
                this.billingReferenceField = value;
            }
        }
        
        /// <summary>
        ///  An associative reference to Despatch Advice.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("DespatchDocumentReference", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public DocumentReferenceType[] DespatchDocumentReference
        {
            get
            {
                return this.despatchDocumentReferenceField;
            }
            set
            {
                this.despatchDocumentReferenceField = value;
            }
        }
        
        /// <summary>
        ///  An associative reference to Receipt Advice.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("ReceiptDocumentReference", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public DocumentReferenceType[] ReceiptDocumentReference
        {
            get
            {
                return this.receiptDocumentReferenceField;
            }
            set
            {
                this.receiptDocumentReferenceField = value;
            }
        }
        
        /// <summary>
        ///  An associative reference to Contract.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("ContractDocumentReference", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public DocumentReferenceType[] ContractDocumentReference
        {
            get
            {
                return this.contractDocumentReferenceField;
            }
            set
            {
                this.contractDocumentReferenceField = value;
            }
        }
        
        /// <summary>
        ///  An associative reference to Additional Document.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("AdditionalDocumentReference", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public DocumentReferenceType[] AdditionalDocumentReference
        {
            get
            {
                return this.additionalDocumentReferenceField;
            }
            set
            {
                this.additionalDocumentReferenceField = value;
            }
        }
        
        /// <summary>
        ///  An association to Signature.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Signature", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public SignatureType[] Signature
        {
            get
            {
                return this.signatureField;
            }
            set
            {
                this.signatureField = value;
            }
        }
        
        /// <summary>
        ///  An association to the Accounting Supplier Party.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public SupplierPartyType AccountingSupplierParty
        {
            get
            {
                return this.accountingSupplierPartyField;
            }
            set
            {
                this.accountingSupplierPartyField = value;
            }
        }
        
        /// <summary>
        ///  An association to the Accounting Customer Party.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public CustomerPartyType AccountingCustomerParty
        {
            get
            {
                return this.accountingCustomerPartyField;
            }
            set
            {
                this.accountingCustomerPartyField = value;
            }
        }
        
        /// <summary>
        ///  An association to the Payee.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PartyType PayeeParty
        {
            get
            {
                return this.payeePartyField;
            }
            set
            {
                this.payeePartyField = value;
            }
        }
        
        /// <summary>
        ///  An association to the Tax Representative.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PartyType TaxRepresentativeParty
        {
            get
            {
                return this.taxRepresentativePartyField;
            }
            set
            {
                this.taxRepresentativePartyField = value;
            }
        }
        
        /// <summary>
        ///  An association to Exchange Rate between the Document Currency and the Tax Currency.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public ExchangeRateType TaxExchangeRate
        {
            get
            {
                return this.taxExchangeRateField;
            }
            set
            {
                this.taxExchangeRateField = value;
            }
        }
        
        /// <summary>
        ///  An association to Exchange Rate between the Document Currency and the Pricing Currency.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public ExchangeRateType PricingExchangeRate
        {
            get
            {
                return this.pricingExchangeRateField;
            }
            set
            {
                this.pricingExchangeRateField = value;
            }
        }
        
        /// <summary>
        ///  An association to Exchange Rate between the Document Currency and the Payment Currency.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public ExchangeRateType PaymentExchangeRate
        {
            get
            {
                return this.paymentExchangeRateField;
            }
            set
            {
                this.paymentExchangeRateField = value;
            }
        }
        
        /// <summary>
        ///  An association to Exchange Rate between the Document Currency and the Payment Alternative Currency.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public ExchangeRateType PaymentAlternativeExchangeRate
        {
            get
            {
                return this.paymentAlternativeExchangeRateField;
            }
            set
            {
                this.paymentAlternativeExchangeRateField = value;
            }
        }
        
        /// <summary>
        ///  An association to Allowances and Charges that apply to the Credit Note as a whole.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("AllowanceCharge", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public AllowanceChargeType[] AllowanceCharge
        {
            get
            {
                return this.allowanceChargeField;
            }
            set
            {
                this.allowanceChargeField = value;
            }
        }
        
        /// <summary>
        ///  An association to Tax Total.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("TaxTotal", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public TaxTotalType[] TaxTotal
        {
            get
            {
                return this.taxTotalField;
            }
            set
            {
                this.taxTotalField = value;
            }
        }
        
        /// <summary>
        ///  An association to the total amount payable on the Credit Note, including Allowances, Charges, and Taxes.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public MonetaryTotalType LegalMonetaryTotal
        {
            get
            {
                return this.legalMonetaryTotalField;
            }
            set
            {
                this.legalMonetaryTotalField = value;
            }
        }
        
        /// <summary>
        ///  An association to one or more Credit Note Lines.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("CreditNoteLine", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public CreditNoteLineType[] CreditNoteLine
        {
            get
            {
                return this.creditNoteLineField;
            }
            set
            {
                this.creditNoteLineField = value;
            }
        }
    }
}
