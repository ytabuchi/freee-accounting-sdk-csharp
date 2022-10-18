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
    /// InlineResponse20010Taxes
    /// </summary>
    [DataContract(Name = "inline_response_200_10_taxes")]
    public partial class InlineResponse20010Taxes : IEquatable<InlineResponse20010Taxes>
    {
        /// <summary>
        /// 税区分の表示カテゴリ（tax_5: 5%表示の税区分、tax_8: 8%表示の税区分、tax_r8: 軽減税率8%表示の税区分、tax_10: 10%表示の税区分、null: 税率未設定税区分）
        /// </summary>
        /// <value>税区分の表示カテゴリ（tax_5: 5%表示の税区分、tax_8: 8%表示の税区分、tax_r8: 軽減税率8%表示の税区分、tax_10: 10%表示の税区分、null: 税率未設定税区分）</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DisplayCategoryEnum
        {
            /// <summary>
            /// Enum _5 for value: tax_5
            /// </summary>
            [EnumMember(Value = "tax_5")]
            _5 = 1,

            /// <summary>
            /// Enum _8 for value: tax_8
            /// </summary>
            [EnumMember(Value = "tax_8")]
            _8 = 2,

            /// <summary>
            /// Enum R8 for value: tax_r8
            /// </summary>
            [EnumMember(Value = "tax_r8")]
            R8 = 3,

            /// <summary>
            /// Enum _10 for value: tax_10
            /// </summary>
            [EnumMember(Value = "tax_10")]
            _10 = 4

        }


        /// <summary>
        /// 税区分の表示カテゴリ（tax_5: 5%表示の税区分、tax_8: 8%表示の税区分、tax_r8: 軽減税率8%表示の税区分、tax_10: 10%表示の税区分、null: 税率未設定税区分）
        /// </summary>
        /// <value>税区分の表示カテゴリ（tax_5: 5%表示の税区分、tax_8: 8%表示の税区分、tax_r8: 軽減税率8%表示の税区分、tax_10: 10%表示の税区分、null: 税率未設定税区分）</value>
        [DataMember(Name = "display_category", IsRequired = true, EmitDefaultValue = true)]
        public DisplayCategoryEnum DisplayCategory { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse20010Taxes" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InlineResponse20010Taxes() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse20010Taxes" /> class.
        /// </summary>
        /// <param name="available">税区分の使用設定。true: 使用する、false: 使用しない (required).</param>
        /// <param name="code">税区分コード (required).</param>
        /// <param name="displayCategory">税区分の表示カテゴリ（tax_5: 5%表示の税区分、tax_8: 8%表示の税区分、tax_r8: 軽減税率8%表示の税区分、tax_10: 10%表示の税区分、null: 税率未設定税区分） (required).</param>
        /// <param name="name">税区分名 (required).</param>
        /// <param name="nameJa">税区分名（日本語表示用） (required).</param>
        public InlineResponse20010Taxes(bool available = default(bool), int code = default(int), DisplayCategoryEnum displayCategory = default(DisplayCategoryEnum), string name = default(string), string nameJa = default(string))
        {
            this.Available = available;
            this.Code = code;
            this.DisplayCategory = displayCategory;
            // to ensure "name" is required (not null)
            if (name == null) {
                throw new ArgumentNullException("name is a required property for InlineResponse20010Taxes and cannot be null");
            }
            this.Name = name;
            // to ensure "nameJa" is required (not null)
            if (nameJa == null) {
                throw new ArgumentNullException("nameJa is a required property for InlineResponse20010Taxes and cannot be null");
            }
            this.NameJa = nameJa;
        }

        /// <summary>
        /// 税区分の使用設定。true: 使用する、false: 使用しない
        /// </summary>
        /// <value>税区分の使用設定。true: 使用する、false: 使用しない</value>
        [DataMember(Name = "available", IsRequired = true, EmitDefaultValue = true)]
        public bool Available { get; set; }

        /// <summary>
        /// 税区分コード
        /// </summary>
        /// <value>税区分コード</value>
        [DataMember(Name = "code", IsRequired = true, EmitDefaultValue = false)]
        public int Code { get; set; }

        /// <summary>
        /// 税区分名
        /// </summary>
        /// <value>税区分名</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// 税区分名（日本語表示用）
        /// </summary>
        /// <value>税区分名（日本語表示用）</value>
        [DataMember(Name = "name_ja", IsRequired = true, EmitDefaultValue = false)]
        public string NameJa { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InlineResponse20010Taxes {\n");
            sb.Append("  Available: ").Append(Available).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  DisplayCategory: ").Append(DisplayCategory).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  NameJa: ").Append(NameJa).Append("\n");
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
            return this.Equals(input as InlineResponse20010Taxes);
        }

        /// <summary>
        /// Returns true if InlineResponse20010Taxes instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineResponse20010Taxes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse20010Taxes input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Available == input.Available ||
                    this.Available.Equals(input.Available)
                ) && 
                (
                    this.Code == input.Code ||
                    this.Code.Equals(input.Code)
                ) && 
                (
                    this.DisplayCategory == input.DisplayCategory ||
                    this.DisplayCategory.Equals(input.DisplayCategory)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.NameJa == input.NameJa ||
                    (this.NameJa != null &&
                    this.NameJa.Equals(input.NameJa))
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
                hashCode = (hashCode * 59) + this.Available.GetHashCode();
                hashCode = (hashCode * 59) + this.Code.GetHashCode();
                hashCode = (hashCode * 59) + this.DisplayCategory.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.NameJa != null)
                {
                    hashCode = (hashCode * 59) + this.NameJa.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
