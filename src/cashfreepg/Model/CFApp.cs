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
    /// CFApp
    /// </summary>
    [DataContract(Name = "CFApp")]
    public partial class CFApp : IEquatable<CFApp>, IValidatableObject
    {
        /// <summary>
        /// The channel has to be set to link
        /// </summary>
        /// <value>The channel has to be set to link</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ChannelEnum
        {
            /// <summary>
            /// Enum Link for value: link
            /// </summary>
            [EnumMember(Value = "link")]
            Link = 1

        }


        /// <summary>
        /// The channel has to be set to link
        /// </summary>
        /// <value>The channel has to be set to link</value>
        [DataMember(Name = "channel", IsRequired = true, EmitDefaultValue = false)]
        public string Channel { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CFApp" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CFApp() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CFApp" /> class.
        /// </summary>
        /// <param name="channel">The channel has to be set to link (required).</param>
        /// <param name="provider">Specify the channel through which the payment must be processed. (required).</param>
        /// <param name="phone">Customer phone number associated with a wallet for payment. (required).</param>
        public CFApp(string provider, string phone, string channel = "link")
        {
            this.Channel = channel;
            // to ensure "provider" is required (not null)
            if (provider == null) {
                throw new ArgumentNullException("provider is a required property for CFApp and cannot be null");
            }
            this.Provider = provider;
            // to ensure "phone" is required (not null)
            if (phone == null) {
                throw new ArgumentNullException("phone is a required property for CFApp and cannot be null");
            }
            this.Phone = phone;
        }

        /// <summary>
        /// Specify the channel through which the payment must be processed.
        /// </summary>
        /// <value>Specify the channel through which the payment must be processed.</value>
        [DataMember(Name = "provider", IsRequired = true, EmitDefaultValue = false)]
        public string Provider { get; set; }

        /// <summary>
        /// Customer phone number associated with a wallet for payment.
        /// </summary>
        /// <value>Customer phone number associated with a wallet for payment.</value>
        [DataMember(Name = "phone", IsRequired = true, EmitDefaultValue = false)]
        public string Phone { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CFApp {\n");
            sb.Append("  Channel: ").Append(Channel).Append("\n");
            sb.Append("  Provider: ").Append(Provider).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
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
            return this.Equals(input as CFApp);
        }

        /// <summary>
        /// Returns true if CFApp instances are equal
        /// </summary>
        /// <param name="input">Instance of CFApp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CFApp? input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Channel == input.Channel ||
                    this.Channel.Equals(input.Channel)
                ) && 
                (
                    this.Provider == input.Provider ||
                    (this.Provider != null &&
                    this.Provider.Equals(input.Provider))
                ) && 
                (
                    this.Phone == input.Phone ||
                    (this.Phone != null &&
                    this.Phone.Equals(input.Phone))
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
                hashCode = (hashCode * 59) + this.Channel.GetHashCode();
                if (this.Provider != null)
                {
                    hashCode = (hashCode * 59) + this.Provider.GetHashCode();
                }
                if (this.Phone != null)
                {
                    hashCode = (hashCode * 59) + this.Phone.GetHashCode();
                }
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
