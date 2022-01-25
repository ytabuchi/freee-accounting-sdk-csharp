/*
 * freee API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: v1.0
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
using OpenAPIDateConverter = Freee.Accounting.Client.OpenAPIDateConverter;

namespace Freee.Accounting.Models
{
    /// <summary>
    /// DealUpdateParams
    /// </summary>
    [DataContract(Name = "dealUpdateParams")]
    public partial class DealUpdateParams : IEquatable<DealUpdateParams>
    {
        /// <summary>
        /// 収支区分 (収入: income, 支出: expense)
        /// </summary>
        /// <value>収支区分 (収入: income, 支出: expense)</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Income for value: income
            /// </summary>
            [EnumMember(Value = "income")]
            Income = 1,

            /// <summary>
            /// Enum Expense for value: expense
            /// </summary>
            [EnumMember(Value = "expense")]
            Expense = 2

        }


        /// <summary>
        /// 収支区分 (収入: income, 支出: expense)
        /// </summary>
        /// <value>収支区分 (収入: income, 支出: expense)</value>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DealUpdateParams" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DealUpdateParams() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DealUpdateParams" /> class.
        /// </summary>
        /// <param name="companyId">事業所ID (required).</param>
        /// <param name="details">details (required).</param>
        /// <param name="dueDate">支払期日(yyyy-mm-dd).</param>
        /// <param name="issueDate">発生日 (yyyy-mm-dd) (required).</param>
        /// <param name="partnerCode">取引先コード.</param>
        /// <param name="partnerId">取引先ID.</param>
        /// <param name="receiptIds">証憑ファイルID（ファイルボックスのファイルID）（配列）.</param>
        /// <param name="refNumber">管理番号.</param>
        /// <param name="type">収支区分 (収入: income, 支出: expense) (required).</param>
        public DealUpdateParams(int companyId = default(int), List<DealUpdateParamsDetails> details = default(List<DealUpdateParamsDetails>), string dueDate = default(string), string issueDate = default(string), string partnerCode = default(string), int partnerId = default(int), List<int> receiptIds = default(List<int>), string refNumber = default(string), TypeEnum type = default(TypeEnum))
        {
            this.CompanyId = companyId;
            // to ensure "details" is required (not null)
            if (details == null) {
                throw new ArgumentNullException("details is a required property for DealUpdateParams and cannot be null");
            }
            this.Details = details;
            // to ensure "issueDate" is required (not null)
            if (issueDate == null) {
                throw new ArgumentNullException("issueDate is a required property for DealUpdateParams and cannot be null");
            }
            this.IssueDate = issueDate;
            this.Type = type;
            this.DueDate = dueDate;
            this.PartnerCode = partnerCode;
            this.PartnerId = partnerId;
            this.ReceiptIds = receiptIds;
            this.RefNumber = refNumber;
        }

        /// <summary>
        /// 事業所ID
        /// </summary>
        /// <value>事業所ID</value>
        [DataMember(Name = "company_id", IsRequired = true, EmitDefaultValue = false)]
        public int CompanyId { get; set; }

        /// <summary>
        /// Gets or Sets Details
        /// </summary>
        [DataMember(Name = "details", IsRequired = true, EmitDefaultValue = false)]
        public List<DealUpdateParamsDetails> Details { get; set; }

        /// <summary>
        /// 支払期日(yyyy-mm-dd)
        /// </summary>
        /// <value>支払期日(yyyy-mm-dd)</value>
        [DataMember(Name = "due_date", EmitDefaultValue = false)]
        public string DueDate { get; set; }

        /// <summary>
        /// 発生日 (yyyy-mm-dd)
        /// </summary>
        /// <value>発生日 (yyyy-mm-dd)</value>
        [DataMember(Name = "issue_date", IsRequired = true, EmitDefaultValue = false)]
        public string IssueDate { get; set; }

        /// <summary>
        /// 取引先コード
        /// </summary>
        /// <value>取引先コード</value>
        [DataMember(Name = "partner_code", EmitDefaultValue = false)]
        public string PartnerCode { get; set; }

        /// <summary>
        /// 取引先ID
        /// </summary>
        /// <value>取引先ID</value>
        [DataMember(Name = "partner_id", EmitDefaultValue = false)]
        public int PartnerId { get; set; }

        /// <summary>
        /// 証憑ファイルID（ファイルボックスのファイルID）（配列）
        /// </summary>
        /// <value>証憑ファイルID（ファイルボックスのファイルID）（配列）</value>
        [DataMember(Name = "receipt_ids", EmitDefaultValue = true)]
        public List<int> ReceiptIds { get; set; }

        /// <summary>
        /// 管理番号
        /// </summary>
        /// <value>管理番号</value>
        [DataMember(Name = "ref_number", EmitDefaultValue = false)]
        public string RefNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DealUpdateParams {\n");
            sb.Append("  CompanyId: ").Append(CompanyId).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
            sb.Append("  DueDate: ").Append(DueDate).Append("\n");
            sb.Append("  IssueDate: ").Append(IssueDate).Append("\n");
            sb.Append("  PartnerCode: ").Append(PartnerCode).Append("\n");
            sb.Append("  PartnerId: ").Append(PartnerId).Append("\n");
            sb.Append("  ReceiptIds: ").Append(ReceiptIds).Append("\n");
            sb.Append("  RefNumber: ").Append(RefNumber).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
        public override bool Equals(object input)
        {
            return this.Equals(input as DealUpdateParams);
        }

        /// <summary>
        /// Returns true if DealUpdateParams instances are equal
        /// </summary>
        /// <param name="input">Instance of DealUpdateParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DealUpdateParams input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CompanyId == input.CompanyId ||
                    this.CompanyId.Equals(input.CompanyId)
                ) && 
                (
                    this.Details == input.Details ||
                    this.Details != null &&
                    input.Details != null &&
                    this.Details.SequenceEqual(input.Details)
                ) && 
                (
                    this.DueDate == input.DueDate ||
                    (this.DueDate != null &&
                    this.DueDate.Equals(input.DueDate))
                ) && 
                (
                    this.IssueDate == input.IssueDate ||
                    (this.IssueDate != null &&
                    this.IssueDate.Equals(input.IssueDate))
                ) && 
                (
                    this.PartnerCode == input.PartnerCode ||
                    (this.PartnerCode != null &&
                    this.PartnerCode.Equals(input.PartnerCode))
                ) && 
                (
                    this.PartnerId == input.PartnerId ||
                    this.PartnerId.Equals(input.PartnerId)
                ) && 
                (
                    this.ReceiptIds == input.ReceiptIds ||
                    this.ReceiptIds != null &&
                    input.ReceiptIds != null &&
                    this.ReceiptIds.SequenceEqual(input.ReceiptIds)
                ) && 
                (
                    this.RefNumber == input.RefNumber ||
                    (this.RefNumber != null &&
                    this.RefNumber.Equals(input.RefNumber))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
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
                hashCode = (hashCode * 59) + this.CompanyId.GetHashCode();
                if (this.Details != null)
                {
                    hashCode = (hashCode * 59) + this.Details.GetHashCode();
                }
                if (this.DueDate != null)
                {
                    hashCode = (hashCode * 59) + this.DueDate.GetHashCode();
                }
                if (this.IssueDate != null)
                {
                    hashCode = (hashCode * 59) + this.IssueDate.GetHashCode();
                }
                if (this.PartnerCode != null)
                {
                    hashCode = (hashCode * 59) + this.PartnerCode.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PartnerId.GetHashCode();
                if (this.ReceiptIds != null)
                {
                    hashCode = (hashCode * 59) + this.ReceiptIds.GetHashCode();
                }
                if (this.RefNumber != null)
                {
                    hashCode = (hashCode * 59) + this.RefNumber.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                return hashCode;
            }
        }

    }

}
