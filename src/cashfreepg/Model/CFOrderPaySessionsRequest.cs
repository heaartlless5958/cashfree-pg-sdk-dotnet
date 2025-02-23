/*
 * New Payment Gateway APIs
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 2022-01-01
 * Contact: nextgenapi@cashfree.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = cashfreepg.Client.OpenAPIDateConverter;

namespace cashfreepg.Model
{
    /// <summary>
    /// CFOrderPaySessionsRequest
    /// </summary>
    [DataContract(Name = "CFOrderPaySessionsRequest")]
    public partial class CFOrderPaySessionsRequest : IEquatable<CFOrderPaySessionsRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CFOrderPaySessionsRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CFOrderPaySessionsRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CFOrderPaySessionsRequest" /> class.
        /// </summary>
        /// <param name="paymentSessionId">paymentSessionId (required).</param>
        /// <param name="paymentMethod">paymentMethod (required).</param>
        /// <param name="saveInstrument">saveInstrument.</param>
        public CFOrderPaySessionsRequest(string? paymentSessionId = default(string?), CFPaymentMethod? paymentMethod = default(CFPaymentMethod?), bool? saveInstrument = default(bool?))
        {
            // to ensure "paymentSessionId" is required (not null)
            if (paymentSessionId == null) {
                throw new ArgumentNullException("paymentSessionId is a required property for CFOrderPaySessionsRequest and cannot be null");
            }
            this.paymentSessionId = paymentSessionId;
            // to ensure "paymentMethod" is required (not null)
            if (paymentMethod == null) {
                throw new ArgumentNullException("paymentMethod is a required property for CFOrderPaySessionsRequest and cannot be null");
            }
            this.PaymentMethod = paymentMethod;
            this.SaveInstrument = saveInstrument;
        }

        /// <summary>
        /// Gets or Sets paymentSessionId
        /// </summary>
        [DataMember(Name = "payment_session_id", IsRequired = true, EmitDefaultValue = false)]
        public string? paymentSessionId { get; set; }

        /// <summary>
        /// Gets or Sets PaymentMethod
        /// </summary>
        [DataMember(Name = "payment_method", IsRequired = true, EmitDefaultValue = false)]
        public CFPaymentMethod? PaymentMethod { get; set; }

        /// <summary>
        /// Gets or Sets SaveInstrument
        /// </summary>
        [DataMember(Name = "save_instrument", EmitDefaultValue = true)]
        public bool? SaveInstrument { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CFOrderPaySessionsRequest {\n");
            sb.Append("  paymentSessionId: ").Append(paymentSessionId).Append("\n");
            sb.Append("  PaymentMethod: ").Append(PaymentMethod).Append("\n");
            sb.Append("  SaveInstrument: ").Append(SaveInstrument).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object? input)
        {
            return this.Equals(input as CFOrderPaySessionsRequest);
        }

        /// <summary>
        /// Returns true if CFOrderPaySessionsRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CFOrderPaySessionsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CFOrderPaySessionsRequest? input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.paymentSessionId == input.paymentSessionId ||
                    (this.paymentSessionId != null &&
                    this.paymentSessionId.Equals(input.paymentSessionId))
                ) && 
                (
                    this.PaymentMethod == input.PaymentMethod ||
                    (this.PaymentMethod != null &&
                    this.PaymentMethod.Equals(input.PaymentMethod))
                ) && 
                (
                    this.SaveInstrument == input.SaveInstrument ||
                    this.SaveInstrument.Equals(input.SaveInstrument)
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
                if (this.paymentSessionId != null)
                {
                    hashCode = (hashCode * 59) + this.paymentSessionId.GetHashCode();
                }
                if (this.PaymentMethod != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentMethod.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SaveInstrument.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
