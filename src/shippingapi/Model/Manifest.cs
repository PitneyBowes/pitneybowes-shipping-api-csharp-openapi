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
    /// Manifest
    /// </summary>
    [DataContract]
    public partial class Manifest :  IEquatable<Manifest>, IValidatableObject
    {
        /// <summary>
        /// Defines Carrier
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CarrierEnum
        {
            /// <summary>
            /// Enum USPS for value: USPS
            /// </summary>
            [EnumMember(Value = "USPS")]
            USPS = 1,

            /// <summary>
            /// Enum NEWGISTICS for value: NEWGISTICS
            /// </summary>
            [EnumMember(Value = "NEWGISTICS")]
            NEWGISTICS = 2,

            /// <summary>
            /// Enum PBPresort for value: PBPresort
            /// </summary>
            [EnumMember(Value = "PBPresort")]
            PBPresort = 3,

            /// <summary>
            /// Enum PBCS for value: PBCS
            /// </summary>
            [EnumMember(Value = "PBCS")]
            PBCS = 4

        }

        /// <summary>
        /// Gets or Sets Carrier
        /// </summary>
        [DataMember(Name="carrier", EmitDefaultValue=true)]
        public CarrierEnum Carrier { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Manifest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Manifest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Manifest" /> class.
        /// </summary>
        /// <param name="carrier">carrier (required).</param>
        /// <param name="documents">documents.</param>
        /// <param name="fromAddress">fromAddress.</param>
        /// <param name="inductionPostalCode">inductionPostalCode.</param>
        /// <param name="manifestId">manifestId.</param>
        /// <param name="manifestTrackingNumber">manifestTrackingNumber.</param>
        /// <param name="parameters">parameters.</param>
        /// <param name="parcelTrackingNumbers">parcelTrackingNumbers.</param>
        /// <param name="submissionDate">submissionDate (required).</param>
        public Manifest(CarrierEnum carrier = default(CarrierEnum), List<Document> documents = default(List<Document>), Address fromAddress = default(Address), string inductionPostalCode = default(string), string manifestId = default(string), string manifestTrackingNumber = default(string), List<Parameter> parameters = default(List<Parameter>), List<string> parcelTrackingNumbers = default(List<string>), string submissionDate = default(string))
        {
            // to ensure "carrier" is required (not null)
            if (carrier == null)
            {
                throw new InvalidDataException("carrier is a required property for Manifest and cannot be null");
            }
            else
            {
                this.Carrier = carrier;
            }
            
            // to ensure "submissionDate" is required (not null)
            if (submissionDate == null)
            {
                throw new InvalidDataException("submissionDate is a required property for Manifest and cannot be null");
            }
            else
            {
                this.SubmissionDate = submissionDate;
            }
            
            this.Documents = documents;
            this.FromAddress = fromAddress;
            this.InductionPostalCode = inductionPostalCode;
            this.ManifestId = manifestId;
            this.ManifestTrackingNumber = manifestTrackingNumber;
            this.Parameters = parameters;
            this.ParcelTrackingNumbers = parcelTrackingNumbers;
        }
        

        /// <summary>
        /// Gets or Sets Documents
        /// </summary>
        [DataMember(Name="documents", EmitDefaultValue=false)]
        public List<Document> Documents { get; set; }

        /// <summary>
        /// Gets or Sets FromAddress
        /// </summary>
        [DataMember(Name="fromAddress", EmitDefaultValue=false)]
        public Address FromAddress { get; set; }

        /// <summary>
        /// Gets or Sets InductionPostalCode
        /// </summary>
        [DataMember(Name="inductionPostalCode", EmitDefaultValue=false)]
        public string InductionPostalCode { get; set; }

        /// <summary>
        /// Gets or Sets ManifestId
        /// </summary>
        [DataMember(Name="manifestId", EmitDefaultValue=false)]
        public string ManifestId { get; set; }

        /// <summary>
        /// Gets or Sets ManifestTrackingNumber
        /// </summary>
        [DataMember(Name="manifestTrackingNumber", EmitDefaultValue=false)]
        public string ManifestTrackingNumber { get; set; }

        /// <summary>
        /// Gets or Sets Parameters
        /// </summary>
        [DataMember(Name="parameters", EmitDefaultValue=false)]
        public List<Parameter> Parameters { get; set; }

        /// <summary>
        /// Gets or Sets ParcelTrackingNumbers
        /// </summary>
        [DataMember(Name="parcelTrackingNumbers", EmitDefaultValue=false)]
        public List<string> ParcelTrackingNumbers { get; set; }

        /// <summary>
        /// Gets or Sets SubmissionDate
        /// </summary>
        [DataMember(Name="submissionDate", EmitDefaultValue=true)]
        public string SubmissionDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Manifest {\n");
            sb.Append("  Carrier: ").Append(Carrier).Append("\n");
            sb.Append("  Documents: ").Append(Documents).Append("\n");
            sb.Append("  FromAddress: ").Append(FromAddress).Append("\n");
            sb.Append("  InductionPostalCode: ").Append(InductionPostalCode).Append("\n");
            sb.Append("  ManifestId: ").Append(ManifestId).Append("\n");
            sb.Append("  ManifestTrackingNumber: ").Append(ManifestTrackingNumber).Append("\n");
            sb.Append("  Parameters: ").Append(Parameters).Append("\n");
            sb.Append("  ParcelTrackingNumbers: ").Append(ParcelTrackingNumbers).Append("\n");
            sb.Append("  SubmissionDate: ").Append(SubmissionDate).Append("\n");
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
            return this.Equals(input as Manifest);
        }

        /// <summary>
        /// Returns true if Manifest instances are equal
        /// </summary>
        /// <param name="input">Instance of Manifest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Manifest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Carrier == input.Carrier ||
                    (this.Carrier != null &&
                    this.Carrier.Equals(input.Carrier))
                ) && 
                (
                    this.Documents == input.Documents ||
                    this.Documents != null &&
                    input.Documents != null &&
                    this.Documents.SequenceEqual(input.Documents)
                ) && 
                (
                    this.FromAddress == input.FromAddress ||
                    (this.FromAddress != null &&
                    this.FromAddress.Equals(input.FromAddress))
                ) && 
                (
                    this.InductionPostalCode == input.InductionPostalCode ||
                    (this.InductionPostalCode != null &&
                    this.InductionPostalCode.Equals(input.InductionPostalCode))
                ) && 
                (
                    this.ManifestId == input.ManifestId ||
                    (this.ManifestId != null &&
                    this.ManifestId.Equals(input.ManifestId))
                ) && 
                (
                    this.ManifestTrackingNumber == input.ManifestTrackingNumber ||
                    (this.ManifestTrackingNumber != null &&
                    this.ManifestTrackingNumber.Equals(input.ManifestTrackingNumber))
                ) && 
                (
                    this.Parameters == input.Parameters ||
                    this.Parameters != null &&
                    input.Parameters != null &&
                    this.Parameters.SequenceEqual(input.Parameters)
                ) && 
                (
                    this.ParcelTrackingNumbers == input.ParcelTrackingNumbers ||
                    this.ParcelTrackingNumbers != null &&
                    input.ParcelTrackingNumbers != null &&
                    this.ParcelTrackingNumbers.SequenceEqual(input.ParcelTrackingNumbers)
                ) && 
                (
                    this.SubmissionDate == input.SubmissionDate ||
                    (this.SubmissionDate != null &&
                    this.SubmissionDate.Equals(input.SubmissionDate))
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
                if (this.Carrier != null)
                    hashCode = hashCode * 59 + this.Carrier.GetHashCode();
                if (this.Documents != null)
                    hashCode = hashCode * 59 + this.Documents.GetHashCode();
                if (this.FromAddress != null)
                    hashCode = hashCode * 59 + this.FromAddress.GetHashCode();
                if (this.InductionPostalCode != null)
                    hashCode = hashCode * 59 + this.InductionPostalCode.GetHashCode();
                if (this.ManifestId != null)
                    hashCode = hashCode * 59 + this.ManifestId.GetHashCode();
                if (this.ManifestTrackingNumber != null)
                    hashCode = hashCode * 59 + this.ManifestTrackingNumber.GetHashCode();
                if (this.Parameters != null)
                    hashCode = hashCode * 59 + this.Parameters.GetHashCode();
                if (this.ParcelTrackingNumbers != null)
                    hashCode = hashCode * 59 + this.ParcelTrackingNumbers.GetHashCode();
                if (this.SubmissionDate != null)
                    hashCode = hashCode * 59 + this.SubmissionDate.GetHashCode();
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
