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
    /// ExpenseApplicationsIndexResponseExpenseApplicationLines
    /// </summary>
    [DataContract(Name = "expenseApplicationsIndexResponse_expense_application_lines")]
    public partial class ExpenseApplicationsIndexResponseExpenseApplicationLines : IEquatable<ExpenseApplicationsIndexResponseExpenseApplicationLines>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExpenseApplicationsIndexResponseExpenseApplicationLines" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ExpenseApplicationsIndexResponseExpenseApplicationLines() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExpenseApplicationsIndexResponseExpenseApplicationLines" /> class.
        /// </summary>
        /// <param name="amount">金額.</param>
        /// <param name="description">内容.</param>
        /// <param name="expenseApplicationLineTemplateId">経費科目ID.</param>
        /// <param name="id">経費申請の項目行ID (required).</param>
        /// <param name="receiptId">ファイルボックス（証憑ファイル）ID.</param>
        /// <param name="transactionDate">日付 (yyyy-mm-dd).</param>
        public ExpenseApplicationsIndexResponseExpenseApplicationLines(int amount = default(int), string description = default(string), int expenseApplicationLineTemplateId = default(int), long id = default(long), int receiptId = default(int), string transactionDate = default(string))
        {
            this.Id = id;
            this.Amount = amount;
            this.Description = description;
            this.ExpenseApplicationLineTemplateId = expenseApplicationLineTemplateId;
            this.ReceiptId = receiptId;
            this.TransactionDate = transactionDate;
        }

        /// <summary>
        /// 金額
        /// </summary>
        /// <value>金額</value>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public int Amount { get; set; }

        /// <summary>
        /// 内容
        /// </summary>
        /// <value>内容</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// 経費科目ID
        /// </summary>
        /// <value>経費科目ID</value>
        [DataMember(Name = "expense_application_line_template_id", EmitDefaultValue = false)]
        public int ExpenseApplicationLineTemplateId { get; set; }

        /// <summary>
        /// 経費申請の項目行ID
        /// </summary>
        /// <value>経費申請の項目行ID</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public long Id { get; set; }

        /// <summary>
        /// ファイルボックス（証憑ファイル）ID
        /// </summary>
        /// <value>ファイルボックス（証憑ファイル）ID</value>
        [DataMember(Name = "receipt_id", EmitDefaultValue = false)]
        public int ReceiptId { get; set; }

        /// <summary>
        /// 日付 (yyyy-mm-dd)
        /// </summary>
        /// <value>日付 (yyyy-mm-dd)</value>
        [DataMember(Name = "transaction_date", EmitDefaultValue = false)]
        public string TransactionDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ExpenseApplicationsIndexResponseExpenseApplicationLines {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ExpenseApplicationLineTemplateId: ").Append(ExpenseApplicationLineTemplateId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ReceiptId: ").Append(ReceiptId).Append("\n");
            sb.Append("  TransactionDate: ").Append(TransactionDate).Append("\n");
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
            return this.Equals(input as ExpenseApplicationsIndexResponseExpenseApplicationLines);
        }

        /// <summary>
        /// Returns true if ExpenseApplicationsIndexResponseExpenseApplicationLines instances are equal
        /// </summary>
        /// <param name="input">Instance of ExpenseApplicationsIndexResponseExpenseApplicationLines to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExpenseApplicationsIndexResponseExpenseApplicationLines input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Amount == input.Amount ||
                    this.Amount.Equals(input.Amount)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.ExpenseApplicationLineTemplateId == input.ExpenseApplicationLineTemplateId ||
                    this.ExpenseApplicationLineTemplateId.Equals(input.ExpenseApplicationLineTemplateId)
                ) && 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.ReceiptId == input.ReceiptId ||
                    this.ReceiptId.Equals(input.ReceiptId)
                ) && 
                (
                    this.TransactionDate == input.TransactionDate ||
                    (this.TransactionDate != null &&
                    this.TransactionDate.Equals(input.TransactionDate))
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
                hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ExpenseApplicationLineTemplateId.GetHashCode();
                hashCode = (hashCode * 59) + this.Id.GetHashCode();
                hashCode = (hashCode * 59) + this.ReceiptId.GetHashCode();
                if (this.TransactionDate != null)
                {
                    hashCode = (hashCode * 59) + this.TransactionDate.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
