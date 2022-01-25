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
    /// PartnerCreateParamsPartnerDocSettingAttributes
    /// </summary>
    [DataContract(Name = "partnerCreateParams_partner_doc_setting_attributes")]
    public partial class PartnerCreateParamsPartnerDocSettingAttributes : IEquatable<PartnerCreateParamsPartnerDocSettingAttributes>
    {
        /// <summary>
        /// 請求書送付方法(email:メール、posting:郵送、email_and_posting:メールと郵送)
        /// </summary>
        /// <value>請求書送付方法(email:メール、posting:郵送、email_and_posting:メールと郵送)</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SendingMethodEnum
        {
            /// <summary>
            /// Enum Email for value: email
            /// </summary>
            [EnumMember(Value = "email")]
            Email = 1,

            /// <summary>
            /// Enum Posting for value: posting
            /// </summary>
            [EnumMember(Value = "posting")]
            Posting = 2,

            /// <summary>
            /// Enum EmailAndPosting for value: email_and_posting
            /// </summary>
            [EnumMember(Value = "email_and_posting")]
            EmailAndPosting = 3

        }


        /// <summary>
        /// 請求書送付方法(email:メール、posting:郵送、email_and_posting:メールと郵送)
        /// </summary>
        /// <value>請求書送付方法(email:メール、posting:郵送、email_and_posting:メールと郵送)</value>
        [DataMember(Name = "sending_method", EmitDefaultValue = false)]
        public SendingMethodEnum? SendingMethod { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PartnerCreateParamsPartnerDocSettingAttributes" /> class.
        /// </summary>
        /// <param name="sendingMethod">請求書送付方法(email:メール、posting:郵送、email_and_posting:メールと郵送).</param>
        public PartnerCreateParamsPartnerDocSettingAttributes(SendingMethodEnum? sendingMethod = default(SendingMethodEnum?))
        {
            this.SendingMethod = sendingMethod;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PartnerCreateParamsPartnerDocSettingAttributes {\n");
            sb.Append("  SendingMethod: ").Append(SendingMethod).Append("\n");
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
            return this.Equals(input as PartnerCreateParamsPartnerDocSettingAttributes);
        }

        /// <summary>
        /// Returns true if PartnerCreateParamsPartnerDocSettingAttributes instances are equal
        /// </summary>
        /// <param name="input">Instance of PartnerCreateParamsPartnerDocSettingAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PartnerCreateParamsPartnerDocSettingAttributes input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SendingMethod == input.SendingMethod ||
                    this.SendingMethod.Equals(input.SendingMethod)
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
                hashCode = (hashCode * 59) + this.SendingMethod.GetHashCode();
                return hashCode;
            }
        }

    }

}
