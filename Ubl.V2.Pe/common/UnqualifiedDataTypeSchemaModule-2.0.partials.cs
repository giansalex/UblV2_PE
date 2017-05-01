using System;

namespace Ubl.V2.Pe.common
{
    /// <summary>
    /// Class AmountType.
    /// </summary>
    public partial class AmountType
    {
        /// <summary>
        /// Thread local variable for default currency. Will be undefined if a context switch occurs. Thread handling is not part of the library.
        /// </summary>
        [ThreadStatic]
        public static string TlsDefaultCurrencyID;

        /// <summary>
        /// Initializes a new instance of the <see cref="AmountType"/> class.
        /// </summary>
        public AmountType()
        {
            this.currencyID = TlsDefaultCurrencyID;
        }
    }

    //
    // The following types got lost when Common Basic Components (Cac) was optimized away. 
    // Have added them here manually from an older version of the generated file.
    //
    
    /// <summary>
    ///  One calendar day according the Gregorian calendar.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class DateType
    {

        private System.DateTime valueField;

        /// <summary>
        /// Performs an implicit conversion from <see cref="System.DateTime"/> to <see cref="DateType"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator DateType(System.DateTime value)
        {
            return new DateType { Value = value };
        }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>The value.</value>
        [System.Xml.Serialization.XmlTextAttribute(DataType = "date")]
        public System.DateTime Value
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
    ///  The instance of time that occurs every day.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class TimeType
    {

        private System.DateTime valueField;

        /// <summary>
        /// Performs an implicit conversion from <see cref="System.DateTime"/> to <see cref="TimeType"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator TimeType(System.DateTime value)
        {
            return new TimeType { Value = value };
        }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>The value.</value>
        [System.Xml.Serialization.XmlTextAttribute(DataType = "time")]
        public System.DateTime Value
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
    ///  A list of two mutually exclusive Boolean values that express the only possible states of a property.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class IndicatorType
    {

        private bool valueField;

        /// <summary>
        /// Performs an implicit conversion from <see cref="System.Boolean"/> to <see cref="IndicatorType"/>.
        /// </summary>
        /// <param name="value">if set to <c>true</c> [value].</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator IndicatorType(System.Boolean value)
        {
            return new IndicatorType { Value = value };
        }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="IndicatorType"/> is value.
        /// </summary>
        /// <value><c>true</c> if value; otherwise, <c>false</c>.</value>
        [System.Xml.Serialization.XmlTextAttribute()]
        public bool Value
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
    ///  Numeric information that is assigned or is determined by calculation, counting, or sequencing. It does not require a unit of quantity or unit of measure.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class NumericType
    {

        private decimal valueField;

        /// <summary>
        /// Performs an implicit conversion from <see cref="System.Decimal"/> to <see cref="NumericType"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator NumericType(System.Decimal value)
        {
            return new NumericType { Value = value };
        }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>The value.</value>
        [System.Xml.Serialization.XmlTextAttribute()]
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
    ///  Numeric information that is assigned or is determined by calculation, counting, or sequencing. It does not require a unit of quantity or unit of measure.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class PercentType
    {

        private decimal valueField;

        /// <summary>
        /// Performs an implicit conversion from <see cref="System.Decimal"/> to <see cref="PercentType"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator PercentType(System.Decimal value)
        {
            return new PercentType { Value = value };
        }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>The value.</value>
        [System.Xml.Serialization.XmlTextAttribute()]
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
    ///  Numeric information that is assigned or is determined by calculation, counting, or sequencing. It does not require a unit of quantity or unit of measuret.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class RateType
    {

        private decimal valueField;

        /// <summary>
        /// Performs an implicit conversion from <see cref="System.Decimal"/> to <see cref="RateType"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator RateType(System.Decimal value)
        {
            return new RateType { Value = value };
        }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>The value.</value>
        [System.Xml.Serialization.XmlTextAttribute()]
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
 
}
