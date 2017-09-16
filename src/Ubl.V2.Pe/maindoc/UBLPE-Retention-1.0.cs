using Ubl.V2.Pe.common;

#pragma warning disable
namespace Ubl.V2.Pe.maindoc
{
    /// <summary>
    ///  The document used to CRE.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:sunat:names:specification:ubl:peru:schema:xsd:Retention-1")]
    [System.Xml.Serialization.XmlRootAttribute("Retention", Namespace ="urn:sunat:names:specification:ubl:peru:schema:xsd:Retention-1", IsNullable=false)]
    public partial class RetentionType : UblBaseDocumentType
    {
        private SignatureType _signature;
        
        private IdentifierType _id;
        
        private DateType _issueDate;
        
        private PartyType _agentParty;
        
        private PartyType _receiverParty;
        
        private CodeType _sunatRetentionSystemCode;
        
        private PercentType _sunatRetentionPercent;
        
        private TextType _note;
        
        private AmountType _totalInvoiceAmount;
        
        private AmountType _sunatTotalPaid;
        
        private SUNATRetentionDocumentReferenceType[] _sunatRetentionDocumentReference;

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public SignatureType Signature
        {
            get
            {
                return this._signature;
            }
            set
            {
                this._signature = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PartyType AgentParty
        {
            get
            {
                return this._agentParty;
            }
            set
            {
                this._agentParty = value;
            }
        }
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PartyType ReceiverParty
        {
            get
            {
                return this._receiverParty;
            }
            set
            {
                this._receiverParty = value;
            }
        }
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:sunat:names:specification:ubl:peru:schema:xsd:SunatAggregateComponents-1")]
        public CodeType SUNATRetentionSystemCode
        {
            get
            {
                return this._sunatRetentionSystemCode;
            }
            set
            {
                this._sunatRetentionSystemCode = value;
            }
        }
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:sunat:names:specification:ubl:peru:schema:xsd:SunatAggregateComponents-1")]
        public PercentType SUNATRetentionPercent
        {
            get
            {
                return this._sunatRetentionPercent;
            }
            set
            {
                this._sunatRetentionPercent = value;
            }
        }
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType Note
        {
            get
            {
                return this._note;
            }
            set
            {
                this._note = value;
            }
        }
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:sunat:names:specification:ubl:peru:schema:xsd:SunatAggregateComponents-1")]
        public AmountType SUNATTotalPaid
        {
            get
            {
                return this._sunatTotalPaid;
            }
            set
            {
                this._sunatTotalPaid = value;
            }
        }
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute("SUNATRetentionDocumentReference", Namespace="urn:sunat:names:specification:ubl:peru:schema:xsd:SunatAggregateComponents-1")]
        public SUNATRetentionDocumentReferenceType[] SUNATRetentionDocumentReference
        {
            get
            {
                return this._sunatRetentionDocumentReference;
            }
            set
            {
                this._sunatRetentionDocumentReference = value;
            }
        }
    }
}
#pragma warning restore
