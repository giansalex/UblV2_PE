using Ubl.V2.Pe.common;

namespace Ubl.V2.Pe.maindoc
{
    /// <summary>
    ///  A document to indicate the application's response to a transaction. This may be a business response and/or a technical response, sent automatically by an application or initiated by a user.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:ApplicationResponse-2")]
    [System.Xml.Serialization.XmlRootAttribute("ApplicationResponse", Namespace="urn:oasis:names:specification:ubl:schema:xsd:ApplicationResponse-2", IsNullable=false)]
    public partial class ApplicationResponseType : UblBaseDocumentType
    {
        
        private IdentifierType idField;
        
        private IdentifierType uUIDField;
        
        private DateType issueDateField;
        
        private TimeType issueTimeField;
        
        private DateType responseDateField;
        
        private TimeType responseTimeField;
        
        private TextType[] noteField;
        
        private IdentifierType versionIDField;
        
        private SignatureType[] signatureField;
        
        private PartyType senderPartyField;
        
        private PartyType receiverPartyField;
        
        private DocumentResponseType[] documentResponseField;
        
        /// <summary>
        ///  An identifier for the Application Response assigned by the sender.
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
        ///  The date assigned by the sender's application on which the Application Response was created.
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
        ///  The time assigned by the sender's application at which the Application Response was created.
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
        ///  The date at which the information in the response was created.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DateType ResponseDate
        {
            get
            {
                return this.responseDateField;
            }
            set
            {
                this.responseDateField = value;
            }
        }
        
        /// <summary>
        ///  The time at which the information in the response was created.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TimeType ResponseTime
        {
            get
            {
                return this.responseTimeField;
            }
            set
            {
                this.responseTimeField = value;
            }
        }
        
        /// <summary>
        ///  Free-form text applying to the Application Response.  This element may contain notes or any other similar information that is not contained explicitly in another structure.
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
        ///  Identifies the current version of this document.
        ///  Example: "1.1"
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType VersionID
        {
            get
            {
                return this.versionIDField;
            }
            set
            {
                this.versionIDField = value;
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
        ///  An association to the Party sending this document.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PartyType SenderParty
        {
            get
            {
                return this.senderPartyField;
            }
            set
            {
                this.senderPartyField = value;
            }
        }
        
        /// <summary>
        ///  An association to the Party receiving this document.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PartyType ReceiverParty
        {
            get
            {
                return this.receiverPartyField;
            }
            set
            {
                this.receiverPartyField = value;
            }
        }
        
        /// <summary>
        ///  A response to one or more documents.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("DocumentResponse", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public DocumentResponseType[] DocumentResponse
        {
            get
            {
                return this.documentResponseField;
            }
            set
            {
                this.documentResponseField = value;
            }
        }
    }
}
