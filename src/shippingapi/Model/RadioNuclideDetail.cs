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
    /// RadioNuclideDetail
    /// </summary>
    [DataContract]
    public partial class RadioNuclideDetail :  IEquatable<RadioNuclideDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RadioNuclideDetail" /> class.
        /// </summary>
        /// <param name="chemicalForm">chemicalForm.</param>
        /// <param name="expectedPackageReportableQuantity">expectedPackageReportableQuantity.</param>
        /// <param name="physicalForm">physicalForm.</param>
        /// <param name="radioNuclide">radioNuclide.</param>
        /// <param name="radioNuclideActivityUOM">radioNuclideActivityUOM.</param>
        /// <param name="radioNuclideActivityValue">radioNuclideActivityValue.</param>
        public RadioNuclideDetail(string chemicalForm = default(string), bool expectedPackageReportableQuantity = default(bool), string physicalForm = default(string), string radioNuclide = default(string), string radioNuclideActivityUOM = default(string), decimal radioNuclideActivityValue = default(decimal))
        {
            this.ChemicalForm = chemicalForm;
            this.ExpectedPackageReportableQuantity = expectedPackageReportableQuantity;
            this.PhysicalForm = physicalForm;
            this.RadioNuclide = radioNuclide;
            this.RadioNuclideActivityUOM = radioNuclideActivityUOM;
            this.RadioNuclideActivityValue = radioNuclideActivityValue;
        }
        
        /// <summary>
        /// Gets or Sets ChemicalForm
        /// </summary>
        [DataMember(Name="chemicalForm", EmitDefaultValue=false)]
        public string ChemicalForm { get; set; }

        /// <summary>
        /// Gets or Sets ExpectedPackageReportableQuantity
        /// </summary>
        [DataMember(Name="expectedPackageReportableQuantity", EmitDefaultValue=false)]
        public bool ExpectedPackageReportableQuantity { get; set; }

        /// <summary>
        /// Gets or Sets PhysicalForm
        /// </summary>
        [DataMember(Name="physicalForm", EmitDefaultValue=false)]
        public string PhysicalForm { get; set; }

        /// <summary>
        /// Gets or Sets RadioNuclide
        /// </summary>
        [DataMember(Name="radioNuclide", EmitDefaultValue=false)]
        public string RadioNuclide { get; set; }

        /// <summary>
        /// Gets or Sets RadioNuclideActivityUOM
        /// </summary>
        [DataMember(Name="radioNuclideActivityUOM", EmitDefaultValue=false)]
        public string RadioNuclideActivityUOM { get; set; }

        /// <summary>
        /// Gets or Sets RadioNuclideActivityValue
        /// </summary>
        [DataMember(Name="radioNuclideActivityValue", EmitDefaultValue=false)]
        public decimal RadioNuclideActivityValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RadioNuclideDetail {\n");
            sb.Append("  ChemicalForm: ").Append(ChemicalForm).Append("\n");
            sb.Append("  ExpectedPackageReportableQuantity: ").Append(ExpectedPackageReportableQuantity).Append("\n");
            sb.Append("  PhysicalForm: ").Append(PhysicalForm).Append("\n");
            sb.Append("  RadioNuclide: ").Append(RadioNuclide).Append("\n");
            sb.Append("  RadioNuclideActivityUOM: ").Append(RadioNuclideActivityUOM).Append("\n");
            sb.Append("  RadioNuclideActivityValue: ").Append(RadioNuclideActivityValue).Append("\n");
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
            return this.Equals(input as RadioNuclideDetail);
        }

        /// <summary>
        /// Returns true if RadioNuclideDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of RadioNuclideDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RadioNuclideDetail input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ChemicalForm == input.ChemicalForm ||
                    (this.ChemicalForm != null &&
                    this.ChemicalForm.Equals(input.ChemicalForm))
                ) && 
                (
                    this.ExpectedPackageReportableQuantity == input.ExpectedPackageReportableQuantity ||
                    (this.ExpectedPackageReportableQuantity != null &&
                    this.ExpectedPackageReportableQuantity.Equals(input.ExpectedPackageReportableQuantity))
                ) && 
                (
                    this.PhysicalForm == input.PhysicalForm ||
                    (this.PhysicalForm != null &&
                    this.PhysicalForm.Equals(input.PhysicalForm))
                ) && 
                (
                    this.RadioNuclide == input.RadioNuclide ||
                    (this.RadioNuclide != null &&
                    this.RadioNuclide.Equals(input.RadioNuclide))
                ) && 
                (
                    this.RadioNuclideActivityUOM == input.RadioNuclideActivityUOM ||
                    (this.RadioNuclideActivityUOM != null &&
                    this.RadioNuclideActivityUOM.Equals(input.RadioNuclideActivityUOM))
                ) && 
                (
                    this.RadioNuclideActivityValue == input.RadioNuclideActivityValue ||
                    (this.RadioNuclideActivityValue != null &&
                    this.RadioNuclideActivityValue.Equals(input.RadioNuclideActivityValue))
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
                if (this.ChemicalForm != null)
                    hashCode = hashCode * 59 + this.ChemicalForm.GetHashCode();
                if (this.ExpectedPackageReportableQuantity != null)
                    hashCode = hashCode * 59 + this.ExpectedPackageReportableQuantity.GetHashCode();
                if (this.PhysicalForm != null)
                    hashCode = hashCode * 59 + this.PhysicalForm.GetHashCode();
                if (this.RadioNuclide != null)
                    hashCode = hashCode * 59 + this.RadioNuclide.GetHashCode();
                if (this.RadioNuclideActivityUOM != null)
                    hashCode = hashCode * 59 + this.RadioNuclideActivityUOM.GetHashCode();
                if (this.RadioNuclideActivityValue != null)
                    hashCode = hashCode * 59 + this.RadioNuclideActivityValue.GetHashCode();
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
