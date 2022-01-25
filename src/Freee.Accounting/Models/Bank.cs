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
    /// Bank
    /// </summary>
    [DataContract(Name = "bank")]
    public partial class Bank : IEquatable<Bank>
    {
        /// <summary>
        /// 連携サービス種別: (銀行口座: bank_account, クレジットカード: credit_card, 現金: wallet)
        /// </summary>
        /// <value>連携サービス種別: (銀行口座: bank_account, クレジットカード: credit_card, 現金: wallet)</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum BankAccount for value: bank_account
            /// </summary>
            [EnumMember(Value = "bank_account")]
            BankAccount = 1,

            /// <summary>
            /// Enum CreditCard for value: credit_card
            /// </summary>
            [EnumMember(Value = "credit_card")]
            CreditCard = 2,

            /// <summary>
            /// Enum Wallet for value: wallet
            /// </summary>
            [EnumMember(Value = "wallet")]
            Wallet = 3

        }


        /// <summary>
        /// 連携サービス種別: (銀行口座: bank_account, クレジットカード: credit_card, 現金: wallet)
        /// </summary>
        /// <value>連携サービス種別: (銀行口座: bank_account, クレジットカード: credit_card, 現金: wallet)</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Bank" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Bank() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Bank" /> class.
        /// </summary>
        /// <param name="id">連携サービスID (required).</param>
        /// <param name="name">連携サービス名.</param>
        /// <param name="nameKana">連携サービス名(カナ).</param>
        /// <param name="type">連携サービス種別: (銀行口座: bank_account, クレジットカード: credit_card, 現金: wallet).</param>
        public Bank(int id = default(int), string name = default(string), string nameKana = default(string), TypeEnum? type = default(TypeEnum?))
        {
            this.Id = id;
            this.Name = name;
            this.NameKana = nameKana;
            this.Type = type;
        }

        /// <summary>
        /// 連携サービスID
        /// </summary>
        /// <value>連携サービスID</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// 連携サービス名
        /// </summary>
        /// <value>連携サービス名</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// 連携サービス名(カナ)
        /// </summary>
        /// <value>連携サービス名(カナ)</value>
        [DataMember(Name = "name_kana", EmitDefaultValue = true)]
        public string NameKana { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Bank {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  NameKana: ").Append(NameKana).Append("\n");
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
            return this.Equals(input as Bank);
        }

        /// <summary>
        /// Returns true if Bank instances are equal
        /// </summary>
        /// <param name="input">Instance of Bank to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Bank input)
        {
            if (input == null)
            {
                return false;
            }
            return 
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
                    this.NameKana == input.NameKana ||
                    (this.NameKana != null &&
                    this.NameKana.Equals(input.NameKana))
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
                hashCode = (hashCode * 59) + this.Id.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.NameKana != null)
                {
                    hashCode = (hashCode * 59) + this.NameKana.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                return hashCode;
            }
        }

    }

}
