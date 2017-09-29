namespace Ubl.V2.Pe.common
{
    /// <summary>
    /// Information about a Consolidated Invoice Line.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:sunat:names:specification:ubl:peru:schema:xsd:SunatAggregateComponents-1")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:sunat:names:specification:ubl:peru:schema:xsd:SunatAggregateComponents-1", IsNullable = false)]
    public partial class SummaryDocumentsLineType
    {

        private IdentifierType lineIDField;

        private CodeType documentTypeCodeField;

        private IdentifierType _idField;

        private IdentifierType documentSerialIDField;

        private IdentifierType startDocumentNumberIDField;

        private IdentifierType endDocumentNumberIDField;

        private CustomerPartyType _accountingCustomerPartyField;

        private StatusType _statusField;

        private BillingReferenceType[] _billingReferenceField;

        private AmountType totalAmountField;

        private PaymentType[] billingPaymentField;

        private AllowanceChargeType[] allowanceChargeField;

        private TaxTotalType[] taxTotalField;

        /// <summary>
        /// Identifies the Consolidated  Invoice Line
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType LineID
        {
            get
            {
                return this.lineIDField;
            }
            set
            {
                this.lineIDField = value;
            }
        }

        /// <summary>
        /// Code specifying the type of the Invoice.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType DocumentTypeCode
        {
            get
            {
                return this.documentTypeCodeField;
            }
            set
            {
                this.documentTypeCodeField = value;
            }
        }

        /// <summary>
        ///  An identifier for the SummaryDocumentsLine.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType ID
        {
            get
            {
                return this._idField;
            }
            set
            {
                this._idField = value;
            }
        }

        /// <summary>
        /// An association to Billing Payment.
        /// </summary>
        public IdentifierType DocumentSerialID
        {
            get
            {
                return this.documentSerialIDField;
            }
            set
            {
                this.documentSerialIDField = value;
            }
        }

        /// <summary>
        /// An association to Billing Payment.
        /// </summary>
        public IdentifierType StartDocumentNumberID
        {
            get
            {
                return this.startDocumentNumberIDField;
            }
            set
            {
                this.startDocumentNumberIDField = value;
            }
        }

        /// <summary>
        /// An association to End Invoice Number.
        /// </summary>
        public IdentifierType EndDocumentNumberID
        {
            get
            {
                return this.endDocumentNumberIDField;
            }
            set
            {
                this.endDocumentNumberIDField = value;
            }
        }

        /// <summary>
        ///  An association to the Accounting Customer Party.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public CustomerPartyType AccountingCustomerParty
        {
            get
            {
                return this._accountingCustomerPartyField;
            }
            set
            {
                this._accountingCustomerPartyField = value;
            }
        }

        /// <summary>
        ///  An association to Billing Reference.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("BillingReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public BillingReferenceType[] BillingReference
        {
            get
            {
                return this._billingReferenceField;
            }
            set
            {
                this._billingReferenceField = value;
            }
        }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        /// <value>The status.</value>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public StatusType Status
        {
            get { return _statusField; }
            set { _statusField = value; }
        }

        /// <summary>
        /// Code specifying the type of the Invoice.
        /// </summary>
        public AmountType TotalAmount
        {
            get
            {
                return this.totalAmountField;
            }
            set
            {
                this.totalAmountField = value;
            }
        }

        /// <summary>
        /// An association to Billing Payment. 0..n
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("BillingPayment")]
        public PaymentType[] BillingPayment
        {
            get
            {
                return this.billingPaymentField;
            }
            set
            {
                this.billingPaymentField = value;
            }
        }

        /// <summary>
        /// An association to Allowance Charge.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("AllowanceCharge", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
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
        /// An association to Tax Total.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("TaxTotal", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
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
    }

    /// <summary>
    /// Information about a Consolidated Invoice Line.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:sunat:names:specification:ubl:peru:schema:xsd:SunatAggregateComponents-1")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:sunat:names:specification:ubl:peru:schema:xsd:SunatAggregateComponents-1", IsNullable = false)]
    public partial class VoidedDocumentsLineType
    {

        private IdentifierType lineIDField;

        private CodeType documentTypeCodeField;

        private IdentifierType documentSerialIDField;

        private IdentifierType documentNumberIDField;

        private TextType voidReasonDescriptionField;

        /// <summary>
        /// Identifies the Consolidated  Invoice Line.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType LineID
        {
            get
            {
                return this.lineIDField;
            }
            set
            {
                this.lineIDField = value;
            }
        }

        /// <summary>
        /// Code specifying the type of the Invoice.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType DocumentTypeCode
        {
            get
            {
                return this.documentTypeCodeField;
            }
            set
            {
                this.documentTypeCodeField = value;
            }
        }

        /// <summary>
        /// An association to Billing Payment.
        /// </summary>
        public IdentifierType DocumentSerialID
        {
            get
            {
                return this.documentSerialIDField;
            }
            set
            {
                this.documentSerialIDField = value;
            }
        }

        /// <summary>
        /// An association to Billing Payment.
        /// </summary>
        public IdentifierType DocumentNumberID
        {
            get
            {
                return this.documentNumberIDField;
            }
            set
            {
                this.documentNumberIDField = value;
            }
        }

        /// <summary>
        /// An association to Void Reason.
        /// </summary>
        public TextType VoidReasonDescription
        {
            get
            {
                return this.voidReasonDescriptionField;
            }
            set
            {
                this.voidReasonDescriptionField = value;
            }
        }
    }

    /// <summary>
    ///  AdditionalInformationType fue agregado modificando el código fuente de la dll, por motivos que son Tags que la SUNAT agregó al requerimiento.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:sunat:names:specification:ubl:peru:schema:xsd:SunatAggregateComponents-1")]
    public partial class AdditionalsInformationType
    {
        private AdditionalInformationType additionalInformation;

        /// <summary>
        /// Gets or sets the additional information.
        /// </summary>
        /// <value>The additional information.</value>
        public AdditionalInformationType AdditionalInformation
        {
            get
            {
                return this.additionalInformation;
            }
            set
            {
                this.additionalInformation = value;
            }
        }

    }

    /// <summary>
    /// Information about a Consolidated Invoice Line.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AdditionalInformationType", Namespace = "urn:sunat:names:specification:ubl:peru:schema:xsd:SunatAggregateComponents-1")]
    [System.Xml.Serialization.XmlRootAttribute("AdditionalInformation", Namespace = "urn:sunat:names:specification:ubl:peru:schema:xsd:SunatAggregateComponents-1", IsNullable = false)]
    public partial class AdditionalInformationType
    {

        private AdditionalMonetaryTotalType[] additionalMonetaryTotalField;

        private AdditionalPropertyType[] additionalPropertyField;

        private SUNATTransactionType sUNATTransactionField;

        private SUNATEmbededDespatchAdviceType sUNATEmbededDespatchAdviceField;

        /// <summary>
        /// Identifies the Consolidated  Invoice Line.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("AdditionalMonetaryTotal")]
        public AdditionalMonetaryTotalType[] AdditionalMonetaryTotal
        {
            get
            {
                return this.additionalMonetaryTotalField;
            }
            set
            {
                this.additionalMonetaryTotalField = value;
            }
        }

        /// <summary>
        /// Code specifying the type of the Invoice.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("AdditionalProperty")]
        public AdditionalPropertyType[] AdditionalProperty
        {
            get
            {
                return this.additionalPropertyField;
            }
            set
            {
                this.additionalPropertyField = value;
            }
        }

        /// <summary>
        /// Transaction 
        /// </summary>
        public SUNATTransactionType SUNATTransaction
        {
            get
            {
                return this.sUNATTransactionField;
            }
            set
            {
                this.sUNATTransactionField = value;
            }
        }

        /// <summary>
        /// Embeded Despatch Advice
        /// </summary>
        public SUNATEmbededDespatchAdviceType SUNATEmbededDespatchAdvice
        {
            get
            {
                return this.sUNATEmbededDespatchAdviceField;
            }
            set
            {
                this.sUNATEmbededDespatchAdviceField = value;
            }
        }
    }

    /// <summary>
    /// Information about a Consolidated Invoice Line.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:sunat:names:specification:ubl:peru:schema:xsd:SunatAggregateComponents-1")]
    [System.Xml.Serialization.XmlRootAttribute("AdditionalMonetaryTotal", Namespace = "urn:sunat:names:specification:ubl:peru:schema:xsd:SunatAggregateComponents-1", IsNullable = false)]
    public partial class AdditionalMonetaryTotalType
    {

        private IdentifierType idField;

        private NameType nameField;

        private AmountType referenceAmountField;

        private AmountType payableAmountField;

        private PercentType percentField;

        private AmountType totalAmountField;

        /// <summary>
        /// An association to Billing Payment.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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
        /// An association to Allowance Charge.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NameType Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <summary>
        /// An association to Billing Payment.
        /// </summary>
        public AmountType ReferenceAmount
        {
            get
            {
                return this.referenceAmountField;
            }
            set
            {
                this.referenceAmountField = value;
            }
        }

        /// <summary>
        /// An association to Billing Payment.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AmountType PayableAmount
        {
            get
            {
                return this.payableAmountField;
            }
            set
            {
                this.payableAmountField = value;
            }
        }

        /// <summary>
        /// An association to Allowance Charge.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PercentType Percent
        {
            get
            {
                return this.percentField;
            }
            set
            {
                this.percentField = value;
            }
        }

        /// <summary>
        /// An association to Tax Total.
        /// </summary>
        public AmountType TotalAmount
        {
            get
            {
                return this.totalAmountField;
            }
            set
            {
                this.totalAmountField = value;
            }
        }
    }

    /// <summary>
    /// Information about a Consolidated Invoice Line.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:sunat:names:specification:ubl:peru:schema:xsd:SunatAggregateComponents-1")]
    [System.Xml.Serialization.XmlRootAttribute("AdditionalProperty", Namespace = "urn:sunat:names:specification:ubl:peru:schema:xsd:SunatAggregateComponents-1", IsNullable = false)]
    public partial class AdditionalPropertyType
    {

        private IdentifierType idField;

        private NameType nameField;

        private TextType valueField;

        /// <summary>
        /// An association to Billing Payment.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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
        /// An association to Allowance Charge.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NameType Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <summary>
        /// An association to Tax Total.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <summary>
    /// Transaction
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:sunat:names:specification:ubl:peru:schema:xsd:SunatAggregateComponents-1")]
    [System.Xml.Serialization.XmlRootAttribute("SUNATTransaction", Namespace = "urn:sunat:names:specification:ubl:peru:schema:xsd:SunatAggregateComponents-1", IsNullable = false)]
    public partial class SUNATTransactionType
    {

        private IdentifierType idField;

        /// <summary>
        /// Id
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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
    }

    /// <summary>
    /// Embeded Despatch Advice
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:sunat:names:specification:ubl:peru:schema:xsd:SunatAggregateComponents-1")]
    [System.Xml.Serialization.XmlRootAttribute("SUNATEmbededDespatchAdvice", Namespace = "urn:sunat:names:specification:ubl:peru:schema:xsd:SunatAggregateComponents-1", IsNullable = false)]
    public partial class SUNATEmbededDespatchAdviceType
    {

        private AddressType deliveryAddressField;

        private AddressType originAddressField;

        private SUNATCarrierPartyType sUNATCarrierPartyField;

        private DriverPartyType driverPartyField;

        private SUNATRoadTransportType[] sUNATRoadTransportField;

        private TransportModeCodeType _transportModeCode;

        private MeasureType _grossWeightMeasureField;

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public AddressType DeliveryAddress
        {
            get
            {
                return this.deliveryAddressField;
            }
            set
            {
                this.deliveryAddressField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public AddressType OriginAddress
        {
            get
            {
                return this.originAddressField;
            }
            set
            {
                this.originAddressField = value;
            }
        }

        /// <comentarios/>
        public SUNATCarrierPartyType SUNATCarrierParty
        {
            get
            {
                return this.sUNATCarrierPartyField;
            }
            set
            {
                this.sUNATCarrierPartyField = value;
            }
        }

        /// <comentarios/>
        public DriverPartyType DriverParty
        {
            get
            {
                return this.driverPartyField;
            }
            set
            {
                this.driverPartyField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute("SUNATRoadTransport")]
        public SUNATRoadTransportType[] SUNATRoadTransport
        {
            get
            {
                return this.sUNATRoadTransportField;
            }
            set
            {
                this.sUNATRoadTransportField = value;
            }
        }

        /// <summary>
        /// Gets or sets the transport mode code.
        /// </summary>
        /// <value>The transport mode code.</value>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TransportModeCodeType TransportModeCode
        {
            get
            {
                return this._transportModeCode;
            }
            set
            {
                this._transportModeCode = value;
            }
        }

        /// <summary>
        ///  The total gross weight of a shipment; the weight of the goods plus packaging plus transport equipment.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MeasureType GrossWeightMeasure
        {
            get
            {
                return this._grossWeightMeasureField;
            }
            set
            {
                this._grossWeightMeasureField = value;
            }
        }
    }

    /// <summary>
    /// Shipment
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:sunat:names:specification:ubl:peru:schema:xsd:SunatAggregateComponents-1")]
    [System.Xml.Serialization.XmlRootAttribute("SUNATShipment", Namespace = "urn:sunat:names:specification:ubl:peru:schema:xsd:SunatAggregateComponents-1", IsNullable = false)]
    public partial class SUNATShipmentType
    {

        private MeasureType grossWeightMeasureField;

        private AddressType deliveryAddressField;

        private AddressType originAddressField;

        private AddressType oldDeliveryAddressField;

        private AddressType oldOriginAddressField;

        private SUNATShipmentStageType[] sUNATShipmentStageField;

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MeasureType GrossWeightMeasure
        {
            get
            {
                return this.grossWeightMeasureField;
            }
            set
            {
                this.grossWeightMeasureField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public AddressType DeliveryAddress
        {
            get
            {
                return this.deliveryAddressField;
            }
            set
            {
                this.deliveryAddressField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public AddressType OriginAddress
        {
            get
            {
                return this.originAddressField;
            }
            set
            {
                this.originAddressField = value;
            }
        }

        /// <comentarios/>
        public AddressType OldDeliveryAddress
        {
            get
            {
                return this.oldDeliveryAddressField;
            }
            set
            {
                this.oldDeliveryAddressField = value;
            }
        }

        /// <comentarios/>
        public AddressType OldOriginAddress
        {
            get
            {
                return this.oldOriginAddressField;
            }
            set
            {
                this.oldOriginAddressField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute("SUNATShipmentStage")]
        public SUNATShipmentStageType[] SUNATShipmentStage
        {
            get
            {
                return this.sUNATShipmentStageField;
            }
            set
            {
                this.sUNATShipmentStageField = value;
            }
        }
    }

    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:sunat:names:specification:ubl:peru:schema:xsd:SunatAggregateComponents-1")]
    [System.Xml.Serialization.XmlRootAttribute("SUNATShipmentStage", Namespace = "urn:sunat:names:specification:ubl:peru:schema:xsd:SunatAggregateComponents-1", IsNullable = false)]
    public partial class SUNATShipmentStageType
    {

        private IdentifierType idField;

        private IdentifierType shipmentStageTypeCodeField;

        private TransportModeCodeType transportModeCodeField;

        private CodeType transportMeansTypeCodeField;

        private SUNATCarrierPartyType sUNATCarrierPartyField;

        private SUNATTransportMeansType sUNATTransportMeansField;

        private AddressType originAddressField;

        private AddressType deliveryAddressField;

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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

        /// <comentarios/>
        public IdentifierType ShipmentStageTypeCode
        {
            get
            {
                return this.shipmentStageTypeCodeField;
            }
            set
            {
                this.shipmentStageTypeCodeField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TransportModeCodeType TransportModeCode
        {
            get
            {
                return this.transportModeCodeField;
            }
            set
            {
                this.transportModeCodeField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType TransportMeansTypeCode
        {
            get
            {
                return this.transportMeansTypeCodeField;
            }
            set
            {
                this.transportMeansTypeCodeField = value;
            }
        }

        /// <comentarios/>
        public SUNATCarrierPartyType SUNATCarrierParty
        {
            get
            {
                return this.sUNATCarrierPartyField;
            }
            set
            {
                this.sUNATCarrierPartyField = value;
            }
        }

        /// <comentarios/>
        public SUNATTransportMeansType SUNATTransportMeans
        {
            get
            {
                return this.sUNATTransportMeansField;
            }
            set
            {
                this.sUNATTransportMeansField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public AddressType OriginAddress
        {
            get
            {
                return this.originAddressField;
            }
            set
            {
                this.originAddressField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public AddressType DeliveryAddress
        {
            get
            {
                return this.deliveryAddressField;
            }
            set
            {
                this.deliveryAddressField = value;
            }
        }
    }

    /// <summary>
    /// Transport Means
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:sunat:names:specification:ubl:peru:schema:xsd:SunatAggregateComponents-1")]
    [System.Xml.Serialization.XmlRootAttribute("SUNATTransportMeans", Namespace = "urn:sunat:names:specification:ubl:peru:schema:xsd:SunatAggregateComponents-1", IsNullable = false)]
    public partial class SUNATTransportMeansType : TransportMeansType
    {

        private DriverPartyType[] driverPartyField;

        private SUNATRoadTransportType[] sUNATRoadTransportField;

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute("DriverParty")]
        public DriverPartyType[] DriverParty
        {
            get
            {
                return this.driverPartyField;
            }
            set
            {
                this.driverPartyField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute("SUNATRoadTransport")]
        public SUNATRoadTransportType[] SUNATRoadTransport
        {
            get
            {
                return this.sUNATRoadTransportField;
            }
            set
            {
                this.sUNATRoadTransportField = value;
            }
        }
    }

    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:sunat:names:specification:ubl:peru:schema:xsd:SunatAggregateComponents-1")]
    [System.Xml.Serialization.XmlRootAttribute("SUNATRoadTransport", Namespace = "urn:sunat:names:specification:ubl:peru:schema:xsd:SunatAggregateComponents-1", IsNullable = false)]
    public partial class SUNATRoadTransportType : RoadTransportType
    {

        private CodeType transportMeansTypeCodeField;

        private CodeType transportAuthorizationCodeField;

        private RoadTransportType[] semiTrailerField;

        private NameType brandNameField;

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType TransportMeansTypeCode
        {
            get
            {
                return this.transportMeansTypeCodeField;
            }
            set
            {
                this.transportMeansTypeCodeField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType TransportAuthorizationCode
        {
            get
            {
                return this.transportAuthorizationCodeField;
            }
            set
            {
                this.transportAuthorizationCodeField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute("SemiTrailer")]
        public RoadTransportType[] SemiTrailer
        {
            get
            {
                return this.semiTrailerField;
            }
            set
            {
                this.semiTrailerField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NameType BrandName
        {
            get
            {
                return this.brandNameField;
            }
            set
            {
                this.brandNameField = value;
            }
        }
    }


    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:sunat:names:specification:ubl:peru:schema:xsd:SunatAggregateComponents-1")]
    [System.Xml.Serialization.XmlRootAttribute("SUNATDespatchLine", Namespace = "urn:sunat:names:specification:ubl:peru:schema:xsd:SunatAggregateComponents-1", IsNullable = false)]
    public partial class SUNATDespatchLineType
    {

        private IdentifierType idField;

        private IdentifierType uUIDField;

        private TextType noteField;

        private LineStatusCodeType lineStatusCodeField;

        private QuantityType deliveredQuantityField;

        private QuantityType backorderQuantityField;

        private TextType backorderReasonField;

        private QuantityType outstandingQuantityField;

        private TextType outstandingReasonField;

        private QuantityType oversupplyQuantityField;

        private OrderLineReferenceType[] orderLineReferenceField;

        private DocumentReferenceType[] documentReferenceField;

        private ItemType itemField;

        private MeasureType grossWeightMeasureField;

        private ShipmentType[] shipmentField;

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType Note
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

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LineStatusCodeType LineStatusCode
        {
            get
            {
                return this.lineStatusCodeField;
            }
            set
            {
                this.lineStatusCodeField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public QuantityType DeliveredQuantity
        {
            get
            {
                return this.deliveredQuantityField;
            }
            set
            {
                this.deliveredQuantityField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public QuantityType BackorderQuantity
        {
            get
            {
                return this.backorderQuantityField;
            }
            set
            {
                this.backorderQuantityField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType BackorderReason
        {
            get
            {
                return this.backorderReasonField;
            }
            set
            {
                this.backorderReasonField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public QuantityType OutstandingQuantity
        {
            get
            {
                return this.outstandingQuantityField;
            }
            set
            {
                this.outstandingQuantityField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType OutstandingReason
        {
            get
            {
                return this.outstandingReasonField;
            }
            set
            {
                this.outstandingReasonField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public QuantityType OversupplyQuantity
        {
            get
            {
                return this.oversupplyQuantityField;
            }
            set
            {
                this.oversupplyQuantityField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute("OrderLineReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public OrderLineReferenceType[] OrderLineReference
        {
            get
            {
                return this.orderLineReferenceField;
            }
            set
            {
                this.orderLineReferenceField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute("DocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public DocumentReferenceType[] DocumentReference
        {
            get
            {
                return this.documentReferenceField;
            }
            set
            {
                this.documentReferenceField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public ItemType Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MeasureType GrossWeightMeasure
        {
            get
            {
                return this.grossWeightMeasureField;
            }
            set
            {
                this.grossWeightMeasureField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute("Shipment", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public ShipmentType[] Shipment
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
    }

    /// <summary>
    /// Driver Party
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:sunat:names:specification:ubl:peru:schema:xsd:SunatAggregateComponents-1")]
    [System.Xml.Serialization.XmlRootAttribute("DriverParty", Namespace = "urn:sunat:names:specification:ubl:peru:schema:xsd:SunatAggregateComponents-1", IsNullable = false)]
    public partial class DriverPartyType
    {

        private IdentifierType customerAssignedAccountIDField;

        private IdentifierType[] additionalAccountIDField;

        private PartyType partyField;

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType CustomerAssignedAccountID
        {
            get
            {
                return this.customerAssignedAccountIDField;
            }
            set
            {
                this.customerAssignedAccountIDField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute("AdditionalAccountID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType[] AdditionalAccountID
        {
            get
            {
                return this.additionalAccountIDField;
            }
            set
            {
                this.additionalAccountIDField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PartyType Party
        {
            get
            {
                return this.partyField;
            }
            set
            {
                this.partyField = value;
            }
        }
    }

    /// <summary>
    /// Sunat Carrier
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:sunat:names:specification:ubl:peru:schema:xsd:SunatAggregateComponents-1")]
    [System.Xml.Serialization.XmlRootAttribute("SUNATCarrierParty", Namespace = "urn:sunat:names:specification:ubl:peru:schema:xsd:SunatAggregateComponents-1", IsNullable = false)]
    public partial class SUNATCarrierPartyType
    {

        private IdentifierType customerAssignedAccountIDField;

        private IdentifierType[] additionalAccountIDField;

        private CodeType transportAuthorizationCodeField;

        private IndicatorType outsourcedIndicatorField;

        private PartyType partyField;

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType CustomerAssignedAccountID
        {
            get
            {
                return this.customerAssignedAccountIDField;
            }
            set
            {
                this.customerAssignedAccountIDField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute("AdditionalAccountID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType[] AdditionalAccountID
        {
            get
            {
                return additionalAccountIDField;
            }
            set
            {
                additionalAccountIDField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType TransportAuthorizationCode
        {
            get
            {
                return this.transportAuthorizationCodeField;
            }
            set
            {
                this.transportAuthorizationCodeField = value;
            }
        }

        /// <comentarios/>
        public IndicatorType OutsourcedIndicator
        {
            get
            {
                return this.outsourcedIndicatorField;
            }
            set
            {
                this.outsourcedIndicatorField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PartyType Party
        {
            get
            {
                return this.partyField;
            }
            set
            {
                this.partyField = value;
            }
        }
    }

    /// <summary>
    /// Delivery Date
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:sunat:names:specification:ubl:peru:schema:xsd:SunatAggregateComponents-1")]
    [System.Xml.Serialization.XmlRootAttribute("DeliveryCarrierDate", Namespace = "urn:sunat:names:specification:ubl:peru:schema:xsd:SunatAggregateComponents-1", IsNullable = false)]
    public partial class DeliveryCarrierDateType : DateType
    {
    }

    /// <summary>
    /// Sunat Fiscal Path
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:sunat:names:specification:ubl:peru:schema:xsd:SunatAggregateComponents-1")]
    [System.Xml.Serialization.XmlRootAttribute("SUNATFiscalPath", Namespace = "urn:sunat:names:specification:ubl:peru:schema:xsd:SunatAggregateComponents-1", IsNullable = false)]
    public partial class SUNATFiscalPathType
    {

        private IdentifierType idField;

        private NameType nameField;

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NameType Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    #region Retencion
    /// <summary>
    /// SunatRetentionInformation
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:sunat:names:specification:ubl:peru:schema:xsd:SunatAggregateComponents-1")]
    [System.Xml.Serialization.XmlRootAttribute("SUNATRetentionInformation", Namespace = "urn:sunat:names:specification:ubl:peru:schema:xsd:SunatAggregateComponents-1", IsNullable = false)]
    public partial class SUNATRetentionInformationType
    {

        private AmountType _sUNATRetentionAmount;

        private DateType _sUNATRetentionDate;

        private AmountType _sUNATNetTotalPaid;

        private ExchangeRateType _exchangeRate;

        /// <comentarios/>
        public AmountType SUNATRetentionAmount
        {
            get
            {
                return this._sUNATRetentionAmount;
            }
            set
            {
                this._sUNATRetentionAmount = value;
            }
        }
        /// <comentarios/>
        public DateType SUNATRetentionDate
        {
            get
            {
                return this._sUNATRetentionDate;
            }
            set
            {
                this._sUNATRetentionDate = value;
            }
        }
        /// <comentarios/>
        public AmountType SUNATNetTotalPaid
        {
            get
            {
                return this._sUNATNetTotalPaid;
            }
            set
            {
                this._sUNATNetTotalPaid = value;
            }
        }
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public ExchangeRateType ExchangeRate
        {
            get
            {
                return this._exchangeRate;
            }
            set
            {
                this._exchangeRate = value;
            }
        }
    }
    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:sunat:names:specification:ubl:peru:schema:xsd:SunatAggregateComponents-1")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:sunat:names:specification:ubl:peru:schema:xsd:SunatAggregateComponents-1", IsNullable = false)]
    public partial class SUNATRetentionDocumentReferenceType
    {

        private IdentifierType _id;

        private DateType _issueDate;

        private AmountType _totalInvoiceAmount;

        private PaymentType[] _payment;

        private SUNATRetentionInformationType _sUNATRetentionInformation;
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType ID
        {
            get
            {
                return this._id;
            }
            set
            {
                this._id = value;
            }
        }
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DateType IssueDate
        {
            get
            {
                return this._issueDate;
            }
            set
            {
                this._issueDate = value;
            }
        }
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AmountType TotalInvoiceAmount
        {
            get
            {
                return this._totalInvoiceAmount;
            }
            set
            {
                this._totalInvoiceAmount = value;
            }
        }
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute("Payment", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PaymentType[] Payment
        {
            get
            {
                return this._payment;
            }
            set
            {
                this._payment = value;
            }
        }
        /// <comentarios/>
        public SUNATRetentionInformationType SUNATRetentionInformation
        {
            get
            {
                return this._sUNATRetentionInformation;
            }
            set
            {
                this._sUNATRetentionInformation = value;
            }
        }
    }
    #endregion

    #region Percepcion
    /// <summary>
    /// Sunat Percepcion Informacion
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:sunat:names:specification:ubl:peru:schema:xsd:SunatAggregateComponents-1")]
    [System.Xml.Serialization.XmlRootAttribute("SUNATPerceptionInformation", Namespace = "urn:sunat:names:specification:ubl:peru:schema:xsd:SunatAggregateComponents-1", IsNullable = false)]
    public partial class SUNATPerceptionInformationType
    {

        private AmountType _sUNATPerceptionAmount;

        private DateType _sUNATPerceptionDate;

        private AmountType _sUNATNetTotalCashed;

        private ExchangeRateType _exchangeRate;

        /// <comentarios/>
        public AmountType SUNATPerceptionAmount
        {
            get
            {
                return this._sUNATPerceptionAmount;
            }
            set
            {
                this._sUNATPerceptionAmount = value;
            }
        }
        /// <comentarios/>
        public DateType SUNATPerceptionDate
        {
            get
            {
                return this._sUNATPerceptionDate;
            }
            set
            {
                this._sUNATPerceptionDate = value;
            }
        }
        /// <comentarios/>
        public AmountType SUNATNetTotalCashed
        {
            get
            {
                return this._sUNATNetTotalCashed;
            }
            set
            {
                this._sUNATNetTotalCashed = value;
            }
        }
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public ExchangeRateType ExchangeRate
        {
            get
            {
                return this._exchangeRate;
            }
            set
            {
                this._exchangeRate = value;
            }
        }
    }
    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:sunat:names:specification:ubl:peru:schema:xsd:SunatAggregateComponents-1")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:sunat:names:specification:ubl:peru:schema:xsd:SunatAggregateComponents-1", IsNullable = false)]
    public partial class SUNATPerceptionDocumentReferenceType
    {

        private IdentifierType _id;

        private DateType _issueDate;

        private AmountType _totalInvoiceAmount;

        private PaymentType[] _payment;

        private SUNATPerceptionInformationType _sUNATPerceptionInformation;
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType ID
        {
            get
            {
                return this._id;
            }
            set
            {
                this._id = value;
            }
        }
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DateType IssueDate
        {
            get
            {
                return this._issueDate;
            }
            set
            {
                this._issueDate = value;
            }
        }
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AmountType TotalInvoiceAmount
        {
            get
            {
                return this._totalInvoiceAmount;
            }
            set
            {
                this._totalInvoiceAmount = value;
            }
        }
        /// <comentarios/>
        [System.Xml.Serialization.XmlElement("Payment", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PaymentType[] Payment
        {
            get
            {
                return this._payment;
            }
            set
            {
                this._payment = value;
            }
        }
        /// <comentarios/>
        public SUNATPerceptionInformationType SUNATPerceptionInformation
        {
            get
            {
                return this._sUNATPerceptionInformation;
            }
            set
            {
                this._sUNATPerceptionInformation = value;
            }
        }
    }
    #endregion
}
