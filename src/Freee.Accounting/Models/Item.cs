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
    /// Item
    /// </summary>
    [DataContract(Name = "item")]
    public partial class Item : IEquatable<Item>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Item" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Item() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Item" /> class.
        /// </summary>
        /// <param name="available">品目の使用設定（true: 使用する、false: 使用しない） &lt;br&gt; &lt;ul&gt;   &lt;li&gt;     本APIでitemを作成した場合はtrueになります。   &lt;/li&gt;   &lt;li&gt;     falseにする場合はWeb画面から変更できます。   &lt;/li&gt;   &lt;li&gt;     trueの場合、Web画面での取引登録時などに入力候補として表示されます。   &lt;/li&gt;   &lt;li&gt;     falseの場合、品目自体は削除せず、Web画面での取引登録時などに入力候補として表示されません。ただし取引（収入・支出）の作成APIなどでfalseの品目をパラメータに指定すれば、取引などにfalseの品目を設定できます。   &lt;/li&gt; &lt;/ul&gt; (required).</param>
        /// <param name="companyId">事業所ID (required).</param>
        /// <param name="id">品目ID (required).</param>
        /// <param name="name">品目名 (30文字以内) (required).</param>
        /// <param name="shortcut1">ショートカット１ (20文字以内).</param>
        /// <param name="shortcut2">ショートカット２ (20文字以内).</param>
        /// <param name="updateDate">更新日(yyyy-mm-dd) (required).</param>
        public Item(bool available = default(bool), int companyId = default(int), int id = default(int), string name = default(string), string shortcut1 = default(string), string shortcut2 = default(string), string updateDate = default(string))
        {
            this.Available = available;
            this.CompanyId = companyId;
            this.Id = id;
            // to ensure "name" is required (not null)
            if (name == null) {
                throw new ArgumentNullException("name is a required property for Item and cannot be null");
            }
            this.Name = name;
            // to ensure "updateDate" is required (not null)
            if (updateDate == null) {
                throw new ArgumentNullException("updateDate is a required property for Item and cannot be null");
            }
            this.UpdateDate = updateDate;
            this.Shortcut1 = shortcut1;
            this.Shortcut2 = shortcut2;
        }

        /// <summary>
        /// 品目の使用設定（true: 使用する、false: 使用しない） &lt;br&gt; &lt;ul&gt;   &lt;li&gt;     本APIでitemを作成した場合はtrueになります。   &lt;/li&gt;   &lt;li&gt;     falseにする場合はWeb画面から変更できます。   &lt;/li&gt;   &lt;li&gt;     trueの場合、Web画面での取引登録時などに入力候補として表示されます。   &lt;/li&gt;   &lt;li&gt;     falseの場合、品目自体は削除せず、Web画面での取引登録時などに入力候補として表示されません。ただし取引（収入・支出）の作成APIなどでfalseの品目をパラメータに指定すれば、取引などにfalseの品目を設定できます。   &lt;/li&gt; &lt;/ul&gt;
        /// </summary>
        /// <value>品目の使用設定（true: 使用する、false: 使用しない） &lt;br&gt; &lt;ul&gt;   &lt;li&gt;     本APIでitemを作成した場合はtrueになります。   &lt;/li&gt;   &lt;li&gt;     falseにする場合はWeb画面から変更できます。   &lt;/li&gt;   &lt;li&gt;     trueの場合、Web画面での取引登録時などに入力候補として表示されます。   &lt;/li&gt;   &lt;li&gt;     falseの場合、品目自体は削除せず、Web画面での取引登録時などに入力候補として表示されません。ただし取引（収入・支出）の作成APIなどでfalseの品目をパラメータに指定すれば、取引などにfalseの品目を設定できます。   &lt;/li&gt; &lt;/ul&gt;</value>
        [DataMember(Name = "available", IsRequired = true, EmitDefaultValue = true)]
        public bool Available { get; set; }

        /// <summary>
        /// 事業所ID
        /// </summary>
        /// <value>事業所ID</value>
        [DataMember(Name = "company_id", IsRequired = true, EmitDefaultValue = false)]
        public int CompanyId { get; set; }

        /// <summary>
        /// 品目ID
        /// </summary>
        /// <value>品目ID</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// 品目名 (30文字以内)
        /// </summary>
        /// <value>品目名 (30文字以内)</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// ショートカット１ (20文字以内)
        /// </summary>
        /// <value>ショートカット１ (20文字以内)</value>
        [DataMember(Name = "shortcut1", EmitDefaultValue = true)]
        public string Shortcut1 { get; set; }

        /// <summary>
        /// ショートカット２ (20文字以内)
        /// </summary>
        /// <value>ショートカット２ (20文字以内)</value>
        [DataMember(Name = "shortcut2", EmitDefaultValue = true)]
        public string Shortcut2 { get; set; }

        /// <summary>
        /// 更新日(yyyy-mm-dd)
        /// </summary>
        /// <value>更新日(yyyy-mm-dd)</value>
        [DataMember(Name = "update_date", IsRequired = true, EmitDefaultValue = false)]
        public string UpdateDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Item {\n");
            sb.Append("  Available: ").Append(Available).Append("\n");
            sb.Append("  CompanyId: ").Append(CompanyId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Shortcut1: ").Append(Shortcut1).Append("\n");
            sb.Append("  Shortcut2: ").Append(Shortcut2).Append("\n");
            sb.Append("  UpdateDate: ").Append(UpdateDate).Append("\n");
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
            return this.Equals(input as Item);
        }

        /// <summary>
        /// Returns true if Item instances are equal
        /// </summary>
        /// <param name="input">Instance of Item to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Item input)
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
                    this.CompanyId == input.CompanyId ||
                    this.CompanyId.Equals(input.CompanyId)
                ) && 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Shortcut1 == input.Shortcut1 ||
                    (this.Shortcut1 != null &&
                    this.Shortcut1.Equals(input.Shortcut1))
                ) && 
                (
                    this.Shortcut2 == input.Shortcut2 ||
                    (this.Shortcut2 != null &&
                    this.Shortcut2.Equals(input.Shortcut2))
                ) && 
                (
                    this.UpdateDate == input.UpdateDate ||
                    (this.UpdateDate != null &&
                    this.UpdateDate.Equals(input.UpdateDate))
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
                hashCode = (hashCode * 59) + this.CompanyId.GetHashCode();
                hashCode = (hashCode * 59) + this.Id.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Shortcut1 != null)
                {
                    hashCode = (hashCode * 59) + this.Shortcut1.GetHashCode();
                }
                if (this.Shortcut2 != null)
                {
                    hashCode = (hashCode * 59) + this.Shortcut2.GetHashCode();
                }
                if (this.UpdateDate != null)
                {
                    hashCode = (hashCode * 59) + this.UpdateDate.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
