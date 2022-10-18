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
    /// AccountItemsResponseAccountItems
    /// </summary>
    [DataContract(Name = "accountItemsResponse_account_items")]
    public partial class AccountItemsResponseAccountItems : IEquatable<AccountItemsResponseAccountItems>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountItemsResponseAccountItems" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AccountItemsResponseAccountItems() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountItemsResponseAccountItems" /> class.
        /// </summary>
        /// <param name="accountCategory">勘定科目カテゴリー (required).</param>
        /// <param name="accountCategoryId">勘定科目のカテゴリーID (required).</param>
        /// <param name="available">勘定科目の使用設定（true: 使用する、false: 使用しない） (required).</param>
        /// <param name="categories">categories (required).</param>
        /// <param name="correspondingExpenseId">支出取引相手勘定科目ID.</param>
        /// <param name="correspondingExpenseName">支出取引相手勘定科目名.</param>
        /// <param name="correspondingIncomeId">収入取引相手勘定科目ID.</param>
        /// <param name="correspondingIncomeName">収入取引相手勘定科目名.</param>
        /// <param name="defaultTaxCode">デフォルト設定がされている税区分コード (required).</param>
        /// <param name="groupName">決算書表示名（小カテゴリー）.</param>
        /// <param name="id">勘定科目ID (required).</param>
        /// <param name="name">勘定科目名 (30文字以内) (required).</param>
        /// <param name="shortcut">ショートカット1 (20文字以内).</param>
        /// <param name="shortcutNum">ショートカット2(勘定科目コード) (20文字以内).</param>
        /// <param name="taxCode">税区分コード (required).</param>
        /// <param name="walletableId">口座ID (required).</param>
        public AccountItemsResponseAccountItems(string accountCategory = default(string), int accountCategoryId = default(int), bool available = default(bool), List<string> categories = default(List<string>), int? correspondingExpenseId = default(int?), string correspondingExpenseName = default(string), int? correspondingIncomeId = default(int?), string correspondingIncomeName = default(string), int defaultTaxCode = default(int), string groupName = default(string), int id = default(int), string name = default(string), string shortcut = default(string), string shortcutNum = default(string), int taxCode = default(int), int? walletableId = default(int?))
        {
            // to ensure "accountCategory" is required (not null)
            if (accountCategory == null) {
                throw new ArgumentNullException("accountCategory is a required property for AccountItemsResponseAccountItems and cannot be null");
            }
            this.AccountCategory = accountCategory;
            this.AccountCategoryId = accountCategoryId;
            this.Available = available;
            // to ensure "categories" is required (not null)
            if (categories == null) {
                throw new ArgumentNullException("categories is a required property for AccountItemsResponseAccountItems and cannot be null");
            }
            this.Categories = categories;
            this.DefaultTaxCode = defaultTaxCode;
            this.Id = id;
            // to ensure "name" is required (not null)
            if (name == null) {
                throw new ArgumentNullException("name is a required property for AccountItemsResponseAccountItems and cannot be null");
            }
            this.Name = name;
            this.TaxCode = taxCode;
            // to ensure "walletableId" is required (not null)
            if (walletableId == null) {
                throw new ArgumentNullException("walletableId is a required property for AccountItemsResponseAccountItems and cannot be null");
            }
            this.WalletableId = walletableId;
            this.CorrespondingExpenseId = correspondingExpenseId;
            this.CorrespondingExpenseName = correspondingExpenseName;
            this.CorrespondingIncomeId = correspondingIncomeId;
            this.CorrespondingIncomeName = correspondingIncomeName;
            this.GroupName = groupName;
            this.Shortcut = shortcut;
            this.ShortcutNum = shortcutNum;
        }

        /// <summary>
        /// 勘定科目カテゴリー
        /// </summary>
        /// <value>勘定科目カテゴリー</value>
        [DataMember(Name = "account_category", IsRequired = true, EmitDefaultValue = false)]
        public string AccountCategory { get; set; }

        /// <summary>
        /// 勘定科目のカテゴリーID
        /// </summary>
        /// <value>勘定科目のカテゴリーID</value>
        [DataMember(Name = "account_category_id", IsRequired = true, EmitDefaultValue = false)]
        public int AccountCategoryId { get; set; }

        /// <summary>
        /// 勘定科目の使用設定（true: 使用する、false: 使用しない）
        /// </summary>
        /// <value>勘定科目の使用設定（true: 使用する、false: 使用しない）</value>
        [DataMember(Name = "available", IsRequired = true, EmitDefaultValue = true)]
        public bool Available { get; set; }

        /// <summary>
        /// Gets or Sets Categories
        /// </summary>
        [DataMember(Name = "categories", IsRequired = true, EmitDefaultValue = false)]
        public List<string> Categories { get; set; }

        /// <summary>
        /// 支出取引相手勘定科目ID
        /// </summary>
        /// <value>支出取引相手勘定科目ID</value>
        [DataMember(Name = "corresponding_expense_id", EmitDefaultValue = true)]
        public int? CorrespondingExpenseId { get; set; }

        /// <summary>
        /// 支出取引相手勘定科目名
        /// </summary>
        /// <value>支出取引相手勘定科目名</value>
        [DataMember(Name = "corresponding_expense_name", EmitDefaultValue = true)]
        public string CorrespondingExpenseName { get; set; }

        /// <summary>
        /// 収入取引相手勘定科目ID
        /// </summary>
        /// <value>収入取引相手勘定科目ID</value>
        [DataMember(Name = "corresponding_income_id", EmitDefaultValue = true)]
        public int? CorrespondingIncomeId { get; set; }

        /// <summary>
        /// 収入取引相手勘定科目名
        /// </summary>
        /// <value>収入取引相手勘定科目名</value>
        [DataMember(Name = "corresponding_income_name", EmitDefaultValue = true)]
        public string CorrespondingIncomeName { get; set; }

        /// <summary>
        /// デフォルト設定がされている税区分コード
        /// </summary>
        /// <value>デフォルト設定がされている税区分コード</value>
        [DataMember(Name = "default_tax_code", IsRequired = true, EmitDefaultValue = false)]
        public int DefaultTaxCode { get; set; }

        /// <summary>
        /// 決算書表示名（小カテゴリー）
        /// </summary>
        /// <value>決算書表示名（小カテゴリー）</value>
        [DataMember(Name = "group_name", EmitDefaultValue = true)]
        public string GroupName { get; set; }

        /// <summary>
        /// 勘定科目ID
        /// </summary>
        /// <value>勘定科目ID</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// 勘定科目名 (30文字以内)
        /// </summary>
        /// <value>勘定科目名 (30文字以内)</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// ショートカット1 (20文字以内)
        /// </summary>
        /// <value>ショートカット1 (20文字以内)</value>
        [DataMember(Name = "shortcut", EmitDefaultValue = true)]
        public string Shortcut { get; set; }

        /// <summary>
        /// ショートカット2(勘定科目コード) (20文字以内)
        /// </summary>
        /// <value>ショートカット2(勘定科目コード) (20文字以内)</value>
        [DataMember(Name = "shortcut_num", EmitDefaultValue = true)]
        public string ShortcutNum { get; set; }

        /// <summary>
        /// 税区分コード
        /// </summary>
        /// <value>税区分コード</value>
        [DataMember(Name = "tax_code", IsRequired = true, EmitDefaultValue = false)]
        public int TaxCode { get; set; }

        /// <summary>
        /// 口座ID
        /// </summary>
        /// <value>口座ID</value>
        [DataMember(Name = "walletable_id", IsRequired = true, EmitDefaultValue = true)]
        public int? WalletableId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AccountItemsResponseAccountItems {\n");
            sb.Append("  AccountCategory: ").Append(AccountCategory).Append("\n");
            sb.Append("  AccountCategoryId: ").Append(AccountCategoryId).Append("\n");
            sb.Append("  Available: ").Append(Available).Append("\n");
            sb.Append("  Categories: ").Append(Categories).Append("\n");
            sb.Append("  CorrespondingExpenseId: ").Append(CorrespondingExpenseId).Append("\n");
            sb.Append("  CorrespondingExpenseName: ").Append(CorrespondingExpenseName).Append("\n");
            sb.Append("  CorrespondingIncomeId: ").Append(CorrespondingIncomeId).Append("\n");
            sb.Append("  CorrespondingIncomeName: ").Append(CorrespondingIncomeName).Append("\n");
            sb.Append("  DefaultTaxCode: ").Append(DefaultTaxCode).Append("\n");
            sb.Append("  GroupName: ").Append(GroupName).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Shortcut: ").Append(Shortcut).Append("\n");
            sb.Append("  ShortcutNum: ").Append(ShortcutNum).Append("\n");
            sb.Append("  TaxCode: ").Append(TaxCode).Append("\n");
            sb.Append("  WalletableId: ").Append(WalletableId).Append("\n");
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
            return this.Equals(input as AccountItemsResponseAccountItems);
        }

        /// <summary>
        /// Returns true if AccountItemsResponseAccountItems instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountItemsResponseAccountItems to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountItemsResponseAccountItems input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AccountCategory == input.AccountCategory ||
                    (this.AccountCategory != null &&
                    this.AccountCategory.Equals(input.AccountCategory))
                ) && 
                (
                    this.AccountCategoryId == input.AccountCategoryId ||
                    this.AccountCategoryId.Equals(input.AccountCategoryId)
                ) && 
                (
                    this.Available == input.Available ||
                    this.Available.Equals(input.Available)
                ) && 
                (
                    this.Categories == input.Categories ||
                    this.Categories != null &&
                    input.Categories != null &&
                    this.Categories.SequenceEqual(input.Categories)
                ) && 
                (
                    this.CorrespondingExpenseId == input.CorrespondingExpenseId ||
                    (this.CorrespondingExpenseId != null &&
                    this.CorrespondingExpenseId.Equals(input.CorrespondingExpenseId))
                ) && 
                (
                    this.CorrespondingExpenseName == input.CorrespondingExpenseName ||
                    (this.CorrespondingExpenseName != null &&
                    this.CorrespondingExpenseName.Equals(input.CorrespondingExpenseName))
                ) && 
                (
                    this.CorrespondingIncomeId == input.CorrespondingIncomeId ||
                    (this.CorrespondingIncomeId != null &&
                    this.CorrespondingIncomeId.Equals(input.CorrespondingIncomeId))
                ) && 
                (
                    this.CorrespondingIncomeName == input.CorrespondingIncomeName ||
                    (this.CorrespondingIncomeName != null &&
                    this.CorrespondingIncomeName.Equals(input.CorrespondingIncomeName))
                ) && 
                (
                    this.DefaultTaxCode == input.DefaultTaxCode ||
                    this.DefaultTaxCode.Equals(input.DefaultTaxCode)
                ) && 
                (
                    this.GroupName == input.GroupName ||
                    (this.GroupName != null &&
                    this.GroupName.Equals(input.GroupName))
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
                    this.Shortcut == input.Shortcut ||
                    (this.Shortcut != null &&
                    this.Shortcut.Equals(input.Shortcut))
                ) && 
                (
                    this.ShortcutNum == input.ShortcutNum ||
                    (this.ShortcutNum != null &&
                    this.ShortcutNum.Equals(input.ShortcutNum))
                ) && 
                (
                    this.TaxCode == input.TaxCode ||
                    this.TaxCode.Equals(input.TaxCode)
                ) && 
                (
                    this.WalletableId == input.WalletableId ||
                    (this.WalletableId != null &&
                    this.WalletableId.Equals(input.WalletableId))
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
                if (this.AccountCategory != null)
                {
                    hashCode = (hashCode * 59) + this.AccountCategory.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AccountCategoryId.GetHashCode();
                hashCode = (hashCode * 59) + this.Available.GetHashCode();
                if (this.Categories != null)
                {
                    hashCode = (hashCode * 59) + this.Categories.GetHashCode();
                }
                if (this.CorrespondingExpenseId != null)
                {
                    hashCode = (hashCode * 59) + this.CorrespondingExpenseId.GetHashCode();
                }
                if (this.CorrespondingExpenseName != null)
                {
                    hashCode = (hashCode * 59) + this.CorrespondingExpenseName.GetHashCode();
                }
                if (this.CorrespondingIncomeId != null)
                {
                    hashCode = (hashCode * 59) + this.CorrespondingIncomeId.GetHashCode();
                }
                if (this.CorrespondingIncomeName != null)
                {
                    hashCode = (hashCode * 59) + this.CorrespondingIncomeName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.DefaultTaxCode.GetHashCode();
                if (this.GroupName != null)
                {
                    hashCode = (hashCode * 59) + this.GroupName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Id.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Shortcut != null)
                {
                    hashCode = (hashCode * 59) + this.Shortcut.GetHashCode();
                }
                if (this.ShortcutNum != null)
                {
                    hashCode = (hashCode * 59) + this.ShortcutNum.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TaxCode.GetHashCode();
                if (this.WalletableId != null)
                {
                    hashCode = (hashCode * 59) + this.WalletableId.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
