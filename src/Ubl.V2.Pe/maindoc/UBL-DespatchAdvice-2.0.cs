using Ubl.V2.Pe.common;

namespace Ubl.V2.Pe.maindoc
{
    /// <summary>
    ///  The document used to describe the despatch or delivery of goods and services.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:DespatchAdvice-2")]
    [System.Xml.Serialization.XmlRootAttribute("DespatchAdvice", Namespace="urn:oasis:names:specification:ubl:schema:xsd:DespatchAdvice-2", IsNullable=false)]
    public partial class DespatchAdviceType : UblBaseDocumentType
    {
        
        private IdentifierType idField;
        
        private IndicatorType copyIndicatorField;
        
        private IdentifierType uUIDField;
        
        private DateType issueDateField;
        
        private TimeType issueTimeField;
        
        private DocumentStatusCodeType documentStatusCodeField;
        
        private CodeType despatchAdviceTypeCodeField;
        
        private TextType[] noteField;
        
        private NumericType lineCountNumericField;
        
        private OrderReferenceType[] orderReferenceField;
        
        private DocumentReferenceType[] additionalDocumentReferenceField;
        
        private SignatureType[] signatureField;
        
        private SupplierPartyType despatchSupplierPartyField;
        
        private CustomerPartyType deliveryCustomerPartyField;
        
        private CustomerPartyType buyerCustomerPartyField;
        
        private SupplierPartyType sellerSupplierPartyField;
        
        private CustomerPartyType originatorCustomerPartyField;
        
        private ShipmentType shipmentField;
        
        private DespatchLineType[] despatchLineField;
        
        /// <summary>
        ///  An identifier for the Despatch Advice assigned by Despatch (Party).
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
        ///  Indicates whether the Despatch Advice is a copy (true) or not (false).
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
        ///  The date assigned by Despatch (Party) on which the Despatch Advice was issued.
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
        ///  The time assigned by Despatch (Party) at which the Despatch Advice was issued.
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
        ///  Identifies the status of the Despatch Advice with respect to its original state. This may be used if the document precedes the event and is subsequently found to be incorrect and in need of cancelling or revising.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DocumentStatusCodeType DocumentStatusCode
        {
            get
            {
                return this.documentStatusCodeField;
            }
            set
            {
                this.documentStatusCodeField = value;
            }
        }
        
        /// <summary>
        ///  Identifies the type of the Despatch Advice.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType DespatchAdviceTypeCode
        {
            get
            {
                return this.despatchAdviceTypeCodeField;
            }
            set
            {
                this.despatchAdviceTypeCodeField = value;
            }
        }
        
        /// <summary>
        ///  Free-form text applying to the Despatch Advice. This element may contain notes or any other similar information that is not contained explicitly in another structure.
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
        ///  An association to Order Reference.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("OrderReference", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public OrderReferenceType[] OrderReference
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
        ///  An association to the Despatch Party.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public SupplierPartyType DespatchSupplierParty
        {
            get
            {
                return this.despatchSupplierPartyField;
            }
            set
            {
                this.despatchSupplierPartyField = value;
            }
        }
        
        /// <summary>
        ///  An association to the Delivery Customer Party.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public CustomerPartyType DeliveryCustomerParty
        {
            get
            {
                return this.deliveryCustomerPartyField;
            }
            set
            {
                this.deliveryCustomerPartyField = value;
            }
        }
        
        /// <summary>
        ///  An association to the Buyer.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public CustomerPartyType BuyerCustomerParty
        {
            get
            {
                return this.buyerCustomerPartyField;
            }
            set
            {
                this.buyerCustomerPartyField = value;
            }
        }
        
        /// <summary>
        ///  An association to the Seller.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public SupplierPartyType SellerSupplierParty
        {
            get
            {
                return this.sellerSupplierPartyField;
            }
            set
            {
                this.sellerSupplierPartyField = value;
            }
        }
        
        /// <summary>
        ///  An association to the Originator (Party).
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public CustomerPartyType OriginatorCustomerParty
        {
            get
            {
                return this.originatorCustomerPartyField;
            }
            set
            {
                this.originatorCustomerPartyField = value;
            }
        }
        
        /// <summary>
        ///  An association to Shipment.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public ShipmentType Shipment
        {
            get
            {
                return this.shipmentField;
            }
            set
            {
                this.shipmentField = value;
            }
        }
        
        /// <summary>
        ///  An association to one or more Despatch Advice Lines.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("DespatchLine", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public DespatchLineType[] DespatchLine
        {
            get
            {
                return this.despatchLineField;
            }
            set
            {
                this.despatchLineField = value;
            }
        }
    }
}
