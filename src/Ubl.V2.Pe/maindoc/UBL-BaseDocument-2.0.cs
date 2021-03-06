using Ubl.V2.Pe.common;

namespace Ubl.V2.Pe.maindoc
{
    /// <summary>
    ///  The document used to request payment.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:BaseDocument-2")]
    [System.Xml.Serialization.XmlRootAttribute("UblBaseDocument", Namespace="urn:oasis:names:specification:ubl:schema:xsd:BaseDocument-2", IsNullable=false)]
    public abstract partial class UblBaseDocumentType
    {
        
        private UBLExtensionType[] uBLExtensionsField;
        
        private IdentifierType uBLVersionIDField;
        
        private IdentifierType customizationIDField;
        
        private IdentifierType profileIDField;
        /// <summary>
        /// Se emplea para ubicar AdditionalMonetaryTotal y AdditionalInformation ademas de la Firma.
        /// </summary>
        [System.Xml.Serialization.XmlArrayAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
        [System.Xml.Serialization.XmlArrayItemAttribute("UBLExtension", IsNullable=false)]
        public UBLExtensionType[] UBLExtensions
        {
            get
            {
                return this.uBLExtensionsField;
            }
            set
            {
                this.uBLExtensionsField = value;
            }
        }
        /// <summary>
        /// Version del UBL
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType UBLVersionID
        {
            get
            {
                return this.uBLVersionIDField;
            }
            set
            {
                this.uBLVersionIDField = value;
            }
        }
        /// <summary>
        /// Id Personalizado por SUNAT.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType CustomizationID
        {
            get
            {
                return this.customizationIDField;
            }
            set
            {
                this.customizationIDField = value;
            }
        }
        /// <summary>
        /// Profile ID
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType ProfileID
        {
            get
            {
                return this.profileIDField;
            }
            set
            {
                this.profileIDField = value;
            }
        }
    }
}
