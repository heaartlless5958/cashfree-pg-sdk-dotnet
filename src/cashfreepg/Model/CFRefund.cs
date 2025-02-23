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
    /// CFRefund
    /// </summary>
    [DataContract(Name = "CFRefund")]
    public partial class CFRefund : IEquatable<CFRefund>, IValidatableObject
    {
        /// <summary>
        /// Type of object
        /// </summary>
        /// <value>Type of object</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EntityEnum
        {
            /// <summary>
            /// Enum Refund for value: refund
            /// </summary>
            [EnumMember(Value = "refund")]
            Refund = 1

        }


        /// <summary>
        /// Type of object
        /// </summary>
        /// <value>Type of object</value>
        [DataMember(Name = "entity", EmitDefaultValue = false)]
        public EntityEnum? Entity { get; set; }
        /// <summary>
        /// This can be one of [\&quot;SUCCESS\&quot;, \&quot;PENDING\&quot;, \&quot;CANCELLED\&quot;, \&quot;ONHOLD\&quot;]
        /// </summary>
        /// <value>This can be one of [\&quot;SUCCESS\&quot;, \&quot;PENDING\&quot;, \&quot;CANCELLED\&quot;, \&quot;ONHOLD\&quot;]</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RefundStatusEnum
        {
            /// <summary>
            /// Enum SUCCESS for value: SUCCESS
            /// </summary>
            [EnumMember(Value = "SUCCESS")]
            SUCCESS = 1,

            /// <summary>
            /// Enum PENDING for value: PENDING
            /// </summary>
            [EnumMember(Value = "PENDING")]
            PENDING = 2,

            /// <summary>
            /// Enum CANCELLED for value: CANCELLED
            /// </summary>
            [EnumMember(Value = "CANCELLED")]
            CANCELLED = 3,

            /// <summary>
            /// Enum ONHOLD for value: ONHOLD
            /// </summary>
            [EnumMember(Value = "ONHOLD")]
            ONHOLD = 4

        }


        /// <summary>
        /// This can be one of [\&quot;SUCCESS\&quot;, \&quot;PENDING\&quot;, \&quot;CANCELLED\&quot;, \&quot;ONHOLD\&quot;]
        /// </summary>
        /// <value>This can be one of [\&quot;SUCCESS\&quot;, \&quot;PENDING\&quot;, \&quot;CANCELLED\&quot;, \&quot;ONHOLD\&quot;]</value>
        [DataMember(Name = "refund_status", EmitDefaultValue = false)]
        public RefundStatusEnum? RefundStatus { get; set; }
        /// <summary>
        /// This can be one of [\&quot;PAYMENT_AUTO_REFUND\&quot;, \&quot;MERCHANT_INITIATED\&quot;, \&quot;UNRECONCILED_AUTO_REFUND\&quot;]
        /// </summary>
        /// <value>This can be one of [\&quot;PAYMENT_AUTO_REFUND\&quot;, \&quot;MERCHANT_INITIATED\&quot;, \&quot;UNRECONCILED_AUTO_REFUND\&quot;]</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RefundTypeEnum
        {
            /// <summary>
            /// Enum PAYMENTAUTOREFUND for value: PAYMENT_AUTO_REFUND
            /// </summary>
            [EnumMember(Value = "PAYMENT_AUTO_REFUND")]
            PAYMENTAUTOREFUND = 1,

            /// <summary>
            /// Enum MERCHANTINITIATED for value: MERCHANT_INITIATED
            /// </summary>
            [EnumMember(Value = "MERCHANT_INITIATED")]
            MERCHANTINITIATED = 2,

            /// <summary>
            /// Enum UNRECONCILEDAUTOREFUND for value: UNRECONCILED_AUTO_REFUND
            /// </summary>
            [EnumMember(Value = "UNRECONCILED_AUTO_REFUND")]
            UNRECONCILEDAUTOREFUND = 3

        }


        /// <summary>
        /// This can be one of [\&quot;PAYMENT_AUTO_REFUND\&quot;, \&quot;MERCHANT_INITIATED\&quot;, \&quot;UNRECONCILED_AUTO_REFUND\&quot;]
        /// </summary>
        /// <value>This can be one of [\&quot;PAYMENT_AUTO_REFUND\&quot;, \&quot;MERCHANT_INITIATED\&quot;, \&quot;UNRECONCILED_AUTO_REFUND\&quot;]</value>
        [DataMember(Name = "refund_type", EmitDefaultValue = false)]
        public RefundTypeEnum? RefundType { get; set; }
        /// <summary>
        /// Method or speed of processing refund
        /// </summary>
        /// <value>Method or speed of processing refund</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RefundModeEnum
        {
            /// <summary>
            /// Enum STANDARD for value: STANDARD
            /// </summary>
            [EnumMember(Value = "STANDARD")]
            STANDARD = 1,

            /// <summary>
            /// Enum INSTANT for value: INSTANT
            /// </summary>
            [EnumMember(Value = "INSTANT")]
            INSTANT = 2

        }


        /// <summary>
        /// Method or speed of processing refund
        /// </summary>
        /// <value>Method or speed of processing refund</value>
        [DataMember(Name = "refund_mode", EmitDefaultValue = false)]
        public RefundModeEnum? RefundMode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CFRefund" /> class.
        /// </summary>
        /// <param name="cfPaymentId">Cashfree Payments ID of the payment for which refund is initiated.</param>
        /// <param name="cfRefundId">Cashfree Payments ID for a refund.</param>
        /// <param name="orderId">Merchant’s order Id of the order for which refund is initiated.</param>
        /// <param name="refundId">Merchant’s refund ID of the refund.</param>
        /// <param name="entity">Type of object.</param>
        /// <param name="refundAmount">Amount that is refunded.</param>
        /// <param name="refundCurrency">Currency of the refund amount.</param>
        /// <param name="refundNote">Note added by merchant for the refund.</param>
        /// <param name="refundStatus">This can be one of [\&quot;SUCCESS\&quot;, \&quot;PENDING\&quot;, \&quot;CANCELLED\&quot;, \&quot;ONHOLD\&quot;].</param>
        /// <param name="refundArn">The bank reference number for refund.</param>
        /// <param name="refundCharge">Charges in INR for processing refund.</param>
        /// <param name="statusDescription">Description of refund status.</param>
        /// <param name="metadata">Key-value pair that can be used to store additional information about the entity. Maximum 5 key-value pairs.</param>
        /// <param name="refundSplits">refundSplits.</param>
        /// <param name="refundType">This can be one of [\&quot;PAYMENT_AUTO_REFUND\&quot;, \&quot;MERCHANT_INITIATED\&quot;, \&quot;UNRECONCILED_AUTO_REFUND\&quot;].</param>
        /// <param name="refundMode">Method or speed of processing refund.</param>
        /// <param name="createdAt">Time of refund creation.</param>
        /// <param name="processedAt">Time when refund was processed successfully.</param>
        /// <param name="refundSpeed">Speed at which the refund was processed</param>
        public CFRefund(long? cfPaymentId = default(long?), string? cfRefundId = default(string?), string? orderId = default(string?), string? refundId = default(string?), EntityEnum? entity = default(EntityEnum?), decimal? refundAmount = default(decimal?), string? refundCurrency = default(string?), string? refundNote = default(string?), RefundStatusEnum? refundStatus = default(RefundStatusEnum?), string? refundArn = default(string?), decimal? refundCharge = default(decimal?), string? statusDescription = default(string?), Object? metadata = default(Object?), List<CFVendorSplit>? refundSplits = default(List<CFVendorSplit>?), RefundTypeEnum? refundType = default(RefundTypeEnum?), RefundModeEnum? refundMode = default(RefundModeEnum?), string? createdAt = default(string?), string? processedAt = default(string?), CFRefundSpeed? refundSpeed = default(CFRefundSpeed?))
        {
            this.CfPaymentId = cfPaymentId;
            this.CfRefundId = cfRefundId;
            this.OrderId = orderId;
            this.RefundId = refundId;
            this.Entity = entity;
            this.RefundAmount = refundAmount;
            this.RefundCurrency = refundCurrency;
            this.RefundNote = refundNote;
            this.RefundStatus = refundStatus;
            this.RefundArn = refundArn;
            this.RefundCharge = refundCharge;
            this.StatusDescription = statusDescription;
            this.Metadata = metadata;
            this.RefundSplits = refundSplits;
            this.RefundType = refundType;
            this.RefundMode = refundMode;
            this.CreatedAt = createdAt;
            this.ProcessedAt = processedAt;
            this.RefundSpeed = refundSpeed;
        }

        /// <summary>
        /// Cashfree Payments ID of the payment for which refund is initiated
        /// </summary>
        /// <value>Cashfree Payments ID of the payment for which refund is initiated</value>
        [DataMember(Name = "cf_payment_id", EmitDefaultValue = false)]
        public long? CfPaymentId { get; set; }

        /// <summary>
        /// Refund Speed Object
        /// </summary>
        /// <value>Refund Speed information</value>
        [DataMember(Name = "refund_speed", EmitDefaultValue = false)]
        public CFRefundSpeed? RefundSpeed { get; set; }

        /// <summary>
        /// Cashfree Payments ID for a refund
        /// </summary>
        /// <value>Cashfree Payments ID for a refund</value>
        [DataMember(Name = "cf_refund_id", EmitDefaultValue = false)]
        public string? CfRefundId { get; set; }

        /// <summary>
        /// Merchant’s order Id of the order for which refund is initiated
        /// </summary>
        /// <value>Merchant’s order Id of the order for which refund is initiated</value>
        [DataMember(Name = "order_id", EmitDefaultValue = false)]
        public string? OrderId { get; set; }

        /// <summary>
        /// Merchant’s refund ID of the refund
        /// </summary>
        /// <value>Merchant’s refund ID of the refund</value>
        [DataMember(Name = "refund_id", EmitDefaultValue = false)]
        public string? RefundId { get; set; }

        /// <summary>
        /// Amount that is refunded
        /// </summary>
        /// <value>Amount that is refunded</value>
        [DataMember(Name = "refund_amount", EmitDefaultValue = false)]
        public decimal? RefundAmount { get; set; }

        /// <summary>
        /// Currency of the refund amount
        /// </summary>
        /// <value>Currency of the refund amount</value>
        [DataMember(Name = "refund_currency", EmitDefaultValue = false)]
        public string? RefundCurrency { get; set; }

        /// <summary>
        /// Note added by merchant for the refund
        /// </summary>
        /// <value>Note added by merchant for the refund</value>
        [DataMember(Name = "refund_note", EmitDefaultValue = false)]
        public string? RefundNote { get; set; }

        /// <summary>
        /// The bank reference number for refund
        /// </summary>
        /// <value>The bank reference number for refund</value>
        [DataMember(Name = "refund_arn", EmitDefaultValue = false)]
        public string? RefundArn { get; set; }

        /// <summary>
        /// Charges in INR for processing refund
        /// </summary>
        /// <value>Charges in INR for processing refund</value>
        [DataMember(Name = "refund_charge", EmitDefaultValue = false)]
        public decimal? RefundCharge { get; set; }

        /// <summary>
        /// Description of refund status
        /// </summary>
        /// <value>Description of refund status</value>
        [DataMember(Name = "status_description", EmitDefaultValue = false)]
        public string? StatusDescription { get; set; }

        /// <summary>
        /// Key-value pair that can be used to store additional information about the entity. Maximum 5 key-value pairs
        /// </summary>
        /// <value>Key-value pair that can be used to store additional information about the entity. Maximum 5 key-value pairs</value>
        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        public Object? Metadata { get; set; }

        /// <summary>
        /// Gets or Sets RefundSplits
        /// </summary>
        [DataMember(Name = "refund_splits", EmitDefaultValue = false)]
        public List<CFVendorSplit>? RefundSplits { get; set; }

        /// <summary>
        /// Time of refund creation
        /// </summary>
        /// <value>Time of refund creation</value>
        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// Time when refund was processed successfully
        /// </summary>
        /// <value>Time when refund was processed successfully</value>
        [DataMember(Name = "processed_at", EmitDefaultValue = false)]
        public string? ProcessedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CFRefund {\n");
            sb.Append("  CfPaymentId: ").Append(CfPaymentId).Append("\n");
            sb.Append("  CfRefundId: ").Append(CfRefundId).Append("\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  RefundId: ").Append(RefundId).Append("\n");
            sb.Append("  Entity: ").Append(Entity).Append("\n");
            sb.Append("  RefundAmount: ").Append(RefundAmount).Append("\n");
            sb.Append("  RefundCurrency: ").Append(RefundCurrency).Append("\n");
            sb.Append("  RefundNote: ").Append(RefundNote).Append("\n");
            sb.Append("  RefundStatus: ").Append(RefundStatus).Append("\n");
            sb.Append("  RefundArn: ").Append(RefundArn).Append("\n");
            sb.Append("  RefundCharge: ").Append(RefundCharge).Append("\n");
            sb.Append("  StatusDescription: ").Append(StatusDescription).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  RefundSplits: ").Append(RefundSplits).Append("\n");
            sb.Append("  RefundType: ").Append(RefundType).Append("\n");
            sb.Append("  RefundMode: ").Append(RefundMode).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  ProcessedAt: ").Append(ProcessedAt).Append("\n");
            sb.Append("  RefundSpeed: ").Append(RefundSpeed).Append("\n");
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
            return this.Equals(input as CFRefund);
        }

        /// <summary>
        /// Returns true if CFRefund instances are equal
        /// </summary>
        /// <param name="input">Instance of CFRefund to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CFRefund? input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CfPaymentId == input.CfPaymentId ||
                    this.CfPaymentId.Equals(input.CfPaymentId)
                ) && 
                (
                    this.CfRefundId == input.CfRefundId ||
                    (this.CfRefundId != null &&
                    this.CfRefundId.Equals(input.CfRefundId))
                ) && 
                (
                    this.OrderId == input.OrderId ||
                    (this.OrderId != null &&
                    this.OrderId.Equals(input.OrderId))
                ) && 
                (
                    this.RefundId == input.RefundId ||
                    (this.RefundId != null &&
                    this.RefundId.Equals(input.RefundId))
                ) && 
                (
                    this.Entity == input.Entity ||
                    this.Entity.Equals(input.Entity)
                ) && 
                (
                    this.RefundAmount == input.RefundAmount ||
                    this.RefundAmount.Equals(input.RefundAmount)
                ) && 
                (
                    this.RefundCurrency == input.RefundCurrency ||
                    (this.RefundCurrency != null &&
                    this.RefundCurrency.Equals(input.RefundCurrency))
                ) && 
                (
                    this.RefundNote == input.RefundNote ||
                    (this.RefundNote != null &&
                    this.RefundNote.Equals(input.RefundNote))
                ) && 
                (
                    this.RefundStatus == input.RefundStatus ||
                    this.RefundStatus.Equals(input.RefundStatus)
                ) && 
                (
                    this.RefundArn == input.RefundArn ||
                    (this.RefundArn != null &&
                    this.RefundArn.Equals(input.RefundArn))
                ) && 
                (
                    this.RefundCharge == input.RefundCharge ||
                    this.RefundCharge.Equals(input.RefundCharge)
                ) && 
                (
                    this.StatusDescription == input.StatusDescription ||
                    (this.StatusDescription != null &&
                    this.StatusDescription.Equals(input.StatusDescription))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))
                ) && 
                (
                    this.RefundSplits == input.RefundSplits ||
                    this.RefundSplits != null &&
                    input.RefundSplits != null &&
                    this.RefundSplits.SequenceEqual(input.RefundSplits)
                ) && 
                (
                    this.RefundType == input.RefundType ||
                    this.RefundType.Equals(input.RefundType)
                ) && 
                (
                    this.RefundMode == input.RefundMode ||
                    this.RefundMode.Equals(input.RefundMode)
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.ProcessedAt == input.ProcessedAt ||
                    (this.ProcessedAt != null &&
                    this.ProcessedAt.Equals(input.ProcessedAt))
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
                hashCode = (hashCode * 59) + this.CfPaymentId.GetHashCode();
                if (this.CfRefundId != null)
                {
                    hashCode = (hashCode * 59) + this.CfRefundId.GetHashCode();
                }
                if (this.OrderId != null)
                {
                    hashCode = (hashCode * 59) + this.OrderId.GetHashCode();
                }
                if (this.RefundId != null)
                {
                    hashCode = (hashCode * 59) + this.RefundId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Entity.GetHashCode();
                hashCode = (hashCode * 59) + this.RefundAmount.GetHashCode();
                if (this.RefundCurrency != null)
                {
                    hashCode = (hashCode * 59) + this.RefundCurrency.GetHashCode();
                }
                if (this.RefundNote != null)
                {
                    hashCode = (hashCode * 59) + this.RefundNote.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.RefundStatus.GetHashCode();
                if (this.RefundArn != null)
                {
                    hashCode = (hashCode * 59) + this.RefundArn.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.RefundCharge.GetHashCode();
                if (this.StatusDescription != null)
                {
                    hashCode = (hashCode * 59) + this.StatusDescription.GetHashCode();
                }
                if (this.Metadata != null)
                {
                    hashCode = (hashCode * 59) + this.Metadata.GetHashCode();
                }
                if (this.RefundSplits != null)
                {
                    hashCode = (hashCode * 59) + this.RefundSplits.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.RefundType.GetHashCode();
                hashCode = (hashCode * 59) + this.RefundMode.GetHashCode();
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.ProcessedAt != null)
                {
                    hashCode = (hashCode * 59) + this.ProcessedAt.GetHashCode();
                }
                if (this.RefundSpeed != null)
                {
                    hashCode = (hashCode * 59) + this.RefundSpeed.GetHashCode();
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


    public partial class CFRefundSpeed {

        /// <summary>
        /// Requested Speed of refund
        /// </summary>
        /// <value>STANDARD or INSTANT</value>
        [DataMember(Name = "requested", EmitDefaultValue = false)]
        public string? Requested { get; set; }

        /// <summary>
        /// Processed Speed of refund
        /// </summary>
        /// <value>STANDARD or INSTANT</value>
        [DataMember(Name = "processed", EmitDefaultValue = false)]
        public string? Processed { get; set; }

        /// <summary>
        /// Accepted Speed of refund
        /// </summary>
        /// <value>STANDARD or INSTANT</value>
        [DataMember(Name = "accepted", EmitDefaultValue = false)]
        public string? Accepted { get; set; }

        /// <summary>
        /// Error message if any
        /// </summary>
        /// <value>Any error message</value>
        [DataMember(Name = "message", EmitDefaultValue = false)]
        public string? Message { get; set; }


        /// <summary>
        /// Initializes a new instance of the <see cref="CFRefundSpeed" /> class.
        /// </summary>
        /// <param name="requested">Requested Speed of Refund</param>
        /// <param name="processed">Processed Speed of Refund</param>
        /// <param name="accepted">Accepted Speed of Refund</param>
        /// <param name="message">Error messages if any</param>
        public CFRefundSpeed(string? requested = default(string?), string? processed = default(string?), string? accepted = default(string?), string? message = default(string?))
        {
            this.Requested = requested;
            this.Processed = processed;
            this.Accepted = accepted;
            this.Message = message;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CFRefundSpeed {\n");
            sb.Append("  Requested: ").Append(Requested).Append("\n");
            sb.Append("  Processed: ").Append(Processed).Append("\n");
            sb.Append("  Accepted: ").Append(Accepted).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
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

    }

}
