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
    /// PartnerResponsePartnerPaymentTermAttributes
    /// </summary>
    [DataContract(Name = "partnerResponse_partner_payment_term_attributes")]
    public partial class PartnerResponsePartnerPaymentTermAttributes : IEquatable<PartnerResponsePartnerPaymentTermAttributes>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PartnerResponsePartnerPaymentTermAttributes" /> class.
        /// </summary>
        /// <param name="additionalMonths">支払月.</param>
        /// <param name="cutoffDay">締め日（29, 30, 31日の末日を指定する場合は、32。）.</param>
        /// <param name="fixedDay">支払日（29, 30, 31日の末日を指定する場合は、32。）.</param>
        public PartnerResponsePartnerPaymentTermAttributes(int? additionalMonths = default(int?), int? cutoffDay = default(int?), int? fixedDay = default(int?))
        {
            this.AdditionalMonths = additionalMonths;
            this.CutoffDay = cutoffDay;
            this.FixedDay = fixedDay;
        }

        /// <summary>
        /// 支払月
        /// </summary>
        /// <value>支払月</value>
        [DataMember(Name = "additional_months", EmitDefaultValue = true)]
        public int? AdditionalMonths { get; set; }

        /// <summary>
        /// 締め日（29, 30, 31日の末日を指定する場合は、32。）
        /// </summary>
        /// <value>締め日（29, 30, 31日の末日を指定する場合は、32。）</value>
        [DataMember(Name = "cutoff_day", EmitDefaultValue = true)]
        public int? CutoffDay { get; set; }

        /// <summary>
        /// 支払日（29, 30, 31日の末日を指定する場合は、32。）
        /// </summary>
        /// <value>支払日（29, 30, 31日の末日を指定する場合は、32。）</value>
        [DataMember(Name = "fixed_day", EmitDefaultValue = true)]
        public int? FixedDay { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PartnerResponsePartnerPaymentTermAttributes {\n");
            sb.Append("  AdditionalMonths: ").Append(AdditionalMonths).Append("\n");
            sb.Append("  CutoffDay: ").Append(CutoffDay).Append("\n");
            sb.Append("  FixedDay: ").Append(FixedDay).Append("\n");
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
            return this.Equals(input as PartnerResponsePartnerPaymentTermAttributes);
        }

        /// <summary>
        /// Returns true if PartnerResponsePartnerPaymentTermAttributes instances are equal
        /// </summary>
        /// <param name="input">Instance of PartnerResponsePartnerPaymentTermAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PartnerResponsePartnerPaymentTermAttributes input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AdditionalMonths == input.AdditionalMonths ||
                    (this.AdditionalMonths != null &&
                    this.AdditionalMonths.Equals(input.AdditionalMonths))
                ) && 
                (
                    this.CutoffDay == input.CutoffDay ||
                    (this.CutoffDay != null &&
                    this.CutoffDay.Equals(input.CutoffDay))
                ) && 
                (
                    this.FixedDay == input.FixedDay ||
                    (this.FixedDay != null &&
                    this.FixedDay.Equals(input.FixedDay))
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
                if (this.AdditionalMonths != null)
                {
                    hashCode = (hashCode * 59) + this.AdditionalMonths.GetHashCode();
                }
                if (this.CutoffDay != null)
                {
                    hashCode = (hashCode * 59) + this.CutoffDay.GetHashCode();
                }
                if (this.FixedDay != null)
                {
                    hashCode = (hashCode * 59) + this.FixedDay.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
