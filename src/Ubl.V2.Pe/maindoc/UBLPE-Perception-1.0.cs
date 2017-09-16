using Ubl.V2.Pe.common;

#pragma warning disable
namespace Ubl.V2.Pe.maindoc
{
    /// <summary>
    ///  The document used to CPE.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute]
    [System.Diagnostics.DebuggerStepThrough]
    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "urn:sunat:names:specification:ubl:peru:schema:xsd:Perception-1")]
    [System.Xml.Serialization.XmlRoot("Perception", Namespace = "urn:sunat:names:specification:ubl:peru:schema:xsd:Perception-1", IsNullable = false)]
    public class PerceptionType : UblBaseDocumentType
    {
        private SignatureType _signature;

        private IdentifierType _id;

        private DateType _issueDate;

        private PartyType _agentParty;

        private PartyType _receiverParty;

        private CodeType _sunatPerceptionSystemCode;

        private PercentType _sunatPerceptionPercent;

        private TextType _note;

        private AmountType _totalInvoiceAmount;

        private AmountType _sunatTotalCashed;

        private SUNATPerceptionDocumentReferenceType[] _sunatPerceptionDocumentReference;


        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
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
        
        /// <summary>
        /// Id formado por Serie-Correlativo
        /// </summary>
        [System.Xml.Serialization.XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType ID
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }

        /// <summary>
        /// Fecha de Envio
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DateType IssueDate
        {
            get
            {
                return _issueDate;
            }
            set
            {
                _issueDate = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PartyType AgentParty
        {
            get
            {
                return _agentParty;
            }
            set
            {
                _agentParty = value;
            }
        }
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PartyType ReceiverParty
        {
            get
            {
                return _receiverParty;
            }
            set
            {
                _receiverParty = value;
            }
        }
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:sunat:names:specification:ubl:peru:schema:xsd:SunatAggregateComponents-1")]
        public CodeType SUNATPerceptionSystemCode
        {
            get
            {
                return _sunatPerceptionSystemCode;
            }
            set
            {
                _sunatPerceptionSystemCode = value;
            }
        }
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:sunat:names:specification:ubl:peru:schema:xsd:SunatAggregateComponents-1")]
        public PercentType SUNATPerceptionPercent
        {
            get
            {
                return _sunatPerceptionPercent;
            }
            set
            {
                _sunatPerceptionPercent = value;
            }
        }
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType Note
        {
            get
            {
                return _note;
            }
            set
            {
                _note = value;
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:sunat:names:specification:ubl:peru:schema:xsd:SunatAggregateComponents-1")]
        public AmountType SUNATTotalCashed
        {
            get
            {
                return _sunatTotalCashed;
            }
            set
            {
                _sunatTotalCashed = value;
            }
        }
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute("SUNATPerceptionDocumentReference", Namespace = "urn:sunat:names:specification:ubl:peru:schema:xsd:SunatAggregateComponents-1")]
        public SUNATPerceptionDocumentReferenceType[] SUNATPerceptionDocumentReference
        {
            get
            {
                return _sunatPerceptionDocumentReference;
            }
            set
            {
                _sunatPerceptionDocumentReference = value;
            }
        }
    }
}
#pragma warning restore