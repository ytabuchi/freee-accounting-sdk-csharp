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
    /// ApprovalFlowRoutesIndexResponseApprovalFlowRoutes
    /// </summary>
    [DataContract]
    public partial class ApprovalFlowRoutesIndexResponseApprovalFlowRoutes :  IEquatable<ApprovalFlowRoutesIndexResponseApprovalFlowRoutes>
    {
        /// <summary>
        /// Defines Usages
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum UsagesEnum
        {
            /// <summary>
            /// Enum TxnApproval for value: TxnApproval
            /// </summary>
            [EnumMember(Value = "TxnApproval")]
            TxnApproval = 1,

            /// <summary>
            /// Enum ExpenseApplication for value: ExpenseApplication
            /// </summary>
            [EnumMember(Value = "ExpenseApplication")]
            ExpenseApplication = 2,

            /// <summary>
            /// Enum PaymentRequest for value: PaymentRequest
            /// </summary>
            [EnumMember(Value = "PaymentRequest")]
            PaymentRequest = 3,

            /// <summary>
            /// Enum ApprovalRequest for value: ApprovalRequest
            /// </summary>
            [EnumMember(Value = "ApprovalRequest")]
            ApprovalRequest = 4,

            /// <summary>
            /// Enum DocApproval for value: DocApproval
            /// </summary>
            [EnumMember(Value = "DocApproval")]
            DocApproval = 5

        }


        /// <summary>
        /// 申請種別（申請経路を使用できる申請種別を示します。例えば、ApprovalRequest の場合は、各種申請で使用できる申請経路です。） * &#x60;TxnApproval&#x60; - 仕訳承認 * &#x60;ExpenseApplication&#x60; - 経費精算 * &#x60;PaymentRequest&#x60; - 支払依頼 * &#x60;ApprovalRequest&#x60; - 各種申請 * &#x60;DocApproval&#x60; - 請求書等 (見積書・納品書・請求書・発注書)
        /// </summary>
        /// <value>申請種別（申請経路を使用できる申請種別を示します。例えば、ApprovalRequest の場合は、各種申請で使用できる申請経路です。） * &#x60;TxnApproval&#x60; - 仕訳承認 * &#x60;ExpenseApplication&#x60; - 経費精算 * &#x60;PaymentRequest&#x60; - 支払依頼 * &#x60;ApprovalRequest&#x60; - 各種申請 * &#x60;DocApproval&#x60; - 請求書等 (見積書・納品書・請求書・発注書)</value>
        [DataMember(Name="usages", EmitDefaultValue=false)]
        public List<UsagesEnum> Usages { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ApprovalFlowRoutesIndexResponseApprovalFlowRoutes" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ApprovalFlowRoutesIndexResponseApprovalFlowRoutes() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ApprovalFlowRoutesIndexResponseApprovalFlowRoutes" /> class.
        /// </summary>
        /// <param name="definitionSystem">システム作成の申請経路かどうか.</param>
        /// <param name="description">申請経路の説明.</param>
        /// <param name="firstStepId">最初の承認ステップのID.</param>
        /// <param name="id">申請経路ID (required).</param>
        /// <param name="name">申請経路名.</param>
        /// <param name="requestFormIds">申請経路で利用できる申請フォームID配列.</param>
        /// <param name="usages">申請種別（申請経路を使用できる申請種別を示します。例えば、ApprovalRequest の場合は、各種申請で使用できる申請経路です。） * &#x60;TxnApproval&#x60; - 仕訳承認 * &#x60;ExpenseApplication&#x60; - 経費精算 * &#x60;PaymentRequest&#x60; - 支払依頼 * &#x60;ApprovalRequest&#x60; - 各種申請 * &#x60;DocApproval&#x60; - 請求書等 (見積書・納品書・請求書・発注書).</param>
        /// <param name="userId">更新したユーザーのユーザーID.</param>
        public ApprovalFlowRoutesIndexResponseApprovalFlowRoutes(bool definitionSystem = default(bool), string description = default(string), int firstStepId = default(int), int id = default(int), string name = default(string), List<int> requestFormIds = default(List<int>), List<UsagesEnum> usages = default(List<UsagesEnum>), int? userId = default(int?))
        {
            this.Id = id;
            this.DefinitionSystem = definitionSystem;
            this.Description = description;
            this.FirstStepId = firstStepId;
            this.Name = name;
            this.RequestFormIds = requestFormIds;
            this.Usages = usages;
            this.UserId = userId;
        }
        
        /// <summary>
        /// システム作成の申請経路かどうか
        /// </summary>
        /// <value>システム作成の申請経路かどうか</value>
        [DataMember(Name="definition_system", EmitDefaultValue=false)]
        public bool DefinitionSystem { get; set; }

        /// <summary>
        /// 申請経路の説明
        /// </summary>
        /// <value>申請経路の説明</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// 最初の承認ステップのID
        /// </summary>
        /// <value>最初の承認ステップのID</value>
        [DataMember(Name="first_step_id", EmitDefaultValue=false)]
        public int FirstStepId { get; set; }

        /// <summary>
        /// 申請経路ID
        /// </summary>
        /// <value>申請経路ID</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int Id { get; set; }

        /// <summary>
        /// 申請経路名
        /// </summary>
        /// <value>申請経路名</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// 申請経路で利用できる申請フォームID配列
        /// </summary>
        /// <value>申請経路で利用できる申請フォームID配列</value>
        [DataMember(Name="request_form_ids", EmitDefaultValue=false)]
        public List<int> RequestFormIds { get; set; }

        /// <summary>
        /// 更新したユーザーのユーザーID
        /// </summary>
        /// <value>更新したユーザーのユーザーID</value>
        [DataMember(Name="user_id", EmitDefaultValue=true)]
        public int? UserId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApprovalFlowRoutesIndexResponseApprovalFlowRoutes {\n");
            sb.Append("  DefinitionSystem: ").Append(DefinitionSystem).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  FirstStepId: ").Append(FirstStepId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  RequestFormIds: ").Append(RequestFormIds).Append("\n");
            sb.Append("  Usages: ").Append(Usages).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
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
            return this.Equals(input as ApprovalFlowRoutesIndexResponseApprovalFlowRoutes);
        }

        /// <summary>
        /// Returns true if ApprovalFlowRoutesIndexResponseApprovalFlowRoutes instances are equal
        /// </summary>
        /// <param name="input">Instance of ApprovalFlowRoutesIndexResponseApprovalFlowRoutes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApprovalFlowRoutesIndexResponseApprovalFlowRoutes input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DefinitionSystem == input.DefinitionSystem ||
                    this.DefinitionSystem.Equals(input.DefinitionSystem)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.FirstStepId == input.FirstStepId ||
                    this.FirstStepId.Equals(input.FirstStepId)
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
                    this.RequestFormIds == input.RequestFormIds ||
                    this.RequestFormIds != null &&
                    input.RequestFormIds != null &&
                    this.RequestFormIds.SequenceEqual(input.RequestFormIds)
                ) && 
                (
                    this.Usages == input.Usages ||
                    this.Usages.SequenceEqual(input.Usages)
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
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
                hashCode = hashCode * 59 + this.DefinitionSystem.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                hashCode = hashCode * 59 + this.FirstStepId.GetHashCode();
                hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.RequestFormIds != null)
                    hashCode = hashCode * 59 + this.RequestFormIds.GetHashCode();
                hashCode = hashCode * 59 + this.Usages.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                return hashCode;
            }
        }

    }

}
