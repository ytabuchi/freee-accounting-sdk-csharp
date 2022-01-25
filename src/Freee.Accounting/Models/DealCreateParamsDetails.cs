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
    /// DealCreateParamsDetails
    /// </summary>
    [DataContract(Name = "dealCreateParams_details")]
    public partial class DealCreateParamsDetails : IEquatable<DealCreateParamsDetails>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DealCreateParamsDetails" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DealCreateParamsDetails() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DealCreateParamsDetails" /> class.
        /// </summary>
        /// <param name="accountItemId">勘定科目ID (required).</param>
        /// <param name="amount">取引金額（税込で指定してください） (required).</param>
        /// <param name="description">備考.</param>
        /// <param name="itemId">品目ID.</param>
        /// <param name="sectionId">部門ID.</param>
        /// <param name="segment1TagId">セグメント１ID.</param>
        /// <param name="segment2TagId">セグメント２ID.</param>
        /// <param name="segment3TagId">セグメント３ID.</param>
        /// <param name="tagIds">メモタグID.</param>
        /// <param name="taxCode">税区分コード (required).</param>
        /// <param name="vat">消費税額（指定しない場合は自動で計算されます）.</param>
        public DealCreateParamsDetails(int accountItemId = default(int), long amount = default(long), string description = default(string), int itemId = default(int), int sectionId = default(int), long segment1TagId = default(long), long segment2TagId = default(long), long segment3TagId = default(long), List<int> tagIds = default(List<int>), int taxCode = default(int), int vat = default(int))
        {
            this.AccountItemId = accountItemId;
            this.Amount = amount;
            this.TaxCode = taxCode;
            this.Description = description;
            this.ItemId = itemId;
            this.SectionId = sectionId;
            this.Segment1TagId = segment1TagId;
            this.Segment2TagId = segment2TagId;
            this.Segment3TagId = segment3TagId;
            this.TagIds = tagIds;
            this.Vat = vat;
        }

        /// <summary>
        /// 勘定科目ID
        /// </summary>
        /// <value>勘定科目ID</value>
        [DataMember(Name = "account_item_id", IsRequired = true, EmitDefaultValue = false)]
        public int AccountItemId { get; set; }

        /// <summary>
        /// 取引金額（税込で指定してください）
        /// </summary>
        /// <value>取引金額（税込で指定してください）</value>
        [DataMember(Name = "amount", IsRequired = true, EmitDefaultValue = false)]
        public long Amount { get; set; }

        /// <summary>
        /// 備考
        /// </summary>
        /// <value>備考</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// 品目ID
        /// </summary>
        /// <value>品目ID</value>
        [DataMember(Name = "item_id", EmitDefaultValue = false)]
        public int ItemId { get; set; }

        /// <summary>
        /// 部門ID
        /// </summary>
        /// <value>部門ID</value>
        [DataMember(Name = "section_id", EmitDefaultValue = false)]
        public int SectionId { get; set; }

        /// <summary>
        /// セグメント１ID
        /// </summary>
        /// <value>セグメント１ID</value>
        [DataMember(Name = "segment_1_tag_id", EmitDefaultValue = false)]
        public long Segment1TagId { get; set; }

        /// <summary>
        /// セグメント２ID
        /// </summary>
        /// <value>セグメント２ID</value>
        [DataMember(Name = "segment_2_tag_id", EmitDefaultValue = false)]
        public long Segment2TagId { get; set; }

        /// <summary>
        /// セグメント３ID
        /// </summary>
        /// <value>セグメント３ID</value>
        [DataMember(Name = "segment_3_tag_id", EmitDefaultValue = false)]
        public long Segment3TagId { get; set; }

        /// <summary>
        /// メモタグID
        /// </summary>
        /// <value>メモタグID</value>
        [DataMember(Name = "tag_ids", EmitDefaultValue = false)]
        public List<int> TagIds { get; set; }

        /// <summary>
        /// 税区分コード
        /// </summary>
        /// <value>税区分コード</value>
        [DataMember(Name = "tax_code", IsRequired = true, EmitDefaultValue = false)]
        public int TaxCode { get; set; }

        /// <summary>
        /// 消費税額（指定しない場合は自動で計算されます）
        /// </summary>
        /// <value>消費税額（指定しない場合は自動で計算されます）</value>
        [DataMember(Name = "vat", EmitDefaultValue = false)]
        public int Vat { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DealCreateParamsDetails {\n");
            sb.Append("  AccountItemId: ").Append(AccountItemId).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ItemId: ").Append(ItemId).Append("\n");
            sb.Append("  SectionId: ").Append(SectionId).Append("\n");
            sb.Append("  Segment1TagId: ").Append(Segment1TagId).Append("\n");
            sb.Append("  Segment2TagId: ").Append(Segment2TagId).Append("\n");
            sb.Append("  Segment3TagId: ").Append(Segment3TagId).Append("\n");
            sb.Append("  TagIds: ").Append(TagIds).Append("\n");
            sb.Append("  TaxCode: ").Append(TaxCode).Append("\n");
            sb.Append("  Vat: ").Append(Vat).Append("\n");
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
            return this.Equals(input as DealCreateParamsDetails);
        }

        /// <summary>
        /// Returns true if DealCreateParamsDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of DealCreateParamsDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DealCreateParamsDetails input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AccountItemId == input.AccountItemId ||
                    this.AccountItemId.Equals(input.AccountItemId)
                ) && 
                (
                    this.Amount == input.Amount ||
                    this.Amount.Equals(input.Amount)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.ItemId == input.ItemId ||
                    this.ItemId.Equals(input.ItemId)
                ) && 
                (
                    this.SectionId == input.SectionId ||
                    this.SectionId.Equals(input.SectionId)
                ) && 
                (
                    this.Segment1TagId == input.Segment1TagId ||
                    this.Segment1TagId.Equals(input.Segment1TagId)
                ) && 
                (
                    this.Segment2TagId == input.Segment2TagId ||
                    this.Segment2TagId.Equals(input.Segment2TagId)
                ) && 
                (
                    this.Segment3TagId == input.Segment3TagId ||
                    this.Segment3TagId.Equals(input.Segment3TagId)
                ) && 
                (
                    this.TagIds == input.TagIds ||
                    this.TagIds != null &&
                    input.TagIds != null &&
                    this.TagIds.SequenceEqual(input.TagIds)
                ) && 
                (
                    this.TaxCode == input.TaxCode ||
                    this.TaxCode.Equals(input.TaxCode)
                ) && 
                (
                    this.Vat == input.Vat ||
                    this.Vat.Equals(input.Vat)
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
                hashCode = (hashCode * 59) + this.AccountItemId.GetHashCode();
                hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ItemId.GetHashCode();
                hashCode = (hashCode * 59) + this.SectionId.GetHashCode();
                hashCode = (hashCode * 59) + this.Segment1TagId.GetHashCode();
                hashCode = (hashCode * 59) + this.Segment2TagId.GetHashCode();
                hashCode = (hashCode * 59) + this.Segment3TagId.GetHashCode();
                if (this.TagIds != null)
                {
                    hashCode = (hashCode * 59) + this.TagIds.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TaxCode.GetHashCode();
                hashCode = (hashCode * 59) + this.Vat.GetHashCode();
                return hashCode;
            }
        }

    }

}
