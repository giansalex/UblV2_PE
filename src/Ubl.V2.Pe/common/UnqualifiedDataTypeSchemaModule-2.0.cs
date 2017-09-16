using System;
using System.Xml;
using System.Xml.Serialization;

namespace Ubl.V2.Pe.common
{
    /// <summary>
    ///  A number of monetary units specified in a currency where the unit of the currency is explicit or implied.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    
    [XmlType(Namespace="urn:un:unece:uncefact:data:specification:UnqualifiedDataTypesSchemaModule:2")]
    public partial class AmountType
    {
        
        private string currencyIDField;
        
        private decimal valueField;
        /// <summary>
        /// Amount
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator AmountType(System.Decimal value)
        {
             return new AmountType { Value = value };
        }
        
        /// <summary>
        ///  The currency of the amount.
        /// </summary>
        [XmlAttribute()]
        public string currencyID
        {
            get
            {
                return this.currencyIDField;
            }
            set
            {
                this.currencyIDField = value;
            }
        }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>The value.</value>
        [XmlText()]
        public decimal Value
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
    ///  A set of finite-length sequences of binary octets.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    
    [XmlType(Namespace="urn:un:unece:uncefact:data:specification:UnqualifiedDataTypesSchemaModule:2")]
    public partial class BinaryObjectType
    {
        
        private string formatField;
        
        private string mimeCodeField;
        
        private string encodingCodeField;
        
        private string characterSetCodeField;
        
        private string uriField;
        
        private string filenameField;
        
        private byte[] valueField;

        /// <summary>
        /// Performs an implicit conversion to <see cref="BinaryObjectType"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator BinaryObjectType(System.Byte[] value)
        {
             return new BinaryObjectType { Value = value };
        }
        
        /// <summary>
        ///  The format of the binary content.
        /// </summary>
        [XmlAttribute()]
        public string format
        {
            get
            {
                return this.formatField;
            }
            set
            {
                this.formatField = value;
            }
        }
        
        /// <summary>
        ///  The mime type of the binary object.
        /// </summary>
        [XmlAttribute()]
        public string mimeCode
        {
            get
            {
                return this.mimeCodeField;
            }
            set
            {
                this.mimeCodeField = value;
            }
        }
        
        /// <summary>
        ///  Specifies the decoding algorithm of the binary object.
        /// </summary>
        [XmlAttribute(DataType="normalizedString")]
        public string encodingCode
        {
            get
            {
                return this.encodingCodeField;
            }
            set
            {
                this.encodingCodeField = value;
            }
        }
        
        /// <summary>
        ///  The character set of the binary object if the mime type is text.
        /// </summary>
        [XmlAttribute(DataType="normalizedString")]
        public string characterSetCode
        {
            get
            {
                return this.characterSetCodeField;
            }
            set
            {
                this.characterSetCodeField = value;
            }
        }
        
        /// <summary>
        ///  The Uniform Resource Identifier that identifies where the binary object is located.
        /// </summary>
        [XmlAttribute(DataType="anyURI")]
        public string uri
        {
            get
            {
                return this.uriField;
            }
            set
            {
                this.uriField = value;
            }
        }
        
        /// <summary>
        ///  The filename of the binary object.
        /// </summary>
        [XmlAttribute()]
        public string filename
        {
            get
            {
                return this.filenameField;
            }
            set
            {
                this.filenameField = value;
            }
        }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>The value.</value>
        [XmlText(DataType="base64Binary")]
        public byte[] Value
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
    ///  A diagram, graph, mathematical curves, or similar representation.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    
    [XmlType(Namespace="urn:un:unece:uncefact:data:specification:UnqualifiedDataTypesSchemaModule:2")]
    public partial class GraphicType
    {
        
        private string formatField;
        
        private string mimeCodeField;
        
        private string encodingCodeField;
        
        private string uriField;
        
        private string filenameField;
        
        private byte[] valueField;

        /// <summary>
        /// Performs an implicit conversion to <see cref="GraphicType"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator GraphicType(System.Byte[] value)
        {
             return new GraphicType { Value = value };
        }
        
        /// <summary>
        ///  The format of the graphic content.
        /// </summary>
        [XmlAttribute()]
        public string format
        {
            get
            {
                return this.formatField;
            }
            set
            {
                this.formatField = value;
            }
        }
        
        /// <summary>
        ///  The mime type of the graphic object.
        /// </summary>
        [XmlAttribute()]
        public string mimeCode
        {
            get
            {
                return this.mimeCodeField;
            }
            set
            {
                this.mimeCodeField = value;
            }
        }
        
        /// <summary>
        ///  Specifies the decoding algorithm of the graphic object.
        /// </summary>
        [XmlAttribute(DataType="normalizedString")]
        public string encodingCode
        {
            get
            {
                return this.encodingCodeField;
            }
            set
            {
                this.encodingCodeField = value;
            }
        }
        
        /// <summary>
        ///  The Uniform Resource Identifier that identifies where the graphic object is located.
        /// </summary>
        [XmlAttribute(DataType="anyURI")]
        public string uri
        {
            get
            {
                return this.uriField;
            }
            set
            {
                this.uriField = value;
            }
        }
        
        /// <summary>
        ///  The filename of the graphic object.
        /// </summary>
        [XmlAttribute()]
        public string filename
        {
            get
            {
                return this.filenameField;
            }
            set
            {
                this.filenameField = value;
            }
        }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>The value.</value>
        [XmlText(DataType="base64Binary")]
        public byte[] Value
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
    ///  A diagram, graph, mathematical curves, or similar representation.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    
    [XmlType(Namespace="urn:un:unece:uncefact:data:specification:UnqualifiedDataTypesSchemaModule:2")]
    public partial class PictureType
    {
        
        private string formatField;
        
        private string mimeCodeField;
        
        private string encodingCodeField;
        
        private string uriField;
        
        private string filenameField;
        
        private byte[] valueField;

        /// <summary>
        /// Performs an implicit conversion to <see cref="PictureType"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator PictureType(System.Byte[] value)
        {
             return new PictureType { Value = value };
        }
        
        /// <summary>
        ///  The format of the picture content.
        /// </summary>
        [XmlAttribute()]
        public string format
        {
            get
            {
                return this.formatField;
            }
            set
            {
                this.formatField = value;
            }
        }
        
        /// <summary>
        ///  The mime type of the picture object.
        /// </summary>
        [XmlAttribute()]
        public string mimeCode
        {
            get
            {
                return this.mimeCodeField;
            }
            set
            {
                this.mimeCodeField = value;
            }
        }
        
        /// <summary>
        ///  Specifies the decoding algorithm of the picture object.
        /// </summary>
        [XmlAttribute(DataType="normalizedString")]
        public string encodingCode
        {
            get
            {
                return this.encodingCodeField;
            }
            set
            {
                this.encodingCodeField = value;
            }
        }
        
        /// <summary>
        ///  The Uniform Resource Identifier that identifies where the picture object is located.
        /// </summary>
        [XmlAttribute(DataType="anyURI")]
        public string uri
        {
            get
            {
                return this.uriField;
            }
            set
            {
                this.uriField = value;
            }
        }
        
        /// <summary>
        ///  The filename of the picture object.
        /// </summary>
        [XmlAttribute()]
        public string filename
        {
            get
            {
                return this.filenameField;
            }
            set
            {
                this.filenameField = value;
            }
        }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>The value.</value>
        [XmlText(DataType="base64Binary")]
        public byte[] Value
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
    ///  A diagram, graph, mathematical curves, or similar representation.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    
    [XmlType(Namespace="urn:un:unece:uncefact:data:specification:UnqualifiedDataTypesSchemaModule:2")]
    public partial class SoundType
    {
        
        private string formatField;
        
        private string mimeCodeField;
        
        private string encodingCodeField;
        
        private string uriField;
        
        private string filenameField;
        
        private byte[] valueField;

        /// <summary>
        /// Performs an implicit conversion to <see cref="SoundType"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator SoundType(System.Byte[] value)
        {
             return new SoundType { Value = value };
        }
        
        /// <summary>
        ///  The format of the sound content.
        /// </summary>
        [XmlAttribute()]
        public string format
        {
            get
            {
                return this.formatField;
            }
            set
            {
                this.formatField = value;
            }
        }
        
        /// <summary>
        ///  The mime type of the sound object.
        /// </summary>
        [XmlAttribute()]
        public string mimeCode
        {
            get
            {
                return this.mimeCodeField;
            }
            set
            {
                this.mimeCodeField = value;
            }
        }
        
        /// <summary>
        ///  Specifies the decoding algorithm of the sound object.
        /// </summary>
        [XmlAttribute(DataType="normalizedString")]
        public string encodingCode
        {
            get
            {
                return this.encodingCodeField;
            }
            set
            {
                this.encodingCodeField = value;
            }
        }
        
        /// <summary>
        ///  The Uniform Resource Identifier that identifies where the sound object is located.
        /// </summary>
        [XmlAttribute(DataType="anyURI")]
        public string uri
        {
            get
            {
                return this.uriField;
            }
            set
            {
                this.uriField = value;
            }
        }
        
        /// <summary>
        ///  The filename of the sound object.
        /// </summary>
        [XmlAttribute()]
        public string filename
        {
            get
            {
                return this.filenameField;
            }
            set
            {
                this.filenameField = value;
            }
        }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>The value.</value>
        [XmlText(DataType="base64Binary")]
        public byte[] Value
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
    ///  A diagram, graph, mathematical curves, or similar representation.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    
    [XmlType(Namespace="urn:un:unece:uncefact:data:specification:UnqualifiedDataTypesSchemaModule:2")]
    public partial class VideoType
    {
        
        private string formatField;
        
        private string mimeCodeField;
        
        private string encodingCodeField;
        
        private string uriField;
        
        private string filenameField;
        
        private byte[] valueField;

        /// <summary>
        /// Performs an implicit conversion to <see cref="VideoType"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator VideoType(System.Byte[] value)
        {
             return new VideoType { Value = value };
        }
        
        /// <summary>
        ///  The format of the video content.
        /// </summary>
        [XmlAttribute()]
        public string format
        {
            get
            {
                return this.formatField;
            }
            set
            {
                this.formatField = value;
            }
        }
        
        /// <summary>
        ///  The mime type of the video object.
        /// </summary>
        [XmlAttribute()]
        public string mimeCode
        {
            get
            {
                return this.mimeCodeField;
            }
            set
            {
                this.mimeCodeField = value;
            }
        }
        
        /// <summary>
        ///  Specifies the decoding algorithm of the video object.
        /// </summary>
        [XmlAttribute(DataType="normalizedString")]
        public string encodingCode
        {
            get
            {
                return this.encodingCodeField;
            }
            set
            {
                this.encodingCodeField = value;
            }
        }
        
        /// <summary>
        ///  The Uniform Resource Identifier that identifies where the video object is located.
        /// </summary>
        [XmlAttribute(DataType="anyURI")]
        public string uri
        {
            get
            {
                return this.uriField;
            }
            set
            {
                this.uriField = value;
            }
        }
        
        /// <summary>
        ///  The filename of the video object.
        /// </summary>
        [XmlAttribute()]
        public string filename
        {
            get
            {
                return this.filenameField;
            }
            set
            {
                this.filenameField = value;
            }
        }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>The value.</value>
        [XmlText(DataType="base64Binary")]
        public byte[] Value
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
    ///  A character string (letters, figures, or symbols) that for brevity and/or languange independence may be used to represent or replace a definitive value or text of an attribute together with relevant supplementary information.
    /// </summary>
    [XmlInclude(typeof(ExtensionReasonCodeType))]
    [XmlInclude(typeof(UnitOfMeasureCodeType))]
    [XmlInclude(typeof(TransportationStatusCodeType))]
    [XmlInclude(typeof(PortCodeType))]
    [XmlInclude(typeof(OperatorCodeType))]
    [XmlInclude(typeof(CountryIdentificationCodeType))]
    [XmlInclude(typeof(ContainerSizeTypeCodeType))]
    [XmlInclude(typeof(ChipCodeType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    
    [XmlType(Namespace="urn:un:unece:uncefact:data:specification:UnqualifiedDataTypesSchemaModule:2")]
    public partial class CodeType
    {
        
        private string listIDField;
        
        private string listAgencyIDField;
        
        private string listAgencyNameField;
        
        private string listNameField;
        
        private string listVersionIDField;
        
        private string nameField;
        
        private string languageIDField;
        
        private string listURIField;
        
        private string listSchemeURIField;
        
        private string valueField;

        /// <summary>
        /// Performs an implicit conversion from <see cref="System.String"/> to <see cref="CodeType"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator CodeType(System.String value)
        {
             return string.IsNullOrEmpty(value) ? null : new CodeType { Value = value };
        }
        
        /// <summary>
        ///  The identification of a list of codes.
        /// </summary>
        [XmlAttribute(DataType="normalizedString")]
        public string listID
        {
            get
            {
                return this.listIDField;
            }
            set
            {
                this.listIDField = value;
            }
        }
        
        /// <summary>
        ///  An agency that maintains one or more lists of codes.
        /// </summary>
        [XmlAttribute(DataType="normalizedString")]
        public string listAgencyID
        {
            get
            {
                return this.listAgencyIDField;
            }
            set
            {
                this.listAgencyIDField = value;
            }
        }
        
        /// <summary>
        ///  The name of the agency that maintains the list of codes.
        /// </summary>
        [XmlAttribute()]
        public string listAgencyName
        {
            get
            {
                return this.listAgencyNameField;
            }
            set
            {
                this.listAgencyNameField = value;
            }
        }
        
        /// <summary>
        ///  The name of a list of codes.
        /// </summary>
        [XmlAttribute()]
        public string listName
        {
            get
            {
                return this.listNameField;
            }
            set
            {
                this.listNameField = value;
            }
        }
        
        /// <summary>
        ///  The identification of a list of codes.
        /// </summary>
        [XmlAttribute(DataType="normalizedString")]
        public string listVersionID
        {
            get
            {
                return this.listVersionIDField;
            }
            set
            {
                this.listVersionIDField = value;
            }
        }
        
        /// <summary>
        ///  The textual equivalent of the code content component.
        /// </summary>
        [XmlAttribute()]
        public string name
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
        ///  The identifier of the language used in the code name.
        /// </summary>
        [XmlAttribute(DataType="language")]
        public string languageID
        {
            get
            {
                return this.languageIDField;
            }
            set
            {
                this.languageIDField = value;
            }
        }
        
        /// <summary>
        ///  The Uniform Resource Identifier that identifies where the code list is located.
        /// </summary>
        [XmlAttribute(DataType="anyURI")]
        public string listURI
        {
            get
            {
                return this.listURIField;
            }
            set
            {
                this.listURIField = value;
            }
        }
        
        /// <summary>
        ///  The Uniform Resource Identifier that identifies where the code list scheme is located.
        /// </summary>
        [XmlAttribute(DataType="anyURI")]
        public string listSchemeURI
        {
            get
            {
                return this.listSchemeURIField;
            }
            set
            {
                this.listSchemeURIField = value;
            }
        }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>The value.</value>
        [XmlText(DataType="normalizedString")]
        public string Value
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
    ///  A character string to identify and distinguish uniquely, one instance of an object in an identification scheme from all other objects in the same scheme together with relevant supplementary information.
    /// </summary>
    [XmlInclude(typeof(ExtensionVersionIDType))]
    [XmlInclude(typeof(ExtensionURIType))]
    [XmlInclude(typeof(ExtensionAgencyURIType))]
    [XmlInclude(typeof(ExtensionAgencyIDType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    
    [XmlType(Namespace="urn:un:unece:uncefact:data:specification:UnqualifiedDataTypesSchemaModule:2")]
    public partial class IdentifierType
    {
        
        private string schemeIDField;
        
        private string schemeNameField;
        
        private string schemeAgencyIDField;
        
        private string schemeAgencyNameField;
        
        private string schemeVersionIDField;
        
        private string schemeDataURIField;
        
        private string schemeURIField;
        
        private string valueField;

        /// <summary>
        /// Performs an implicit conversion from <see cref="System.String"/> to <see cref="IdentifierType"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator IdentifierType(System.String value)
        {
             return string.IsNullOrEmpty(value) ? null : new IdentifierType { Value = value };
        }
        
        /// <summary>
        ///  The identification of the identification scheme.
        /// </summary>
        [XmlAttribute(DataType="normalizedString")]
        public string schemeID
        {
            get
            {
                return this.schemeIDField;
            }
            set
            {
                this.schemeIDField = value;
            }
        }
        
        /// <summary>
        ///  The name of the identification scheme.
        /// </summary>
        [XmlAttribute()]
        public string schemeName
        {
            get
            {
                return this.schemeNameField;
            }
            set
            {
                this.schemeNameField = value;
            }
        }
        
        /// <summary>
        ///  The identification of the agency that maintains the identification scheme.
        /// </summary>
        [XmlAttribute(DataType="normalizedString")]
        public string schemeAgencyID
        {
            get
            {
                return this.schemeAgencyIDField;
            }
            set
            {
                this.schemeAgencyIDField = value;
            }
        }
        
        /// <summary>
        ///  The name of the agency that maintains the identification scheme.
        /// </summary>
        [XmlAttribute()]
        public string schemeAgencyName
        {
            get
            {
                return this.schemeAgencyNameField;
            }
            set
            {
                this.schemeAgencyNameField = value;
            }
        }
        
        /// <summary>
        ///  The version of the identification scheme.
        /// </summary>
        [XmlAttribute(DataType="normalizedString")]
        public string schemeVersionID
        {
            get
            {
                return this.schemeVersionIDField;
            }
            set
            {
                this.schemeVersionIDField = value;
            }
        }
        
        /// <summary>
        ///  The Uniform Resource Identifier that identifies where the identification scheme data is located.
        /// </summary>
        [XmlAttribute(DataType="anyURI")]
        public string schemeDataURI
        {
            get
            {
                return this.schemeDataURIField;
            }
            set
            {
                this.schemeDataURIField = value;
            }
        }
        
        /// <summary>
        ///  The Uniform Resource Identifier that identifies where the identification scheme is located.
        /// </summary>
        [XmlAttribute(DataType="anyURI")]
        public string schemeURI
        {
            get
            {
                return this.schemeURIField;
            }
            set
            {
                this.schemeURIField = value;
            }
        }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>The value.</value>
        [XmlText(DataType="normalizedString")]
        public string Value
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
    ///  A numeric value determined by measuring an object along with the specified unit of measure.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    
    [XmlType(Namespace="urn:un:unece:uncefact:data:specification:UnqualifiedDataTypesSchemaModule:2")]
    public partial class MeasureType
    {
        
        private string unitCodeField;
        
        private decimal valueField;

        /// <summary>
        /// Performs an implicit conversion from <see cref="System.Decimal"/> to <see cref="MeasureType"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator MeasureType(System.Decimal value)
        {
             return new MeasureType { Value = value };
        }
        
        /// <summary>
        ///  The type of unit of measure.
        /// </summary>
        [XmlAttribute()]
        public string unitCode
        {
            get
            {
                return this.unitCodeField;
            }
            set
            {
                this.unitCodeField = value;
            }
        }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>The value.</value>
        [XmlText()]
        public decimal Value
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
    ///  A counted number of non-monetary units possibly including fractions.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    
    [XmlType(Namespace="urn:un:unece:uncefact:data:specification:UnqualifiedDataTypesSchemaModule:2")]
    public partial class QuantityType
    {
        
        private string unitCodeField;
        
        private bool unitCodeFieldSpecified;
        
        private decimal valueField;

        /// <summary>
        /// Performs an implicit conversion from <see cref="System.Decimal" /> to <see cref="QuantityType" />.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator QuantityType(System.Decimal value)
        {
             return new QuantityType { Value = value };
        }
        
        /// <summary>
        ///  The unit of the quantity
        /// </summary>
        [XmlAttribute()]
        public string unitCode
        {
            get
            {
                return this.unitCodeField;
            }
            set
            {
                this.unitCodeField = value;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [unit code specified].
        /// </summary>
        /// <value><c>true</c> if [unit code specified]; otherwise, <c>false</c>.</value>
        [XmlIgnore()]
        [System.Obsolete("Property setter ignored. Getter will evaluate to true if unitCode is set to a non null value")]
        public bool unitCodeSpecified
        {
            get
            {
                return !string.IsNullOrEmpty(this.unitCode);
            }
            set
            {
                this.unitCodeFieldSpecified = value;
            }
        }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>The value.</value>
        [XmlText()]
        public decimal Value
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
    ///  A character string (i.e. a finite set of characters) generally in the form of words of a language.
    /// </summary>
    [XmlInclude(typeof(ExtensionReasonType))]
    [XmlInclude(typeof(ExtensionAgencyNameType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    
    [XmlType(Namespace="urn:un:unece:uncefact:data:specification:UnqualifiedDataTypesSchemaModule:2")]
    public partial class TextType
    {
        
        private string languageIDField;
        
        private string valueField;

        /// <summary>
        /// Performs an implicit conversion from <see cref="System.String"/> to <see cref="TextType"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator TextType(System.String value)
        {
             return string.IsNullOrEmpty(value) ? null : new TextType { Value = value };
        }
        
        /// <summary>
        ///  The identifier of the language used in the content component.
        /// </summary>
        [XmlAttribute(DataType="language")]
        public string languageID
        {
            get
            {
                return this.languageIDField;
            }
            set
            {
                this.languageIDField = value;
            }
        }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>The value.</value>
        [XmlText()]
        public string Value
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
    ///  A character string that consititues the distinctive designation of a person, place, thing or concept.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("ublxsd", "2.0.0.0")]
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.Xml.Serialization.XmlType(Namespace="urn:un:unece:uncefact:data:specification:UnqualifiedDataTypesSchemaModule:2")]
    public partial class NameType
    {
        
        private string languageIDField;

        private string valueField;

        /// <summary>
        /// Performs an implicit conversion from <see cref="System.String"/> to <see cref="NameType"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator NameType(System.String value)
        {
             return string.IsNullOrEmpty(value) ? null : new NameType { Value = value };
        }
        
        /// <summary>
        ///  The identifier of the language used in the content component.
        /// </summary>
        [XmlAttribute(DataType="language")]
        public string languageID
        {
            get
            {
                return this.languageIDField;
            }
            set
            {
                this.languageIDField = value;
            }
        }
        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>The value.</value>
        [XmlIgnore]
        public string Value
        {
            get
            {
                return valueField;
            }
            set
            {
                this.valueField = value;
            }
        }

        /// <summary>
        /// Gets or sets the c data value.
        /// </summary>
        /// <value>The c data value.</value>
        [XmlText]
        public XmlNode[] CDataValue
        {
            get
            {
                if (string.IsNullOrEmpty(valueField))
                    return null;
                else
                    return new XmlNode[] { new XmlDocument().CreateCDataSection(valueField) };
            }
            set
            {
                //this.valueField = value[0].OuterXml;
            }
        }
    }
}
