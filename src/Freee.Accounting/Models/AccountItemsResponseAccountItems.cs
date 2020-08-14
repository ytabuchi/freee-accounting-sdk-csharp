/*
 * freee API
 *
 *  <h1 id=\"freee_api\">freee API</h1> <hr /> <h2 id=\"start_guide\">スタートガイド</h2>  <p>freee API開発がはじめての方は<a href=\"https://developer.freee.co.jp/getting-started\">freee API スタートガイド</a>を参照してください。</p>  <hr /> <h2 id=\"specification\">仕様</h2>  <pre><code>【重要】会計freee APIの新バージョンについて 2020年12月まで、2つのバージョンが利用できる状態です。古いものは2020年12月に利用不可となります。<br> 新しいAPIを利用するにはリクエストヘッダーに以下を指定します。 X-Api-Version: 2020-06-15<br> 指定がない場合は2020年12月に廃止予定のAPIを利用することとなります。<br> 【重要】APIのバージョン指定をせずに利用し続ける場合 2020年12月に新しいバージョンのAPIに自動的に切り替わります。 詳細は、<a href=\"https://developer.freee.co.jp/release-note/2948\" target=\"_blank\">リリースノート</a>をご覧ください。<br> 旧バージョンのAPIリファレンスを確認したい場合は、<a href=\"https://freee.github.io/freee-api-schema/\" target=\"_blank\">旧バージョンのAPIリファレンスページ</a>をご覧ください。 </code></pre>  <h3 id=\"api_endpoint\">APIエンドポイント</h3>  <p>https://api.freee.co.jp/ (httpsのみ)</p>  <h3 id=\"about_authorize\">認証について</h3> <p>OAuth2.0を利用します。詳細は<a href=\"https://developer.freee.co.jp/docs\" target=\"_blank\">ドキュメントの認証</a>パートを参照してください。</p>  <h3 id=\"data_format\">データフォーマット</h3>  <p>リクエスト、レスポンスともにJSON形式をサポートしていますが、詳細は、API毎の説明欄（application/jsonなど）を確認してください。</p>  <h3 id=\"compatibility\">後方互換性ありの変更</h3>  <p>freeeでは、APIを改善していくために以下のような変更は後方互換性ありとして通知なく変更を入れることがあります。アプリケーション実装者は以下を踏まえて開発を行ってください。</p>  <ul> <li>新しいAPIリソース・エンドポイントの追加</li> <li>既存のAPIに対して必須ではない新しいリクエストパラメータの追加</li> <li>既存のAPIレスポンスに対する新しいプロパティの追加</li> <li>既存のAPIレスポンスに対するプロパティの順番の入れ変え</li> <li>keyとなっているidやcodeの長さの変更（長くする）</li> </ul>  <h3 id=\"common_response_header\">共通レスポンスヘッダー</h3>  <p>すべてのAPIのレスポンスには以下のHTTPヘッダーが含まれます。</p>  <ul> <li> <p>X-Freee-Request-ID</p> <ul> <li>各リクエスト毎に発行されるID</li> </ul> </li> </ul>  <h3 id=\"common_error_response\">共通エラーレスポンス</h3>  <ul> <li> <p>ステータスコードはレスポンス内のJSONに含まれる他、HTTPヘッダにも含まれる</p> </li> <li> <p>一部のエラーレスポンスにはエラーコードが含まれます。<br>詳細は、<a href=\"https://developer.freee.co.jp/tips/faq/40x-checkpoint\">HTTPステータスコード400台エラー時のチェックポイント</a>を参照してください</p> </li> <p>type</p>  <ul> <li>status : HTTPステータスコードの説明</li>  <li>validation : エラーの詳細の説明（開発者向け）</li> </ul> </li> </ul>  <p>レスポンスの例</p>  <pre><code>  {     &quot;status_code&quot; : 400,     &quot;errors&quot; : [       {         &quot;type&quot; : &quot;status&quot;,         &quot;messages&quot; : [&quot;不正なリクエストです。&quot;]       },       {         &quot;type&quot; : &quot;validation&quot;,         &quot;messages&quot; : [&quot;Date は不正な日付フォーマットです。入力例：2013-01-01&quot;]       }     ]   }</code></pre>  </br>  <h3 id=\"api_rate_limit\">API使用制限</h3>    <p>freeeは一定期間に過度のアクセスを検知した場合、APIアクセスをコントロールする場合があります。</p>   <p>その際のhttp status codeは403となります。制限がかかってから10分程度が過ぎると再度使用することができるようになります。</p>  <h4 id=\"reports_api_endpoint\">/reportsエンドポイント</h4>  <p>freeeは/reportsエンドポイントに対して1秒間に10以上のアクセスを検知した場合、APIアクセスをコントロールする場合があります。その際のhttp status codeは429（too many requests）となります。</p>  <p>レスポンスボディのmetaプロパティに以下を含めます。</p>  <ul>   <li>設定されている上限値</li>   <li>上限に達するまでの使用可能回数</li>   <li>（上限値に達した場合）使用回数がリセットされる時刻</li> </ul>  <h3 id=\"plan_api_rate_limit\">プラン別のAPI Rate Limit</h3>   <table border=\"1\">     <tbody>       <tr>         <th style=\"padding: 10px\"><strong>会計freeeプラン名</strong></th>         <th style=\"padding: 10px\"><strong>事業所とアプリケーション毎に1日でのAPIコール数</strong></th>       </tr>       <tr>         <td style=\"padding: 10px\">エンタープライズ</td>         <td style=\"padding: 10px\">10,000</td>       </tr>       <tr>         <td style=\"padding: 10px\">プロフェッショナル</td>         <td style=\"padding: 10px\">5,000</td>       </tr>       <tr>         <td style=\"padding: 10px\">ベーシック</td>         <td style=\"padding: 10px\">3,000</td>       </tr>       <tr>         <td style=\"padding: 10px\">ミニマム</td>         <td style=\"padding: 10px\">3,000</td>       </tr>       <tr>         <td style=\"padding: 10px\">上記以外</td>         <td style=\"padding: 10px\">3,000</td>       </tr>     </tbody>   </table>  <h3 id=\"webhook\">Webhookについて</h3>  <p>詳細は<a href=\"https://developer.freee.co.jp/docs/accounting/webhook\" target=\"_blank\">会計Webhook概要</a>を参照してください。</p>  <hr /> <h2 id=\"contact\">連絡先</h2>  <p>ご不明点、ご要望等は <a href=\"https://support.freee.co.jp/hc/ja/requests/new\">freee サポートデスクへのお問い合わせフォーム</a> からご連絡ください。</p> <hr />&copy; Since 2013 freee K.K.
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
using OpenAPIDateConverter = Freee.Accounting.Client.OpenAPIDateConverter;

namespace Freee.Accounting.Models
{
    /// <summary>
    /// AccountItemsResponseAccountItems
    /// </summary>
    [DataContract]
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
        /// <param name="defaultTaxId">デフォルト設定がされている税区分ID.</param>
        /// <param name="groupName">決算書表示名（小カテゴリー）.</param>
        /// <param name="id">勘定科目ID (required).</param>
        /// <param name="name">勘定科目名 (30文字以内) (required).</param>
        /// <param name="shortcut">ショートカット1 (20文字以内).</param>
        /// <param name="shortcutNum">ショートカット2(勘定科目コード) (20文字以内).</param>
        /// <param name="walletableId">口座ID (required).</param>
        public AccountItemsResponseAccountItems(string accountCategory = default(string), int accountCategoryId = default(int), bool available = default(bool), List<string> categories = default(List<string>), int? correspondingExpenseId = default(int?), string correspondingExpenseName = default(string), int? correspondingIncomeId = default(int?), string correspondingIncomeName = default(string), int defaultTaxCode = default(int), int defaultTaxId = default(int), string groupName = default(string), int id = default(int), string name = default(string), string shortcut = default(string), string shortcutNum = default(string), int? walletableId = default(int?))
        {
            // to ensure "accountCategory" is required (not null)
            this.AccountCategory = accountCategory ?? throw new ArgumentNullException("accountCategory is a required property for AccountItemsResponseAccountItems and cannot be null");
            this.AccountCategoryId = accountCategoryId;
            this.Available = available;
            // to ensure "categories" is required (not null)
            this.Categories = categories ?? throw new ArgumentNullException("categories is a required property for AccountItemsResponseAccountItems and cannot be null");
            this.DefaultTaxCode = defaultTaxCode;
            this.Id = id;
            // to ensure "name" is required (not null)
            this.Name = name ?? throw new ArgumentNullException("name is a required property for AccountItemsResponseAccountItems and cannot be null");
            // to ensure "walletableId" is required (not null)
            this.WalletableId = walletableId ?? throw new ArgumentNullException("walletableId is a required property for AccountItemsResponseAccountItems and cannot be null");
            this.CorrespondingExpenseId = correspondingExpenseId;
            this.CorrespondingExpenseName = correspondingExpenseName;
            this.CorrespondingIncomeId = correspondingIncomeId;
            this.CorrespondingIncomeName = correspondingIncomeName;
            this.DefaultTaxId = defaultTaxId;
            this.GroupName = groupName;
            this.Shortcut = shortcut;
            this.ShortcutNum = shortcutNum;
        }

        /// <summary>
        /// 勘定科目カテゴリー
        /// </summary>
        /// <value>勘定科目カテゴリー</value>
        [DataMember(Name = "account_category", EmitDefaultValue = false)]
        public string AccountCategory { get; set; }

        /// <summary>
        /// 勘定科目のカテゴリーID
        /// </summary>
        /// <value>勘定科目のカテゴリーID</value>
        [DataMember(Name = "account_category_id", EmitDefaultValue = false)]
        public int AccountCategoryId { get; set; }

        /// <summary>
        /// 勘定科目の使用設定（true: 使用する、false: 使用しない）
        /// </summary>
        /// <value>勘定科目の使用設定（true: 使用する、false: 使用しない）</value>
        [DataMember(Name = "available", EmitDefaultValue = false)]
        public bool Available { get; set; }

        /// <summary>
        /// Gets or Sets Categories
        /// </summary>
        [DataMember(Name = "categories", EmitDefaultValue = false)]
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
        [DataMember(Name = "default_tax_code", EmitDefaultValue = false)]
        public int DefaultTaxCode { get; set; }

        /// <summary>
        /// デフォルト設定がされている税区分ID
        /// </summary>
        /// <value>デフォルト設定がされている税区分ID</value>
        [DataMember(Name = "default_tax_id", EmitDefaultValue = false)]
        public int DefaultTaxId { get; set; }

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
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// 勘定科目名 (30文字以内)
        /// </summary>
        /// <value>勘定科目名 (30文字以内)</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
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
        /// 口座ID
        /// </summary>
        /// <value>口座ID</value>
        [DataMember(Name = "walletable_id", EmitDefaultValue = true)]
        public int? WalletableId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
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
            sb.Append("  DefaultTaxId: ").Append(DefaultTaxId).Append("\n");
            sb.Append("  GroupName: ").Append(GroupName).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Shortcut: ").Append(Shortcut).Append("\n");
            sb.Append("  ShortcutNum: ").Append(ShortcutNum).Append("\n");
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
            return JsonConvert.SerializeObject(this, Formatting.Indented);
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
                return false;

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
                    this.DefaultTaxId == input.DefaultTaxId ||
                    this.DefaultTaxId.Equals(input.DefaultTaxId)
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
                    hashCode = hashCode * 59 + this.AccountCategory.GetHashCode();
                hashCode = hashCode * 59 + this.AccountCategoryId.GetHashCode();
                hashCode = hashCode * 59 + this.Available.GetHashCode();
                if (this.Categories != null)
                    hashCode = hashCode * 59 + this.Categories.GetHashCode();
                if (this.CorrespondingExpenseId != null)
                    hashCode = hashCode * 59 + this.CorrespondingExpenseId.GetHashCode();
                if (this.CorrespondingExpenseName != null)
                    hashCode = hashCode * 59 + this.CorrespondingExpenseName.GetHashCode();
                if (this.CorrespondingIncomeId != null)
                    hashCode = hashCode * 59 + this.CorrespondingIncomeId.GetHashCode();
                if (this.CorrespondingIncomeName != null)
                    hashCode = hashCode * 59 + this.CorrespondingIncomeName.GetHashCode();
                hashCode = hashCode * 59 + this.DefaultTaxCode.GetHashCode();
                hashCode = hashCode * 59 + this.DefaultTaxId.GetHashCode();
                if (this.GroupName != null)
                    hashCode = hashCode * 59 + this.GroupName.GetHashCode();
                hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Shortcut != null)
                    hashCode = hashCode * 59 + this.Shortcut.GetHashCode();
                if (this.ShortcutNum != null)
                    hashCode = hashCode * 59 + this.ShortcutNum.GetHashCode();
                if (this.WalletableId != null)
                    hashCode = hashCode * 59 + this.WalletableId.GetHashCode();
                return hashCode;
            }
        }

    }

}
