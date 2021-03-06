/* 
 * Shipping API
 *
 * Shipping API Sample.
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: support@pb.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = shippingapi.Client.OpenAPIDateConverter;

namespace shippingapi.Model
{
    /// <summary>
    /// CrossBorderQuotesResponseLineRates
    /// </summary>
    [DataContract]
    public partial class CrossBorderQuotesResponseLineRates :  IEquatable<CrossBorderQuotesResponseLineRates>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CrossBorderQuotesResponseLineRates" /> class.
        /// </summary>
        /// <param name="linePrice">linePrice.</param>
        /// <param name="totalTaxAmount">totalTaxAmount.</param>
        /// <param name="totalDutyAmount">totalDutyAmount.</param>
        /// <param name="serviceId">serviceId.</param>
        /// <param name="baseCharge">baseCharge.</param>
        /// <param name="deliveryCommitment">deliveryCommitment.</param>
        /// <param name="totalCarrierCharge">totalCarrierCharge.</param>
        public CrossBorderQuotesResponseLineRates(decimal linePrice = default(decimal), decimal totalTaxAmount = default(decimal), int totalDutyAmount = default(int), string serviceId = default(string), decimal baseCharge = default(decimal), CrossBorderQuotesResponseUnitRatesDeliveryCommitment deliveryCommitment = default(CrossBorderQuotesResponseUnitRatesDeliveryCommitment), decimal totalCarrierCharge = default(decimal))
        {
            this.LinePrice = linePrice;
            this.TotalTaxAmount = totalTaxAmount;
            this.TotalDutyAmount = totalDutyAmount;
            this.ServiceId = serviceId;
            this.BaseCharge = baseCharge;
            this.DeliveryCommitment = deliveryCommitment;
            this.TotalCarrierCharge = totalCarrierCharge;
        }
        
        /// <summary>
        /// Gets or Sets LinePrice
        /// </summary>
        [DataMember(Name="linePrice", EmitDefaultValue=false)]
        public decimal LinePrice { get; set; }

        /// <summary>
        /// Gets or Sets TotalTaxAmount
        /// </summary>
        [DataMember(Name="totalTaxAmount", EmitDefaultValue=false)]
        public decimal TotalTaxAmount { get; set; }

        /// <summary>
        /// Gets or Sets TotalDutyAmount
        /// </summary>
        [DataMember(Name="totalDutyAmount", EmitDefaultValue=false)]
        public int TotalDutyAmount { get; set; }

        /// <summary>
        /// Gets or Sets ServiceId
        /// </summary>
        [DataMember(Name="serviceId", EmitDefaultValue=false)]
        public string ServiceId { get; set; }

        /// <summary>
        /// Gets or Sets BaseCharge
        /// </summary>
        [DataMember(Name="baseCharge", EmitDefaultValue=false)]
        public decimal BaseCharge { get; set; }

        /// <summary>
        /// Gets or Sets DeliveryCommitment
        /// </summary>
        [DataMember(Name="deliveryCommitment", EmitDefaultValue=false)]
        public CrossBorderQuotesResponseUnitRatesDeliveryCommitment DeliveryCommitment { get; set; }

        /// <summary>
        /// Gets or Sets TotalCarrierCharge
        /// </summary>
        [DataMember(Name="totalCarrierCharge", EmitDefaultValue=false)]
        public decimal TotalCarrierCharge { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CrossBorderQuotesResponseLineRates {\n");
            sb.Append("  LinePrice: ").Append(LinePrice).Append("\n");
            sb.Append("  TotalTaxAmount: ").Append(TotalTaxAmount).Append("\n");
            sb.Append("  TotalDutyAmount: ").Append(TotalDutyAmount).Append("\n");
            sb.Append("  ServiceId: ").Append(ServiceId).Append("\n");
            sb.Append("  BaseCharge: ").Append(BaseCharge).Append("\n");
            sb.Append("  DeliveryCommitment: ").Append(DeliveryCommitment).Append("\n");
            sb.Append("  TotalCarrierCharge: ").Append(TotalCarrierCharge).Append("\n");
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
            return this.Equals(input as CrossBorderQuotesResponseLineRates);
        }

        /// <summary>
        /// Returns true if CrossBorderQuotesResponseLineRates instances are equal
        /// </summary>
        /// <param name="input">Instance of CrossBorderQuotesResponseLineRates to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CrossBorderQuotesResponseLineRates input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LinePrice == input.LinePrice ||
                    (this.LinePrice != null &&
                    this.LinePrice.Equals(input.LinePrice))
                ) && 
                (
                    this.TotalTaxAmount == input.TotalTaxAmount ||
                    (this.TotalTaxAmount != null &&
                    this.TotalTaxAmount.Equals(input.TotalTaxAmount))
                ) && 
                (
                    this.TotalDutyAmount == input.TotalDutyAmount ||
                    (this.TotalDutyAmount != null &&
                    this.TotalDutyAmount.Equals(input.TotalDutyAmount))
                ) && 
                (
                    this.ServiceId == input.ServiceId ||
                    (this.ServiceId != null &&
                    this.ServiceId.Equals(input.ServiceId))
                ) && 
                (
                    this.BaseCharge == input.BaseCharge ||
                    (this.BaseCharge != null &&
                    this.BaseCharge.Equals(input.BaseCharge))
                ) && 
                (
                    this.DeliveryCommitment == input.DeliveryCommitment ||
                    (this.DeliveryCommitment != null &&
                    this.DeliveryCommitment.Equals(input.DeliveryCommitment))
                ) && 
                (
                    this.TotalCarrierCharge == input.TotalCarrierCharge ||
                    (this.TotalCarrierCharge != null &&
                    this.TotalCarrierCharge.Equals(input.TotalCarrierCharge))
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
                if (this.LinePrice != null)
                    hashCode = hashCode * 59 + this.LinePrice.GetHashCode();
                if (this.TotalTaxAmount != null)
                    hashCode = hashCode * 59 + this.TotalTaxAmount.GetHashCode();
                if (this.TotalDutyAmount != null)
                    hashCode = hashCode * 59 + this.TotalDutyAmount.GetHashCode();
                if (this.ServiceId != null)
                    hashCode = hashCode * 59 + this.ServiceId.GetHashCode();
                if (this.BaseCharge != null)
                    hashCode = hashCode * 59 + this.BaseCharge.GetHashCode();
                if (this.DeliveryCommitment != null)
                    hashCode = hashCode * 59 + this.DeliveryCommitment.GetHashCode();
                if (this.TotalCarrierCharge != null)
                    hashCode = hashCode * 59 + this.TotalCarrierCharge.GetHashCode();
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
