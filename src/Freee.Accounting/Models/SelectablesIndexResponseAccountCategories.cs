/* 
 * freee API
 *
 *  <h1 id=\"freee_api\">freee API</h1> <hr /> <h2 id=\"start_guide\">スタートガイド</h2>  <p>freee API開発がはじめての方は<a href=\"https://developer.freee.co.jp/getting-started\">freee API スタートガイド</a>を参照してください。</p>  <hr /> <h2 id=\"specification\">仕様</h2>  <pre><code>【重要】会計freee APIの新バージョンについて 2020年12月まで、2つのバージョンが利用できる状態です。古いものは2020年12月に利用不可となります。<br> 新しいAPIを利用するにはリクエストヘッダーに以下を指定します。 X-Api-Version: 2020-06-15<br> 指定がない場合は2020年12月に廃止予定のAPIを利用することとなります。<br> 【重要】APIのバージョン指定をせずに利用し続ける場合 2020年12月に新しいバージョンのAPIに自動的に切り替わります。 詳細は、<a href=\"https://developer.freee.co.jp/release-note/2948\" target=\"_blank\">リリースノート</a>をご覧ください。<br> 旧バージョンのAPIリファレンスを確認したい場合は、<a href=\"https://freee.github.io/freee-api-schema/\" target=\"_blank\">旧バージョンのAPIリファレンスページ</a>をご覧ください。 </code></pre>  <h3 id=\"api_endpoint\">APIエンドポイント</h3>  <p>https://api.freee.co.jp/ (httpsのみ)</p>  <h3 id=\"about_authorize\">認証について</h3> <p>OAuth2.0を利用します。詳細は<a href=\"https://developer.freee.co.jp/docs\" target=\"_blank\">ドキュメントの認証</a>パートを参照してください。</p>  <h3 id=\"data_format\">データフォーマット</h3>  <p>リクエスト、レスポンスともにJSON形式をサポートしていますが、詳細は、API毎の説明欄（application/jsonなど）を確認してください。</p>  <h3 id=\"compatibility\">後方互換性ありの変更</h3>  <p>freeeでは、APIを改善していくために以下のような変更は後方互換性ありとして通知なく変更を入れることがあります。アプリケーション実装者は以下を踏まえて開発を行ってください。</p>  <ul> <li>新しいAPIリソース・エンドポイントの追加</li> <li>既存のAPIに対して必須ではない新しいリクエストパラメータの追加</li> <li>既存のAPIレスポンスに対する新しいプロパティの追加</li> <li>既存のAPIレスポンスに対するプロパティの順番の入れ変え</li> <li>keyとなっているidやcodeの長さの変更（長くする）</li> </ul>  <h3 id=\"common_response_header\">共通レスポンスヘッダー</h3>  <p>すべてのAPIのレスポンスには以下のHTTPヘッダーが含まれます。</p>  <ul> <li> <p>X-Freee-Request-ID</p> <ul> <li>各リクエスト毎に発行されるID</li> </ul> </li> </ul>  <h3 id=\"common_error_response\">共通エラーレスポンス</h3>  <ul> <li> <p>ステータスコードはレスポンス内のJSONに含まれる他、HTTPヘッダにも含まれる</p> </li> <li> <p>一部のエラーレスポンスにはエラーコードが含まれます。<br>詳細は、<a href=\"https://developer.freee.co.jp/tips/faq/40x-checkpoint\">HTTPステータスコード400台エラー時のチェックポイント</a>を参照してください</p> </li> <p>type</p>  <ul> <li>status : HTTPステータスコードの説明</li>  <li>validation : エラーの詳細の説明（開発者向け）</li> </ul> </li> </ul>  <p>レスポンスの例</p>  <pre><code>  {     &quot;status_code&quot; : 400,     &quot;errors&quot; : [       {         &quot;type&quot; : &quot;status&quot;,         &quot;messages&quot; : [&quot;不正なリクエストです。&quot;]       },       {         &quot;type&quot; : &quot;validation&quot;,         &quot;messages&quot; : [&quot;Date は不正な日付フォーマットです。入力例：2013-01-01&quot;]       }     ]   }</code></pre>  </br>  <h3 id=\"api_rate_limit\">API使用制限</h3>    <p>freeeは一定期間に過度のアクセスを検知した場合、APIアクセスをコントロールする場合があります。</p>   <p>その際のhttp status codeは403となります。制限がかかってから10分程度が過ぎると再度使用することができるようになります。</p>  <h4 id=\"reports_api_endpoint\">/reportsエンドポイント</h4>  <p>freeeは/reportsエンドポイントに対して1秒間に10以上のアクセスを検知した場合、APIアクセスをコントロールする場合があります。その際のhttp status codeは429（too many requests）となります。</p>  <p>レスポンスボディのmetaプロパティに以下を含めます。</p>  <ul>   <li>設定されている上限値</li>   <li>上限に達するまでの使用可能回数</li>   <li>（上限値に達した場合）使用回数がリセットされる時刻</li> </ul>  <h3 id=\"plan_api_rate_limit\">プラン別のAPI Rate Limit</h3>   <table border=\"1\">     <tbody>       <tr>         <th style=\"padding: 10px\"><strong>会計freeeプラン名</strong></th>         <th style=\"padding: 10px\"><strong>事業所とアプリケーション毎に1日でのAPIコール数</strong></th>       </tr>       <tr>         <td style=\"padding: 10px\">エンタープライズ</td>         <td style=\"padding: 10px\">10,000</td>       </tr>       <tr>         <td style=\"padding: 10px\">プロフェッショナル</td>         <td style=\"padding: 10px\">5,000</td>       </tr>       <tr>         <td style=\"padding: 10px\">ベーシック</td>         <td style=\"padding: 10px\">3,000</td>       </tr>       <tr>         <td style=\"padding: 10px\">ミニマム</td>         <td style=\"padding: 10px\">3,000</td>       </tr>       <tr>         <td style=\"padding: 10px\">上記以外</td>         <td style=\"padding: 10px\">3,000</td>       </tr>     </tbody>   </table>  <h3 id=\"webhook\">Webhookについて</h3>  <p>詳細は<a href=\"https://developer.freee.co.jp/docs/accounting/webhook\" target=\"_blank\">会計Webhook概要</a>を参照してください。</p>  <hr /> <h2 id=\"contact\">連絡先</h2>  <p>ご不明点、ご要望等は <a href=\"https://support.freee.co.jp/hc/ja/requests/new\">freee サポートデスクへのお問い合わせフォーム</a> からご連絡ください。</p> <hr />&copy; Since 2013 freee K.K.
 *
 * The version of the OpenAPI document: v1.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using OpenAPIDateConverter = Freee.Accounting.Client.OpenAPIDateConverter;

namespace Freee.Accounting.Models
{
    /// <summary>
    /// SelectablesIndexResponseAccountCategories
    /// </summary>
    [DataContract]
    public partial class SelectablesIndexResponseAccountCategories :  IEquatable<SelectablesIndexResponseAccountCategories>
    {
        /// <summary>
        /// 収支
        /// </summary>
        /// <value>収支</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum BalanceEnum
        {
            /// <summary>
            /// Enum Expense for value: expense
            /// </summary>
            [EnumMember(Value = "expense")]
            Expense = 1,

            /// <summary>
            /// Enum Income for value: income
            /// </summary>
            [EnumMember(Value = "income")]
            Income = 2

        }

        /// <summary>
        /// 収支
        /// </summary>
        /// <value>収支</value>
        [DataMember(Name="balance", EmitDefaultValue=false)]
        public BalanceEnum Balance { get; set; }
        /// <summary>
        /// 事業形態（個人事業主: personal、法人: corporate）
        /// </summary>
        /// <value>事業形態（個人事業主: personal、法人: corporate）</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OrgCodeEnum
        {
            /// <summary>
            /// Enum Personal for value: personal
            /// </summary>
            [EnumMember(Value = "personal")]
            Personal = 1,

            /// <summary>
            /// Enum Corporate for value: corporate
            /// </summary>
            [EnumMember(Value = "corporate")]
            Corporate = 2

        }

        /// <summary>
        /// 事業形態（個人事業主: personal、法人: corporate）
        /// </summary>
        /// <value>事業形態（個人事業主: personal、法人: corporate）</value>
        [DataMember(Name="org_code", EmitDefaultValue=false)]
        public OrgCodeEnum OrgCode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SelectablesIndexResponseAccountCategories" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SelectablesIndexResponseAccountCategories() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SelectablesIndexResponseAccountCategories" /> class.
        /// </summary>
        /// <param name="accountItems">勘定科目の一覧 (required).</param>
        /// <param name="balance">収支 (required).</param>
        /// <param name="desc">カテゴリーの説明.</param>
        /// <param name="orgCode">事業形態（個人事業主: personal、法人: corporate） (required).</param>
        /// <param name="role">カテゴリーコード (required).</param>
        /// <param name="title">カテゴリー名 (required).</param>
        public SelectablesIndexResponseAccountCategories(List<SelectablesIndexResponseAccountItems> accountItems = default(List<SelectablesIndexResponseAccountItems>), BalanceEnum balance = default(BalanceEnum), string desc = default(string), OrgCodeEnum orgCode = default(OrgCodeEnum), string role = default(string), string title = default(string))
        {
            // to ensure "accountItems" is required (not null)
            this.AccountItems = accountItems ?? throw new ArgumentNullException("accountItems is a required property for SelectablesIndexResponseAccountCategories and cannot be null");
            this.Balance = balance;
            this.OrgCode = orgCode;
            // to ensure "role" is required (not null)
            this.Role = role ?? throw new ArgumentNullException("role is a required property for SelectablesIndexResponseAccountCategories and cannot be null");
            // to ensure "title" is required (not null)
            this.Title = title ?? throw new ArgumentNullException("title is a required property for SelectablesIndexResponseAccountCategories and cannot be null");
            this.Desc = desc;
        }
        
        /// <summary>
        /// 勘定科目の一覧
        /// </summary>
        /// <value>勘定科目の一覧</value>
        [DataMember(Name="account_items", EmitDefaultValue=false)]
        public List<SelectablesIndexResponseAccountItems> AccountItems { get; set; }

        /// <summary>
        /// カテゴリーの説明
        /// </summary>
        /// <value>カテゴリーの説明</value>
        [DataMember(Name="desc", EmitDefaultValue=false)]
        public string Desc { get; set; }

        /// <summary>
        /// カテゴリーコード
        /// </summary>
        /// <value>カテゴリーコード</value>
        [DataMember(Name="role", EmitDefaultValue=false)]
        public string Role { get; set; }

        /// <summary>
        /// カテゴリー名
        /// </summary>
        /// <value>カテゴリー名</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SelectablesIndexResponseAccountCategories {\n");
            sb.Append("  AccountItems: ").Append(AccountItems).Append("\n");
            sb.Append("  Balance: ").Append(Balance).Append("\n");
            sb.Append("  Desc: ").Append(Desc).Append("\n");
            sb.Append("  OrgCode: ").Append(OrgCode).Append("\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
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
            return this.Equals(input as SelectablesIndexResponseAccountCategories);
        }

        /// <summary>
        /// Returns true if SelectablesIndexResponseAccountCategories instances are equal
        /// </summary>
        /// <param name="input">Instance of SelectablesIndexResponseAccountCategories to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SelectablesIndexResponseAccountCategories input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccountItems == input.AccountItems ||
                    this.AccountItems != null &&
                    input.AccountItems != null &&
                    this.AccountItems.SequenceEqual(input.AccountItems)
                ) && 
                (
                    this.Balance == input.Balance ||
                    this.Balance.Equals(input.Balance)
                ) && 
                (
                    this.Desc == input.Desc ||
                    (this.Desc != null &&
                    this.Desc.Equals(input.Desc))
                ) && 
                (
                    this.OrgCode == input.OrgCode ||
                    this.OrgCode.Equals(input.OrgCode)
                ) && 
                (
                    this.Role == input.Role ||
                    (this.Role != null &&
                    this.Role.Equals(input.Role))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
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
                if (this.AccountItems != null)
                    hashCode = hashCode * 59 + this.AccountItems.GetHashCode();
                hashCode = hashCode * 59 + this.Balance.GetHashCode();
                if (this.Desc != null)
                    hashCode = hashCode * 59 + this.Desc.GetHashCode();
                hashCode = hashCode * 59 + this.OrgCode.GetHashCode();
                if (this.Role != null)
                    hashCode = hashCode * 59 + this.Role.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                return hashCode;
            }
        }

    }

}
