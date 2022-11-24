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
    /// PartnersResponsePartners
    /// </summary>
    [DataContract(Name = "partnersResponse_partners")]
    public partial class PartnersResponsePartners : IEquatable<PartnersResponsePartners>
    {
        /// <summary>
        /// 振込手数料負担（一括振込ファイル用）: (振込元(当方): payer, 振込先(先方): payee)
        /// </summary>
        /// <value>振込手数料負担（一括振込ファイル用）: (振込元(当方): payer, 振込先(先方): payee)</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TransferFeeHandlingSideEnum
        {
            /// <summary>
            /// Enum Payer for value: payer
            /// </summary>
            [EnumMember(Value = "payer")]
            Payer = 1,

            /// <summary>
            /// Enum Payee for value: payee
            /// </summary>
            [EnumMember(Value = "payee")]
            Payee = 2

        }


        /// <summary>
        /// 振込手数料負担（一括振込ファイル用）: (振込元(当方): payer, 振込先(先方): payee)
        /// </summary>
        /// <value>振込手数料負担（一括振込ファイル用）: (振込元(当方): payer, 振込先(先方): payee)</value>
        [DataMember(Name = "transfer_fee_handling_side", EmitDefaultValue = false)]
        public TransferFeeHandlingSideEnum? TransferFeeHandlingSide { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PartnersResponsePartners" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PartnersResponsePartners() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PartnersResponsePartners" /> class.
        /// </summary>
        /// <param name="addressAttributes">addressAttributes.</param>
        /// <param name="available">取引先の使用設定（true: 使用する、false: 使用しない） &lt;br&gt; &lt;ul&gt;   &lt;li&gt;     本APIでpartnerを作成した場合はtrueになります。   &lt;/li&gt;   &lt;li&gt;     falseにする場合はWeb画面から変更できます。   &lt;/li&gt;   &lt;li&gt;     trueの場合、Web画面での取引登録時などに入力候補として表示されます。   &lt;/li&gt;   &lt;li&gt;     falseの場合、取引先自体は削除せず、Web画面での取引登録時などに入力候補として表示されません。ただし取引（収入／支出）の作成APIなどでfalseの取引先をパラメータに指定すれば、取引などにfalseの取引先を設定できます。   &lt;/li&gt; &lt;/ul&gt; (required).</param>
        /// <param name="code">取引先コード (required).</param>
        /// <param name="companyId">事業所ID (required).</param>
        /// <param name="contactName">担当者 氏名.</param>
        /// <param name="countryCode">地域（JP: 国内、ZZ:国外）.</param>
        /// <param name="defaultTitle">敬称（御中、様、(空白)の3つから選択）.</param>
        /// <param name="email">担当者 メールアドレス.</param>
        /// <param name="id">取引先ID (required).</param>
        /// <param name="longName">正式名称（255文字以内）.</param>
        /// <param name="name">取引先名 (required).</param>
        /// <param name="nameKana">カナ名称（255文字以内）.</param>
        /// <param name="orgCode">事業所種別（null: 未設定、1: 法人、2: 個人）.</param>
        /// <param name="partnerBankAccountAttributes">partnerBankAccountAttributes.</param>
        /// <param name="partnerDocSettingAttributes">partnerDocSettingAttributes.</param>
        /// <param name="payerWalletableId">振込元口座ID（一括振込ファイル用）:（未設定の場合は、nullです。）.</param>
        /// <param name="phone">電話番号.</param>
        /// <param name="shortcut1">ショートカット1 (255文字以内).</param>
        /// <param name="shortcut2">ショートカット2 (255文字以内).</param>
        /// <param name="transferFeeHandlingSide">振込手数料負担（一括振込ファイル用）: (振込元(当方): payer, 振込先(先方): payee).</param>
        /// <param name="updateDate">更新日 (yyyy-mm-dd) (required).</param>
        public PartnersResponsePartners(PartnerResponsePartnerAddressAttributes addressAttributes = default(PartnerResponsePartnerAddressAttributes), bool available = default(bool), string code = default(string), int companyId = default(int), string contactName = default(string), string countryCode = default(string), string defaultTitle = default(string), string email = default(string), int id = default(int), string longName = default(string), string name = default(string), string nameKana = default(string), int? orgCode = default(int?), PartnerResponsePartnerPartnerBankAccountAttributes partnerBankAccountAttributes = default(PartnerResponsePartnerPartnerBankAccountAttributes), PartnerCreateParamsPartnerDocSettingAttributes partnerDocSettingAttributes = default(PartnerCreateParamsPartnerDocSettingAttributes), int? payerWalletableId = default(int?), string phone = default(string), string shortcut1 = default(string), string shortcut2 = default(string), TransferFeeHandlingSideEnum? transferFeeHandlingSide = default(TransferFeeHandlingSideEnum?), string updateDate = default(string))
        {
            this.Available = available;
            // to ensure "code" is required (not null)
            if (code == null) {
                throw new ArgumentNullException("code is a required property for PartnersResponsePartners and cannot be null");
            }
            this.Code = code;
            this.CompanyId = companyId;
            this.Id = id;
            // to ensure "name" is required (not null)
            if (name == null) {
                throw new ArgumentNullException("name is a required property for PartnersResponsePartners and cannot be null");
            }
            this.Name = name;
            // to ensure "updateDate" is required (not null)
            if (updateDate == null) {
                throw new ArgumentNullException("updateDate is a required property for PartnersResponsePartners and cannot be null");
            }
            this.UpdateDate = updateDate;
            this.AddressAttributes = addressAttributes;
            this.ContactName = contactName;
            this.CountryCode = countryCode;
            this.DefaultTitle = defaultTitle;
            this.Email = email;
            this.LongName = longName;
            this.NameKana = nameKana;
            this.OrgCode = orgCode;
            this.PartnerBankAccountAttributes = partnerBankAccountAttributes;
            this.PartnerDocSettingAttributes = partnerDocSettingAttributes;
            this.PayerWalletableId = payerWalletableId;
            this.Phone = phone;
            this.Shortcut1 = shortcut1;
            this.Shortcut2 = shortcut2;
            this.TransferFeeHandlingSide = transferFeeHandlingSide;
        }

        /// <summary>
        /// Gets or Sets AddressAttributes
        /// </summary>
        [DataMember(Name = "address_attributes", EmitDefaultValue = false)]
        public PartnerResponsePartnerAddressAttributes AddressAttributes { get; set; }

        /// <summary>
        /// 取引先の使用設定（true: 使用する、false: 使用しない） &lt;br&gt; &lt;ul&gt;   &lt;li&gt;     本APIでpartnerを作成した場合はtrueになります。   &lt;/li&gt;   &lt;li&gt;     falseにする場合はWeb画面から変更できます。   &lt;/li&gt;   &lt;li&gt;     trueの場合、Web画面での取引登録時などに入力候補として表示されます。   &lt;/li&gt;   &lt;li&gt;     falseの場合、取引先自体は削除せず、Web画面での取引登録時などに入力候補として表示されません。ただし取引（収入／支出）の作成APIなどでfalseの取引先をパラメータに指定すれば、取引などにfalseの取引先を設定できます。   &lt;/li&gt; &lt;/ul&gt;
        /// </summary>
        /// <value>取引先の使用設定（true: 使用する、false: 使用しない） &lt;br&gt; &lt;ul&gt;   &lt;li&gt;     本APIでpartnerを作成した場合はtrueになります。   &lt;/li&gt;   &lt;li&gt;     falseにする場合はWeb画面から変更できます。   &lt;/li&gt;   &lt;li&gt;     trueの場合、Web画面での取引登録時などに入力候補として表示されます。   &lt;/li&gt;   &lt;li&gt;     falseの場合、取引先自体は削除せず、Web画面での取引登録時などに入力候補として表示されません。ただし取引（収入／支出）の作成APIなどでfalseの取引先をパラメータに指定すれば、取引などにfalseの取引先を設定できます。   &lt;/li&gt; &lt;/ul&gt;</value>
        [DataMember(Name = "available", IsRequired = true, EmitDefaultValue = true)]
        public bool Available { get; set; }

        /// <summary>
        /// 取引先コード
        /// </summary>
        /// <value>取引先コード</value>
        [DataMember(Name = "code", IsRequired = true, EmitDefaultValue = true)]
        public string Code { get; set; }

        /// <summary>
        /// 事業所ID
        /// </summary>
        /// <value>事業所ID</value>
        [DataMember(Name = "company_id", IsRequired = true, EmitDefaultValue = false)]
        public int CompanyId { get; set; }

        /// <summary>
        /// 担当者 氏名
        /// </summary>
        /// <value>担当者 氏名</value>
        [DataMember(Name = "contact_name", EmitDefaultValue = true)]
        public string ContactName { get; set; }

        /// <summary>
        /// 地域（JP: 国内、ZZ:国外）
        /// </summary>
        /// <value>地域（JP: 国内、ZZ:国外）</value>
        [DataMember(Name = "country_code", EmitDefaultValue = false)]
        public string CountryCode { get; set; }

        /// <summary>
        /// 敬称（御中、様、(空白)の3つから選択）
        /// </summary>
        /// <value>敬称（御中、様、(空白)の3つから選択）</value>
        [DataMember(Name = "default_title", EmitDefaultValue = true)]
        public string DefaultTitle { get; set; }

        /// <summary>
        /// 担当者 メールアドレス
        /// </summary>
        /// <value>担当者 メールアドレス</value>
        [DataMember(Name = "email", EmitDefaultValue = true)]
        public string Email { get; set; }

        /// <summary>
        /// 取引先ID
        /// </summary>
        /// <value>取引先ID</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// 正式名称（255文字以内）
        /// </summary>
        /// <value>正式名称（255文字以内）</value>
        [DataMember(Name = "long_name", EmitDefaultValue = true)]
        public string LongName { get; set; }

        /// <summary>
        /// 取引先名
        /// </summary>
        /// <value>取引先名</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// カナ名称（255文字以内）
        /// </summary>
        /// <value>カナ名称（255文字以内）</value>
        [DataMember(Name = "name_kana", EmitDefaultValue = true)]
        public string NameKana { get; set; }

        /// <summary>
        /// 事業所種別（null: 未設定、1: 法人、2: 個人）
        /// </summary>
        /// <value>事業所種別（null: 未設定、1: 法人、2: 個人）</value>
        [DataMember(Name = "org_code", EmitDefaultValue = true)]
        public int? OrgCode { get; set; }

        /// <summary>
        /// Gets or Sets PartnerBankAccountAttributes
        /// </summary>
        [DataMember(Name = "partner_bank_account_attributes", EmitDefaultValue = false)]
        public PartnerResponsePartnerPartnerBankAccountAttributes PartnerBankAccountAttributes { get; set; }

        /// <summary>
        /// Gets or Sets PartnerDocSettingAttributes
        /// </summary>
        [DataMember(Name = "partner_doc_setting_attributes", EmitDefaultValue = false)]
        public PartnerCreateParamsPartnerDocSettingAttributes PartnerDocSettingAttributes { get; set; }

        /// <summary>
        /// 振込元口座ID（一括振込ファイル用）:（未設定の場合は、nullです。）
        /// </summary>
        /// <value>振込元口座ID（一括振込ファイル用）:（未設定の場合は、nullです。）</value>
        [DataMember(Name = "payer_walletable_id", EmitDefaultValue = true)]
        public int? PayerWalletableId { get; set; }

        /// <summary>
        /// 電話番号
        /// </summary>
        /// <value>電話番号</value>
        [DataMember(Name = "phone", EmitDefaultValue = true)]
        public string Phone { get; set; }

        /// <summary>
        /// ショートカット1 (255文字以内)
        /// </summary>
        /// <value>ショートカット1 (255文字以内)</value>
        [DataMember(Name = "shortcut1", EmitDefaultValue = true)]
        public string Shortcut1 { get; set; }

        /// <summary>
        /// ショートカット2 (255文字以内)
        /// </summary>
        /// <value>ショートカット2 (255文字以内)</value>
        [DataMember(Name = "shortcut2", EmitDefaultValue = true)]
        public string Shortcut2 { get; set; }

        /// <summary>
        /// 更新日 (yyyy-mm-dd)
        /// </summary>
        /// <value>更新日 (yyyy-mm-dd)</value>
        [DataMember(Name = "update_date", IsRequired = true, EmitDefaultValue = false)]
        public string UpdateDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PartnersResponsePartners {\n");
            sb.Append("  AddressAttributes: ").Append(AddressAttributes).Append("\n");
            sb.Append("  Available: ").Append(Available).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  CompanyId: ").Append(CompanyId).Append("\n");
            sb.Append("  ContactName: ").Append(ContactName).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  DefaultTitle: ").Append(DefaultTitle).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LongName: ").Append(LongName).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  NameKana: ").Append(NameKana).Append("\n");
            sb.Append("  OrgCode: ").Append(OrgCode).Append("\n");
            sb.Append("  PartnerBankAccountAttributes: ").Append(PartnerBankAccountAttributes).Append("\n");
            sb.Append("  PartnerDocSettingAttributes: ").Append(PartnerDocSettingAttributes).Append("\n");
            sb.Append("  PayerWalletableId: ").Append(PayerWalletableId).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  Shortcut1: ").Append(Shortcut1).Append("\n");
            sb.Append("  Shortcut2: ").Append(Shortcut2).Append("\n");
            sb.Append("  TransferFeeHandlingSide: ").Append(TransferFeeHandlingSide).Append("\n");
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
            return this.Equals(input as PartnersResponsePartners);
        }

        /// <summary>
        /// Returns true if PartnersResponsePartners instances are equal
        /// </summary>
        /// <param name="input">Instance of PartnersResponsePartners to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PartnersResponsePartners input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AddressAttributes == input.AddressAttributes ||
                    (this.AddressAttributes != null &&
                    this.AddressAttributes.Equals(input.AddressAttributes))
                ) && 
                (
                    this.Available == input.Available ||
                    this.Available.Equals(input.Available)
                ) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.CompanyId == input.CompanyId ||
                    this.CompanyId.Equals(input.CompanyId)
                ) && 
                (
                    this.ContactName == input.ContactName ||
                    (this.ContactName != null &&
                    this.ContactName.Equals(input.ContactName))
                ) && 
                (
                    this.CountryCode == input.CountryCode ||
                    (this.CountryCode != null &&
                    this.CountryCode.Equals(input.CountryCode))
                ) && 
                (
                    this.DefaultTitle == input.DefaultTitle ||
                    (this.DefaultTitle != null &&
                    this.DefaultTitle.Equals(input.DefaultTitle))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.LongName == input.LongName ||
                    (this.LongName != null &&
                    this.LongName.Equals(input.LongName))
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
                    this.OrgCode == input.OrgCode ||
                    (this.OrgCode != null &&
                    this.OrgCode.Equals(input.OrgCode))
                ) && 
                (
                    this.PartnerBankAccountAttributes == input.PartnerBankAccountAttributes ||
                    (this.PartnerBankAccountAttributes != null &&
                    this.PartnerBankAccountAttributes.Equals(input.PartnerBankAccountAttributes))
                ) && 
                (
                    this.PartnerDocSettingAttributes == input.PartnerDocSettingAttributes ||
                    (this.PartnerDocSettingAttributes != null &&
                    this.PartnerDocSettingAttributes.Equals(input.PartnerDocSettingAttributes))
                ) && 
                (
                    this.PayerWalletableId == input.PayerWalletableId ||
                    (this.PayerWalletableId != null &&
                    this.PayerWalletableId.Equals(input.PayerWalletableId))
                ) && 
                (
                    this.Phone == input.Phone ||
                    (this.Phone != null &&
                    this.Phone.Equals(input.Phone))
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
                    this.TransferFeeHandlingSide == input.TransferFeeHandlingSide ||
                    this.TransferFeeHandlingSide.Equals(input.TransferFeeHandlingSide)
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
                if (this.AddressAttributes != null)
                {
                    hashCode = (hashCode * 59) + this.AddressAttributes.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Available.GetHashCode();
                if (this.Code != null)
                {
                    hashCode = (hashCode * 59) + this.Code.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CompanyId.GetHashCode();
                if (this.ContactName != null)
                {
                    hashCode = (hashCode * 59) + this.ContactName.GetHashCode();
                }
                if (this.CountryCode != null)
                {
                    hashCode = (hashCode * 59) + this.CountryCode.GetHashCode();
                }
                if (this.DefaultTitle != null)
                {
                    hashCode = (hashCode * 59) + this.DefaultTitle.GetHashCode();
                }
                if (this.Email != null)
                {
                    hashCode = (hashCode * 59) + this.Email.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Id.GetHashCode();
                if (this.LongName != null)
                {
                    hashCode = (hashCode * 59) + this.LongName.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.NameKana != null)
                {
                    hashCode = (hashCode * 59) + this.NameKana.GetHashCode();
                }
                if (this.OrgCode != null)
                {
                    hashCode = (hashCode * 59) + this.OrgCode.GetHashCode();
                }
                if (this.PartnerBankAccountAttributes != null)
                {
                    hashCode = (hashCode * 59) + this.PartnerBankAccountAttributes.GetHashCode();
                }
                if (this.PartnerDocSettingAttributes != null)
                {
                    hashCode = (hashCode * 59) + this.PartnerDocSettingAttributes.GetHashCode();
                }
                if (this.PayerWalletableId != null)
                {
                    hashCode = (hashCode * 59) + this.PayerWalletableId.GetHashCode();
                }
                if (this.Phone != null)
                {
                    hashCode = (hashCode * 59) + this.Phone.GetHashCode();
                }
                if (this.Shortcut1 != null)
                {
                    hashCode = (hashCode * 59) + this.Shortcut1.GetHashCode();
                }
                if (this.Shortcut2 != null)
                {
                    hashCode = (hashCode * 59) + this.Shortcut2.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TransferFeeHandlingSide.GetHashCode();
                if (this.UpdateDate != null)
                {
                    hashCode = (hashCode * 59) + this.UpdateDate.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
