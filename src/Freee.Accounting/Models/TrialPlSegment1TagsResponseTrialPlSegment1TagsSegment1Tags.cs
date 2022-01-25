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
    /// TrialPlSegment1TagsResponseTrialPlSegment1TagsSegment1Tags
    /// </summary>
    [DataContract(Name = "trialPlSegment_1TagsResponse_trial_pl_segment_1_tags_segment_1_tags")]
    public partial class TrialPlSegment1TagsResponseTrialPlSegment1TagsSegment1Tags : IEquatable<TrialPlSegment1TagsResponseTrialPlSegment1TagsSegment1Tags>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrialPlSegment1TagsResponseTrialPlSegment1TagsSegment1Tags" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TrialPlSegment1TagsResponseTrialPlSegment1TagsSegment1Tags() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TrialPlSegment1TagsResponseTrialPlSegment1TagsSegment1Tags" /> class.
        /// </summary>
        /// <param name="closingBalance">期末残高.</param>
        /// <param name="id">セグメント1タグID (required).</param>
        /// <param name="items">breakdown_display_type:item, account_item_display_type:account_item指定時のみ含まれる.</param>
        /// <param name="name">セグメント1タグ名.</param>
        /// <param name="partners">breakdown_display_type:partner, account_item_display_type:account_item指定時のみ含まれる.</param>
        /// <param name="sections">breakdown_display_type:section, account_item_display_type:account_item指定時のみ含まれる.</param>
        public TrialPlSegment1TagsResponseTrialPlSegment1TagsSegment1Tags(int closingBalance = default(int), int id = default(int), List<TrialPlSectionsResponseTrialPlSectionsItems> items = default(List<TrialPlSectionsResponseTrialPlSectionsItems>), string name = default(string), List<TrialPlSectionsResponseTrialPlSectionsPartners> partners = default(List<TrialPlSectionsResponseTrialPlSectionsPartners>), List<TrialPlSegment1TagsResponseTrialPlSegment1TagsSections> sections = default(List<TrialPlSegment1TagsResponseTrialPlSegment1TagsSections>))
        {
            this.Id = id;
            this.ClosingBalance = closingBalance;
            this.Items = items;
            this.Name = name;
            this.Partners = partners;
            this.Sections = sections;
        }

        /// <summary>
        /// 期末残高
        /// </summary>
        /// <value>期末残高</value>
        [DataMember(Name = "closing_balance", EmitDefaultValue = false)]
        public int ClosingBalance { get; set; }

        /// <summary>
        /// セグメント1タグID
        /// </summary>
        /// <value>セグメント1タグID</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// breakdown_display_type:item, account_item_display_type:account_item指定時のみ含まれる
        /// </summary>
        /// <value>breakdown_display_type:item, account_item_display_type:account_item指定時のみ含まれる</value>
        [DataMember(Name = "items", EmitDefaultValue = false)]
        public List<TrialPlSectionsResponseTrialPlSectionsItems> Items { get; set; }

        /// <summary>
        /// セグメント1タグ名
        /// </summary>
        /// <value>セグメント1タグ名</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// breakdown_display_type:partner, account_item_display_type:account_item指定時のみ含まれる
        /// </summary>
        /// <value>breakdown_display_type:partner, account_item_display_type:account_item指定時のみ含まれる</value>
        [DataMember(Name = "partners", EmitDefaultValue = false)]
        public List<TrialPlSectionsResponseTrialPlSectionsPartners> Partners { get; set; }

        /// <summary>
        /// breakdown_display_type:section, account_item_display_type:account_item指定時のみ含まれる
        /// </summary>
        /// <value>breakdown_display_type:section, account_item_display_type:account_item指定時のみ含まれる</value>
        [DataMember(Name = "sections", EmitDefaultValue = false)]
        public List<TrialPlSegment1TagsResponseTrialPlSegment1TagsSections> Sections { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TrialPlSegment1TagsResponseTrialPlSegment1TagsSegment1Tags {\n");
            sb.Append("  ClosingBalance: ").Append(ClosingBalance).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Partners: ").Append(Partners).Append("\n");
            sb.Append("  Sections: ").Append(Sections).Append("\n");
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
            return this.Equals(input as TrialPlSegment1TagsResponseTrialPlSegment1TagsSegment1Tags);
        }

        /// <summary>
        /// Returns true if TrialPlSegment1TagsResponseTrialPlSegment1TagsSegment1Tags instances are equal
        /// </summary>
        /// <param name="input">Instance of TrialPlSegment1TagsResponseTrialPlSegment1TagsSegment1Tags to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrialPlSegment1TagsResponseTrialPlSegment1TagsSegment1Tags input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ClosingBalance == input.ClosingBalance ||
                    this.ClosingBalance.Equals(input.ClosingBalance)
                ) && 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.Items == input.Items ||
                    this.Items != null &&
                    input.Items != null &&
                    this.Items.SequenceEqual(input.Items)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Partners == input.Partners ||
                    this.Partners != null &&
                    input.Partners != null &&
                    this.Partners.SequenceEqual(input.Partners)
                ) && 
                (
                    this.Sections == input.Sections ||
                    this.Sections != null &&
                    input.Sections != null &&
                    this.Sections.SequenceEqual(input.Sections)
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
                hashCode = (hashCode * 59) + this.ClosingBalance.GetHashCode();
                hashCode = (hashCode * 59) + this.Id.GetHashCode();
                if (this.Items != null)
                {
                    hashCode = (hashCode * 59) + this.Items.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Partners != null)
                {
                    hashCode = (hashCode * 59) + this.Partners.GetHashCode();
                }
                if (this.Sections != null)
                {
                    hashCode = (hashCode * 59) + this.Sections.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
