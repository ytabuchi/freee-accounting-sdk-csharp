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
    /// BadRequestNotFoundError
    /// </summary>
    [DataContract(Name = "badRequestNotFoundError")]
    public partial class BadRequestNotFoundError : IEquatable<BadRequestNotFoundError>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BadRequestNotFoundError" /> class.
        /// </summary>
        /// <param name="errors">errors.</param>
        /// <param name="statusCode">statusCode.</param>
        public BadRequestNotFoundError(List<BadRequestNotFoundErrorErrors> errors = default(List<BadRequestNotFoundErrorErrors>), int statusCode = default(int))
        {
            this.Errors = errors;
            this.StatusCode = statusCode;
        }

        /// <summary>
        /// Gets or Sets Errors
        /// </summary>
        [DataMember(Name = "errors", EmitDefaultValue = false)]
        public List<BadRequestNotFoundErrorErrors> Errors { get; set; }

        /// <summary>
        /// Gets or Sets StatusCode
        /// </summary>
        [DataMember(Name = "status_code", EmitDefaultValue = false)]
        public int StatusCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BadRequestNotFoundError {\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
            sb.Append("  StatusCode: ").Append(StatusCode).Append("\n");
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
            return this.Equals(input as BadRequestNotFoundError);
        }

        /// <summary>
        /// Returns true if BadRequestNotFoundError instances are equal
        /// </summary>
        /// <param name="input">Instance of BadRequestNotFoundError to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BadRequestNotFoundError input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Errors == input.Errors ||
                    this.Errors != null &&
                    input.Errors != null &&
                    this.Errors.SequenceEqual(input.Errors)
                ) && 
                (
                    this.StatusCode == input.StatusCode ||
                    this.StatusCode.Equals(input.StatusCode)
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
                if (this.Errors != null)
                {
                    hashCode = (hashCode * 59) + this.Errors.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.StatusCode.GetHashCode();
                return hashCode;
            }
        }

    }

}
