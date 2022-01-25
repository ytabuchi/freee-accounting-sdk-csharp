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
    /// InvoiceIndexResponse
    /// </summary>
    [DataContract(Name = "invoiceIndexResponse")]
    public partial class InvoiceIndexResponse : IEquatable<InvoiceIndexResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceIndexResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InvoiceIndexResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceIndexResponse" /> class.
        /// </summary>
        /// <param name="invoices">invoices (required).</param>
        public InvoiceIndexResponse(List<InvoiceIndexResponseInvoices> invoices = default(List<InvoiceIndexResponseInvoices>))
        {
            // to ensure "invoices" is required (not null)
            if (invoices == null) {
                throw new ArgumentNullException("invoices is a required property for InvoiceIndexResponse and cannot be null");
            }
            this.Invoices = invoices;
        }

        /// <summary>
        /// Gets or Sets Invoices
        /// </summary>
        [DataMember(Name = "invoices", IsRequired = true, EmitDefaultValue = false)]
        public List<InvoiceIndexResponseInvoices> Invoices { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InvoiceIndexResponse {\n");
            sb.Append("  Invoices: ").Append(Invoices).Append("\n");
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
            return this.Equals(input as InvoiceIndexResponse);
        }

        /// <summary>
        /// Returns true if InvoiceIndexResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of InvoiceIndexResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InvoiceIndexResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Invoices == input.Invoices ||
                    this.Invoices != null &&
                    input.Invoices != null &&
                    this.Invoices.SequenceEqual(input.Invoices)
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
                if (this.Invoices != null)
                {
                    hashCode = (hashCode * 59) + this.Invoices.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
