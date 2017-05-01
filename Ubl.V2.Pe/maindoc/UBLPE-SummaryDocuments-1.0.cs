using Ubl.V2.Pe.common;

namespace Ubl.V2.Pe.maindoc
{
    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:sunat:names:specification:ubl:peru:schema:xsd:SummaryDocuments-1")]
    [System.Xml.Serialization.XmlRootAttribute("SummaryDocuments", Namespace="urn:sunat:names:specification:ubl:peru:schema:xsd:SummaryDocuments-1", IsNullable=false)]
    public partial class SummaryDocumentsType : UblBaseDocumentType{
        
        private IdentifierType idField;

        private DateType referenceDateField;

        private DateType issueDateField;

        private TextType[] noteField;
        
        private SignatureType[] signatureField;
        
        private SupplierPartyType accountingSupplierPartyField;
        
        private SummaryDocumentsLineType[] summaryDocumentsLineField;
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType ID
        {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DateType ReferenceDate
        {
            get {
                return this.referenceDateField;
            }
            set {
                this.referenceDateField = value;
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DateType IssueDate
        {
            get {
                return this.issueDateField;
            }
            set {
                this.issueDateField = value;
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute("Note", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType[] Note
        {
            get {
                return this.noteField;
            }
            set {
                this.noteField = value;
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute("Signature", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public SignatureType[] Signature
        {
            get {
                return this.signatureField;
            }
            set {
                this.signatureField = value;
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public SupplierPartyType AccountingSupplierParty
        {
            get {
                return this.accountingSupplierPartyField;
            }
            set {
                this.accountingSupplierPartyField = value;
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute("SummaryDocumentsLine", Namespace="urn:sunat:names:specification:ubl:peru:schema:xsd:SunatAggregateComponents-1")]
        public SummaryDocumentsLineType[] SummaryDocumentsLine {
            get {
                return this.summaryDocumentsLineField;
            }
            set {
                this.summaryDocumentsLineField = value;
            }
        }
    }
    
}
