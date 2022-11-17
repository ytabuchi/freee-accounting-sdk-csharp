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
    /// UserCapabilityWithSync
    /// </summary>
    [DataContract(Name = "userCapabilityWithSync")]
    public partial class UserCapabilityWithSync : IEquatable<UserCapabilityWithSync>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserCapabilityWithSync" /> class.
        /// </summary>
        /// <param name="create">「口座」の作成.</param>
        /// <param name="destroy">「口座」の削除.</param>
        /// <param name="read">「口座」の閲覧.</param>
        /// <param name="sync">「口座の同期」の実行（廃止予定）.</param>
        /// <param name="update">「口座」の更新.</param>
        public UserCapabilityWithSync(bool create = default(bool), bool destroy = default(bool), bool read = default(bool), bool sync = default(bool), bool update = default(bool))
        {
            this.Create = create;
            this.Destroy = destroy;
            this.Read = read;
            this.Sync = sync;
            this.Update = update;
        }

        /// <summary>
        /// 「口座」の作成
        /// </summary>
        /// <value>「口座」の作成</value>
        [DataMember(Name = "create", EmitDefaultValue = true)]
        public bool Create { get; set; }

        /// <summary>
        /// 「口座」の削除
        /// </summary>
        /// <value>「口座」の削除</value>
        [DataMember(Name = "destroy", EmitDefaultValue = true)]
        public bool Destroy { get; set; }

        /// <summary>
        /// 「口座」の閲覧
        /// </summary>
        /// <value>「口座」の閲覧</value>
        [DataMember(Name = "read", EmitDefaultValue = true)]
        public bool Read { get; set; }

        /// <summary>
        /// 「口座の同期」の実行（廃止予定）
        /// </summary>
        /// <value>「口座の同期」の実行（廃止予定）</value>
        [DataMember(Name = "sync", EmitDefaultValue = true)]
        [Obsolete]
        public bool Sync { get; set; }

        /// <summary>
        /// 「口座」の更新
        /// </summary>
        /// <value>「口座」の更新</value>
        [DataMember(Name = "update", EmitDefaultValue = true)]
        public bool Update { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserCapabilityWithSync {\n");
            sb.Append("  Create: ").Append(Create).Append("\n");
            sb.Append("  Destroy: ").Append(Destroy).Append("\n");
            sb.Append("  Read: ").Append(Read).Append("\n");
            sb.Append("  Sync: ").Append(Sync).Append("\n");
            sb.Append("  Update: ").Append(Update).Append("\n");
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
            return this.Equals(input as UserCapabilityWithSync);
        }

        /// <summary>
        /// Returns true if UserCapabilityWithSync instances are equal
        /// </summary>
        /// <param name="input">Instance of UserCapabilityWithSync to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserCapabilityWithSync input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Create == input.Create ||
                    this.Create.Equals(input.Create)
                ) && 
                (
                    this.Destroy == input.Destroy ||
                    this.Destroy.Equals(input.Destroy)
                ) && 
                (
                    this.Read == input.Read ||
                    this.Read.Equals(input.Read)
                ) && 
                (
                    this.Sync == input.Sync ||
                    this.Sync.Equals(input.Sync)
                ) && 
                (
                    this.Update == input.Update ||
                    this.Update.Equals(input.Update)
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
                hashCode = (hashCode * 59) + this.Create.GetHashCode();
                hashCode = (hashCode * 59) + this.Destroy.GetHashCode();
                hashCode = (hashCode * 59) + this.Read.GetHashCode();
                hashCode = (hashCode * 59) + this.Sync.GetHashCode();
                hashCode = (hashCode * 59) + this.Update.GetHashCode();
                return hashCode;
            }
        }

    }

}
