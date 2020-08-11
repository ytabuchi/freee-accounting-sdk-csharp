/* 
 * freee API
 *
 *  <h1 id=\"freee_api\">freee API</h1> <hr /> <h2 id=\"start_guide\">スタートガイド</h2>  <p>freee API開発がはじめての方は<a href=\"https://developer.freee.co.jp/getting-started\">freee API スタートガイド</a>を参照してください。</p>  <hr /> <h2 id=\"specification\">仕様</h2>  <pre><code>【重要】会計freee APIの新バージョンについて 2020年12月まで、2つのバージョンが利用できる状態です。古いものは2020年12月に利用不可となります。<br> 新しいAPIを利用するにはリクエストヘッダーに以下を指定します。 X-Api-Version: 2020-06-15<br> 指定がない場合は2020年12月に廃止予定のAPIを利用することとなります。<br> 【重要】APIのバージョン指定をせずに利用し続ける場合 2020年12月に新しいバージョンのAPIに自動的に切り替わります。 詳細は、<a href=\"https://developer.freee.co.jp/release-note/2948\" target=\"_blank\">リリースノート</a>をご覧ください。<br> 旧バージョンのAPIリファレンスを確認したい場合は、<a href=\"https://freee.github.io/freee-api-schema/\" target=\"_blank\">旧バージョンのAPIリファレンスページ</a>をご覧ください。 </code></pre>  <h3 id=\"api_endpoint\">APIエンドポイント</h3>  <p>https://api.freee.co.jp/ (httpsのみ)</p>  <h3 id=\"about_authorize\">認証について</h3> <p>OAuth2.0を利用します。詳細は<a href=\"https://developer.freee.co.jp/docs\" target=\"_blank\">ドキュメントの認証</a>パートを参照してください。</p>  <h3 id=\"data_format\">データフォーマット</h3>  <p>リクエスト、レスポンスともにJSON形式をサポートしていますが、詳細は、API毎の説明欄（application/jsonなど）を確認してください。</p>  <h3 id=\"compatibility\">後方互換性ありの変更</h3>  <p>freeeでは、APIを改善していくために以下のような変更は後方互換性ありとして通知なく変更を入れることがあります。アプリケーション実装者は以下を踏まえて開発を行ってください。</p>  <ul> <li>新しいAPIリソース・エンドポイントの追加</li> <li>既存のAPIに対して必須ではない新しいリクエストパラメータの追加</li> <li>既存のAPIレスポンスに対する新しいプロパティの追加</li> <li>既存のAPIレスポンスに対するプロパティの順番の入れ変え</li> <li>keyとなっているidやcodeの長さの変更（長くする）</li> </ul>  <h3 id=\"common_response_header\">共通レスポンスヘッダー</h3>  <p>すべてのAPIのレスポンスには以下のHTTPヘッダーが含まれます。</p>  <ul> <li> <p>X-Freee-Request-ID</p> <ul> <li>各リクエスト毎に発行されるID</li> </ul> </li> </ul>  <h3 id=\"common_error_response\">共通エラーレスポンス</h3>  <ul> <li> <p>ステータスコードはレスポンス内のJSONに含まれる他、HTTPヘッダにも含まれる</p> </li> <li> <p>一部のエラーレスポンスにはエラーコードが含まれます。<br>詳細は、<a href=\"https://developer.freee.co.jp/tips/faq/40x-checkpoint\">HTTPステータスコード400台エラー時のチェックポイント</a>を参照してください</p> </li> <p>type</p>  <ul> <li>status : HTTPステータスコードの説明</li>  <li>validation : エラーの詳細の説明（開発者向け）</li> </ul> </li> </ul>  <p>レスポンスの例</p>  <pre><code>  {     &quot;status_code&quot; : 400,     &quot;errors&quot; : [       {         &quot;type&quot; : &quot;status&quot;,         &quot;messages&quot; : [&quot;不正なリクエストです。&quot;]       },       {         &quot;type&quot; : &quot;validation&quot;,         &quot;messages&quot; : [&quot;Date は不正な日付フォーマットです。入力例：2013-01-01&quot;]       }     ]   }</code></pre>  </br>  <h3 id=\"api_rate_limit\">API使用制限</h3>    <p>freeeは一定期間に過度のアクセスを検知した場合、APIアクセスをコントロールする場合があります。</p>   <p>その際のhttp status codeは403となります。制限がかかってから10分程度が過ぎると再度使用することができるようになります。</p>  <h4 id=\"reports_api_endpoint\">/reportsエンドポイント</h4>  <p>freeeは/reportsエンドポイントに対して1秒間に10以上のアクセスを検知した場合、APIアクセスをコントロールする場合があります。その際のhttp status codeは429（too many requests）となります。</p>  <p>レスポンスボディのmetaプロパティに以下を含めます。</p>  <ul>   <li>設定されている上限値</li>   <li>上限に達するまでの使用可能回数</li>   <li>（上限値に達した場合）使用回数がリセットされる時刻</li> </ul>  <h3 id=\"plan_api_rate_limit\">プラン別のAPI Rate Limit</h3>   <table border=\"1\">     <tbody>       <tr>         <th style=\"padding: 10px\"><strong>会計freeeプラン名</strong></th>         <th style=\"padding: 10px\"><strong>事業所とアプリケーション毎に1日でのAPIコール数</strong></th>       </tr>       <tr>         <td style=\"padding: 10px\">エンタープライズ</td>         <td style=\"padding: 10px\">10,000</td>       </tr>       <tr>         <td style=\"padding: 10px\">プロフェッショナル</td>         <td style=\"padding: 10px\">5,000</td>       </tr>       <tr>         <td style=\"padding: 10px\">ベーシック</td>         <td style=\"padding: 10px\">3,000</td>       </tr>       <tr>         <td style=\"padding: 10px\">ミニマム</td>         <td style=\"padding: 10px\">3,000</td>       </tr>       <tr>         <td style=\"padding: 10px\">上記以外</td>         <td style=\"padding: 10px\">3,000</td>       </tr>     </tbody>   </table>  <hr /> <h2 id=\"contact\">連絡先</h2>  <p>ご不明点、ご要望等は <a href=\"https://support.freee.co.jp/hc/ja/requests/new\">freee サポートデスクへのお問い合わせフォーム</a> からご連絡ください。</p> <hr />&copy; Since 2013 freee K.K.
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
    /// ExpenseApplication
    /// </summary>
    [DataContract]
    public partial class ExpenseApplication :  IEquatable<ExpenseApplication>
    {
        /// <summary>
        /// 取引ステータス (申請ステータス:statusがapprovedで、取引が存在する時のみdeal_statusが表示されます settled:精算済み, unsettled:清算待ち)
        /// </summary>
        /// <value>取引ステータス (申請ステータス:statusがapprovedで、取引が存在する時のみdeal_statusが表示されます settled:精算済み, unsettled:清算待ち)</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DealStatusEnum
        {
            /// <summary>
            /// Enum Settled for value: settled
            /// </summary>
            [EnumMember(Value = "settled")]
            Settled = 1,

            /// <summary>
            /// Enum Unsettled for value: unsettled
            /// </summary>
            [EnumMember(Value = "unsettled")]
            Unsettled = 2

        }

        /// <summary>
        /// 取引ステータス (申請ステータス:statusがapprovedで、取引が存在する時のみdeal_statusが表示されます settled:精算済み, unsettled:清算待ち)
        /// </summary>
        /// <value>取引ステータス (申請ステータス:statusがapprovedで、取引が存在する時のみdeal_statusが表示されます settled:精算済み, unsettled:清算待ち)</value>
        [DataMember(Name="deal_status", EmitDefaultValue=true)]
        public DealStatusEnum DealStatus { get; set; }
        /// <summary>
        /// 申請ステータス(draft:下書き, in_progress:申請中, approved:承認済, rejected:却下, feedback:差戻し)
        /// </summary>
        /// <value>申請ステータス(draft:下書き, in_progress:申請中, approved:承認済, rejected:却下, feedback:差戻し)</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Draft for value: draft
            /// </summary>
            [EnumMember(Value = "draft")]
            Draft = 1,

            /// <summary>
            /// Enum Inprogress for value: in_progress
            /// </summary>
            [EnumMember(Value = "in_progress")]
            Inprogress = 2,

            /// <summary>
            /// Enum Approved for value: approved
            /// </summary>
            [EnumMember(Value = "approved")]
            Approved = 3,

            /// <summary>
            /// Enum Rejected for value: rejected
            /// </summary>
            [EnumMember(Value = "rejected")]
            Rejected = 4,

            /// <summary>
            /// Enum Feedback for value: feedback
            /// </summary>
            [EnumMember(Value = "feedback")]
            Feedback = 5

        }

        /// <summary>
        /// 申請ステータス(draft:下書き, in_progress:申請中, approved:承認済, rejected:却下, feedback:差戻し)
        /// </summary>
        /// <value>申請ステータス(draft:下書き, in_progress:申請中, approved:承認済, rejected:却下, feedback:差戻し)</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExpenseApplication" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ExpenseApplication() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExpenseApplication" /> class.
        /// </summary>
        /// <param name="companyId">事業所ID (required).</param>
        /// <param name="dealId">取引ID (申請ステータス:statusがapprovedで、取引が存在する時のみdeal_idが表示されます) (required).</param>
        /// <param name="dealStatus">取引ステータス (申請ステータス:statusがapprovedで、取引が存在する時のみdeal_statusが表示されます settled:精算済み, unsettled:清算待ち) (required).</param>
        /// <param name="description">備考.</param>
        /// <param name="editableOnWeb">会計freeeのWeb画面から申請内容を編集可能：falseの場合、Web上からの項目行の追加／削除・金額の編集が出来なくなります。APIでの編集は可能です。 (required).</param>
        /// <param name="expenseApplicationLines">経費申請の項目行一覧（配列） (required).</param>
        /// <param name="id">経費申請ID (required).</param>
        /// <param name="issueDate">申請日 (yyyy-mm-dd) (required).</param>
        /// <param name="sectionId">部門ID.</param>
        /// <param name="status">申請ステータス(draft:下書き, in_progress:申請中, approved:承認済, rejected:却下, feedback:差戻し) (required).</param>
        /// <param name="tagIds">メモタグID.</param>
        /// <param name="title">申請タイトル (required).</param>
        /// <param name="totalAmount">合計金額.</param>
        public ExpenseApplication(int companyId = default(int), int? dealId = default(int?), DealStatusEnum dealStatus = default(DealStatusEnum), string description = default(string), bool editableOnWeb = default(bool), List<ExpenseApplicationExpenseApplicationLines> expenseApplicationLines = default(List<ExpenseApplicationExpenseApplicationLines>), int id = default(int), string issueDate = default(string), int? sectionId = default(int?), StatusEnum status = default(StatusEnum), List<int> tagIds = default(List<int>), string title = default(string), int totalAmount = default(int))
        {
            this.CompanyId = companyId;
            // to ensure "dealId" is required (not null)
            this.DealId = dealId ?? throw new ArgumentNullException("dealId is a required property for ExpenseApplication and cannot be null");
            this.DealStatus = dealStatus;
            this.EditableOnWeb = editableOnWeb;
            // to ensure "expenseApplicationLines" is required (not null)
            this.ExpenseApplicationLines = expenseApplicationLines ?? throw new ArgumentNullException("expenseApplicationLines is a required property for ExpenseApplication and cannot be null");
            this.Id = id;
            // to ensure "issueDate" is required (not null)
            this.IssueDate = issueDate ?? throw new ArgumentNullException("issueDate is a required property for ExpenseApplication and cannot be null");
            this.Status = status;
            // to ensure "title" is required (not null)
            this.Title = title ?? throw new ArgumentNullException("title is a required property for ExpenseApplication and cannot be null");
            this.Description = description;
            this.SectionId = sectionId;
            this.TagIds = tagIds;
            this.TotalAmount = totalAmount;
        }
        
        /// <summary>
        /// 事業所ID
        /// </summary>
        /// <value>事業所ID</value>
        [DataMember(Name="company_id", EmitDefaultValue=false)]
        public int CompanyId { get; set; }

        /// <summary>
        /// 取引ID (申請ステータス:statusがapprovedで、取引が存在する時のみdeal_idが表示されます)
        /// </summary>
        /// <value>取引ID (申請ステータス:statusがapprovedで、取引が存在する時のみdeal_idが表示されます)</value>
        [DataMember(Name="deal_id", EmitDefaultValue=true)]
        public int? DealId { get; set; }

        /// <summary>
        /// 備考
        /// </summary>
        /// <value>備考</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// 会計freeeのWeb画面から申請内容を編集可能：falseの場合、Web上からの項目行の追加／削除・金額の編集が出来なくなります。APIでの編集は可能です。
        /// </summary>
        /// <value>会計freeeのWeb画面から申請内容を編集可能：falseの場合、Web上からの項目行の追加／削除・金額の編集が出来なくなります。APIでの編集は可能です。</value>
        [DataMember(Name="editable_on_web", EmitDefaultValue=false)]
        public bool EditableOnWeb { get; set; }

        /// <summary>
        /// 経費申請の項目行一覧（配列）
        /// </summary>
        /// <value>経費申請の項目行一覧（配列）</value>
        [DataMember(Name="expense_application_lines", EmitDefaultValue=false)]
        public List<ExpenseApplicationExpenseApplicationLines> ExpenseApplicationLines { get; set; }

        /// <summary>
        /// 経費申請ID
        /// </summary>
        /// <value>経費申請ID</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int Id { get; set; }

        /// <summary>
        /// 申請日 (yyyy-mm-dd)
        /// </summary>
        /// <value>申請日 (yyyy-mm-dd)</value>
        [DataMember(Name="issue_date", EmitDefaultValue=true)]
        public string IssueDate { get; set; }

        /// <summary>
        /// 部門ID
        /// </summary>
        /// <value>部門ID</value>
        [DataMember(Name="section_id", EmitDefaultValue=true)]
        public int? SectionId { get; set; }

        /// <summary>
        /// メモタグID
        /// </summary>
        /// <value>メモタグID</value>
        [DataMember(Name="tag_ids", EmitDefaultValue=false)]
        public List<int> TagIds { get; set; }

        /// <summary>
        /// 申請タイトル
        /// </summary>
        /// <value>申請タイトル</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// 合計金額
        /// </summary>
        /// <value>合計金額</value>
        [DataMember(Name="total_amount", EmitDefaultValue=false)]
        public int TotalAmount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExpenseApplication {\n");
            sb.Append("  CompanyId: ").Append(CompanyId).Append("\n");
            sb.Append("  DealId: ").Append(DealId).Append("\n");
            sb.Append("  DealStatus: ").Append(DealStatus).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  EditableOnWeb: ").Append(EditableOnWeb).Append("\n");
            sb.Append("  ExpenseApplicationLines: ").Append(ExpenseApplicationLines).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IssueDate: ").Append(IssueDate).Append("\n");
            sb.Append("  SectionId: ").Append(SectionId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  TagIds: ").Append(TagIds).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  TotalAmount: ").Append(TotalAmount).Append("\n");
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
            return this.Equals(input as ExpenseApplication);
        }

        /// <summary>
        /// Returns true if ExpenseApplication instances are equal
        /// </summary>
        /// <param name="input">Instance of ExpenseApplication to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExpenseApplication input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CompanyId == input.CompanyId ||
                    this.CompanyId.Equals(input.CompanyId)
                ) && 
                (
                    this.DealId == input.DealId ||
                    (this.DealId != null &&
                    this.DealId.Equals(input.DealId))
                ) && 
                (
                    this.DealStatus == input.DealStatus ||
                    this.DealStatus.Equals(input.DealStatus)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.EditableOnWeb == input.EditableOnWeb ||
                    this.EditableOnWeb.Equals(input.EditableOnWeb)
                ) && 
                (
                    this.ExpenseApplicationLines == input.ExpenseApplicationLines ||
                    this.ExpenseApplicationLines != null &&
                    input.ExpenseApplicationLines != null &&
                    this.ExpenseApplicationLines.SequenceEqual(input.ExpenseApplicationLines)
                ) && 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.IssueDate == input.IssueDate ||
                    (this.IssueDate != null &&
                    this.IssueDate.Equals(input.IssueDate))
                ) && 
                (
                    this.SectionId == input.SectionId ||
                    (this.SectionId != null &&
                    this.SectionId.Equals(input.SectionId))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.TagIds == input.TagIds ||
                    this.TagIds != null &&
                    input.TagIds != null &&
                    this.TagIds.SequenceEqual(input.TagIds)
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.TotalAmount == input.TotalAmount ||
                    this.TotalAmount.Equals(input.TotalAmount)
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
                hashCode = hashCode * 59 + this.CompanyId.GetHashCode();
                if (this.DealId != null)
                    hashCode = hashCode * 59 + this.DealId.GetHashCode();
                hashCode = hashCode * 59 + this.DealStatus.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                hashCode = hashCode * 59 + this.EditableOnWeb.GetHashCode();
                if (this.ExpenseApplicationLines != null)
                    hashCode = hashCode * 59 + this.ExpenseApplicationLines.GetHashCode();
                hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.IssueDate != null)
                    hashCode = hashCode * 59 + this.IssueDate.GetHashCode();
                if (this.SectionId != null)
                    hashCode = hashCode * 59 + this.SectionId.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.TagIds != null)
                    hashCode = hashCode * 59 + this.TagIds.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                hashCode = hashCode * 59 + this.TotalAmount.GetHashCode();
                return hashCode;
            }
        }

    }

}
