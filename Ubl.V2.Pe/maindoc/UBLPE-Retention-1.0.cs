// ------------------------------------------------------------------------------
//  <auto-generado>
//    Generado para Facturacion Electronica - Sunat. Version 4.2.0.31
//    <NameSpace>UblLarsen.UblPE.Sac</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><EnableDataBinding>False</EnableDataBinding><GenerateCloneMethod>False</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><DataMemberNameArg>OnlyIfDifferent</DataMemberNameArg><DataMemberOnXmlIgnore>False</DataMemberOnXmlIgnore><CodeBaseTag>Net40</CodeBaseTag><InitializeFields>All</InitializeFields><GenerateUnusedComplexTypes>True</GenerateUnusedComplexTypes><GenerateUnusedSimpleTypes>True</GenerateUnusedSimpleTypes><GenerateXMLAttributes>True</GenerateXMLAttributes><OrderXMLAttrib>False</OrderXMLAttrib><EnableLazyLoading>False</EnableLazyLoading><VirtualProp>False</VirtualProp><PascalCase>False</PascalCase><AutomaticProperties>False</AutomaticProperties><PropNameSpecified>None</PropNameSpecified><PrivateFieldName>StartWithUnderscore</PrivateFieldName><PrivateFieldNamePrefix></PrivateFieldNamePrefix><EnableRestriction>False</EnableRestriction><RestrictionMaxLenght>False</RestrictionMaxLenght><RestrictionRegEx>False</RestrictionRegEx><RestrictionRange>False</RestrictionRange><ValidateProperty>False</ValidateProperty><ClassNamePrefix></ClassNamePrefix><ClassLevel>Public</ClassLevel><PartialClass>True</PartialClass><ClassesInSeparateFiles>False</ClassesInSeparateFiles><ClassesInSeparateFilesDir></ClassesInSeparateFilesDir><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>False</EnableSummaryComment><EnableAppInfoSettings>False</EnableAppInfoSettings><EnableExternalSchemasCache>False</EnableExternalSchemasCache><EnableDebug>False</EnableDebug><EnableWarn>False</EnableWarn><ExcludeImportedTypes>True</ExcludeImportedTypes><ExpandNesteadAttributeGroup>False</ExpandNesteadAttributeGroup><CleanupCode>False</CleanupCode><EnableXmlSerialization>False</EnableXmlSerialization><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><EnableEncoding>False</EnableEncoding><EnableXMLIndent>False</EnableXMLIndent><Encoder>UTF8</Encoder><Serializer>XmlSerializer</Serializer><sspNullable>False</sspNullable><sspString>False</sspString><sspCollection>False</sspCollection><sspComplexType>False</sspComplexType><sspSimpleType>False</sspSimpleType><sspEnumType>False</sspEnumType><BaseClassName>EntityBase</BaseClassName><UseBaseClass>False</UseBaseClass><GenBaseClass>False</GenBaseClass><CustomUsings></CustomUsings><AttributesToExlude></AttributesToExlude>
//  </auto-generado>
// ------------------------------------------------------------------------------

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
