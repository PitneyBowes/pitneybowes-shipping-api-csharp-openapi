using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace shippingapi.Model
{
    /// <summary>
    /// DomesticShipmentDetails
    /// </summary>
    [DataContract]
    public partial class DomesticShipmentDetails : IEquatable<DomesticShipmentDetails>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="DomesticShipmentDetails" /> class.
        /// </summary>
        /// <param name="shipperTrackingNumber">shipperTrackingNumber.</param>
        /// <param name="barCodeLabelNumber">BarCodeLabelNumber.</param>

        public DomesticShipmentDetails(string shipperTrackingNumber = default(string), string barCodeLabelNumber = default(string))
    {
        this.ShipperTrackingNumber = shipperTrackingNumber;
        this.BarCodeLabelNumber = barCodeLabelNumber;

    }

    /// <summary>
    /// Gets or Sets ShipperTrackingNumber
    /// </summary>
    [DataMember(Name = "shipperTrackingNumber", EmitDefaultValue = false)]
    public string ShipperTrackingNumber { get; set; }


    /// <summary>
    /// Gets or Sets ShipperTrackingNumber
    /// </summary>
    [DataMember(Name = "barCodeLabelNumber", EmitDefaultValue = false)]
    public string BarCodeLabelNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DomesticShipmentDetails {\n");
        sb.Append("  ShipperTrackingNumber: ").Append(ShipperTrackingNumber).Append("\n");
        sb.Append("  BarCodeLabelNumber: ").Append(BarCodeLabelNumber).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }

    /// <summary>
    /// Returns the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public virtual string ToJson()
    {
        return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

    /// <summary>
    /// Returns true if objects are equal
    /// </summary>
    /// <param name="input">Object to be compared</param>
    /// <returns>Boolean</returns>
    public override bool Equals(object input)
    {
        return this.Equals(input as DomesticShipmentDetails);
    }

    /// <summary>
    /// Returns true if ShipperTrackingNumber instances are equal
    /// </summary>
    /// <param name="input">Instance of ShipperTrackingNumber to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DomesticShipmentDetails input)
    {
        if (input == null)
            return false;

        return
            (
                this.ShipperTrackingNumber == input.ShipperTrackingNumber ||
                (this.ShipperTrackingNumber != null &&
                this.ShipperTrackingNumber.Equals(input.ShipperTrackingNumber))
            ) &&
            (
                this.BarCodeLabelNumber == input.BarCodeLabelNumber ||
                (this.BarCodeLabelNumber != null &&
                this.BarCodeLabelNumber.Equals(input.BarCodeLabelNumber))
             );
    }

    /// <summary>
    /// Gets the hash code
    /// </summary>
    /// <returns>Hash code</returns>
    public override int GetHashCode()
    {
        unchecked // Overflow is fine, just wrap
        {
            int hashCode = 41;
            if (this.ShipperTrackingNumber != null)
                hashCode = hashCode * 59 + this.ShipperTrackingNumber.GetHashCode();

            return hashCode;
        }
    }

    /// <summary>
    /// To validate all properties of the instance
    /// </summary>
    /// <param name="validationContext">Validation context</param>
    /// <returns>Validation Result</returns>
    IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
    {
        yield break;
    }


}
}
