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
    /// WalletableUpdateParams
    /// </summary>
    [DataContract(Name = "walletableUpdateParams")]
    public partial class WalletableUpdateParams : IEquatable<WalletableUpdateParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WalletableUpdateParams" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WalletableUpdateParams() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WalletableUpdateParams" /> class.
        /// </summary>
        /// <param name="companyId">事業所ID (required).</param>
        /// <param name="name">口座名 (255文字以内) (required).</param>
        public WalletableUpdateParams(int companyId = default(int), string name = default(string))
        {
            this.CompanyId = companyId;
            // to ensure "name" is required (not null)
            if (name == null) {
                throw new ArgumentNullException("name is a required property for WalletableUpdateParams and cannot be null");
            }
            this.Name = name;
        }

        /// <summary>
        /// 事業所ID
        /// </summary>
        /// <value>事業所ID</value>
        [DataMember(Name = "company_id", IsRequired = true, EmitDefaultValue = false)]
        public int CompanyId { get; set; }

        /// <summary>
        /// 口座名 (255文字以内)
        /// </summary>
        /// <value>口座名 (255文字以内)</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WalletableUpdateParams {\n");
            sb.Append("  CompanyId: ").Append(CompanyId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as WalletableUpdateParams);
        }

        /// <summary>
        /// Returns true if WalletableUpdateParams instances are equal
        /// </summary>
        /// <param name="input">Instance of WalletableUpdateParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WalletableUpdateParams input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
