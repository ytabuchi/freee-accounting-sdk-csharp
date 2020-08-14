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
    /// InvoiceCreateParamsInvoiceContents
    /// </summary>
    [DataContract]
    public partial class InvoiceCreateParamsInvoiceContents : IEquatable<InvoiceCreateParamsInvoiceContents>
    {
        /// <summary>
        /// 行の種類 &lt;ul&gt; &lt;li&gt;normal、discountを指定する場合、account_item_id,tax_codeとunit_priceが必須となります。&lt;/li&gt; &lt;li&gt;normalを指定した場合、qtyが必須となります。&lt;/li&gt; &lt;/ul&gt;
        /// </summary>
        /// <value>行の種類 &lt;ul&gt; &lt;li&gt;normal、discountを指定する場合、account_item_id,tax_codeとunit_priceが必須となります。&lt;/li&gt; &lt;li&gt;normalを指定した場合、qtyが必須となります。&lt;/li&gt; &lt;/ul&gt;</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Normal for value: normal
            /// </summary>
            [EnumMember(Value = "normal")]
            Normal = 1,

            /// <summary>
            /// Enum Discount for value: discount
            /// </summary>
            [EnumMember(Value = "discount")]
            Discount = 2,

            /// <summary>
            /// Enum Text for value: text
            /// </summary>
            [EnumMember(Value = "text")]
            Text = 3

        }

        /// <summary>
        /// 行の種類 &lt;ul&gt; &lt;li&gt;normal、discountを指定する場合、account_item_id,tax_codeとunit_priceが必須となります。&lt;/li&gt; &lt;li&gt;normalを指定した場合、qtyが必須となります。&lt;/li&gt; &lt;/ul&gt;
        /// </summary>
        /// <value>行の種類 &lt;ul&gt; &lt;li&gt;normal、discountを指定する場合、account_item_id,tax_codeとunit_priceが必須となります。&lt;/li&gt; &lt;li&gt;normalを指定した場合、qtyが必須となります。&lt;/li&gt; &lt;/ul&gt;</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceCreateParamsInvoiceContents" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InvoiceCreateParamsInvoiceContents() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceCreateParamsInvoiceContents" /> class.
        /// </summary>
        /// <param name="accountItemId">勘定科目ID.</param>
        /// <param name="description">備考.</param>
        /// <param name="itemId">品目ID.</param>
        /// <param name="order">順序 (required).</param>
        /// <param name="qty">数量.</param>
        /// <param name="sectionId">部門ID.</param>
        /// <param name="segment1TagId">セグメント１ID.</param>
        /// <param name="segment2TagId">セグメント２ID.</param>
        /// <param name="segment3TagId">セグメント３ID.</param>
        /// <param name="tagIds">tagIds.</param>
        /// <param name="taxCode">税区分ID.</param>
        /// <param name="type">行の種類 &lt;ul&gt; &lt;li&gt;normal、discountを指定する場合、account_item_id,tax_codeとunit_priceが必須となります。&lt;/li&gt; &lt;li&gt;normalを指定した場合、qtyが必須となります。&lt;/li&gt; &lt;/ul&gt; (required).</param>
        /// <param name="unit">単位.</param>
        /// <param name="unitPrice">単価 (tax_entry_method: inclusiveの場合は税込価格、tax_entry_method: exclusiveの場合は税抜価格となります).</param>
        /// <param name="vat">消費税額.</param>
        public InvoiceCreateParamsInvoiceContents(int accountItemId = default(int), string description = default(string), int itemId = default(int), int order = default(int), decimal qty = default(decimal), int sectionId = default(int), int segment1TagId = default(int), int segment2TagId = default(int), int segment3TagId = default(int), List<int> tagIds = default(List<int>), int taxCode = default(int), TypeEnum type = default(TypeEnum), string unit = default(string), decimal unitPrice = default(decimal), int? vat = default(int?))
        {
            this.Order = order;
            this.Type = type;
            this.AccountItemId = accountItemId;
            this.Description = description;
            this.ItemId = itemId;
            this.Qty = qty;
            this.SectionId = sectionId;
            this.Segment1TagId = segment1TagId;
            this.Segment2TagId = segment2TagId;
            this.Segment3TagId = segment3TagId;
            this.TagIds = tagIds;
            this.TaxCode = taxCode;
            this.Unit = unit;
            this.UnitPrice = unitPrice;
            this.Vat = vat;
        }

        /// <summary>
        /// 勘定科目ID
        /// </summary>
        /// <value>勘定科目ID</value>
        [DataMember(Name = "account_item_id", EmitDefaultValue = false)]
        public int AccountItemId { get; set; }

        /// <summary>
        /// 備考
        /// </summary>
        /// <value>備考</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// 品目ID
        /// </summary>
        /// <value>品目ID</value>
        [DataMember(Name = "item_id", EmitDefaultValue = false)]
        public int ItemId { get; set; }

        /// <summary>
        /// 順序
        /// </summary>
        /// <value>順序</value>
        [DataMember(Name = "order", EmitDefaultValue = false)]
        public int Order { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        /// <value>数量</value>
        [DataMember(Name = "qty", EmitDefaultValue = false)]
        public decimal Qty { get; set; }

        /// <summary>
        /// 部門ID
        /// </summary>
        /// <value>部門ID</value>
        [DataMember(Name = "section_id", EmitDefaultValue = false)]
        public int SectionId { get; set; }

        /// <summary>
        /// セグメント１ID
        /// </summary>
        /// <value>セグメント１ID</value>
        [DataMember(Name = "segment_1_tag_id", EmitDefaultValue = false)]
        public int Segment1TagId { get; set; }

        /// <summary>
        /// セグメント２ID
        /// </summary>
        /// <value>セグメント２ID</value>
        [DataMember(Name = "segment_2_tag_id", EmitDefaultValue = false)]
        public int Segment2TagId { get; set; }

        /// <summary>
        /// セグメント３ID
        /// </summary>
        /// <value>セグメント３ID</value>
        [DataMember(Name = "segment_3_tag_id", EmitDefaultValue = false)]
        public int Segment3TagId { get; set; }

        /// <summary>
        /// Gets or Sets TagIds
        /// </summary>
        [DataMember(Name = "tag_ids", EmitDefaultValue = false)]
        public List<int> TagIds { get; set; }

        /// <summary>
        /// 税区分ID
        /// </summary>
        /// <value>税区分ID</value>
        [DataMember(Name = "tax_code", EmitDefaultValue = false)]
        public int TaxCode { get; set; }

        /// <summary>
        /// 単位
        /// </summary>
        /// <value>単位</value>
        [DataMember(Name = "unit", EmitDefaultValue = false)]
        public string Unit { get; set; }

        /// <summary>
        /// 単価 (tax_entry_method: inclusiveの場合は税込価格、tax_entry_method: exclusiveの場合は税抜価格となります)
        /// </summary>
        /// <value>単価 (tax_entry_method: inclusiveの場合は税込価格、tax_entry_method: exclusiveの場合は税抜価格となります)</value>
        [DataMember(Name = "unit_price", EmitDefaultValue = false)]
        public decimal UnitPrice { get; set; }

        /// <summary>
        /// 消費税額
        /// </summary>
        /// <value>消費税額</value>
        [DataMember(Name = "vat", EmitDefaultValue = true)]
        public int? Vat { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InvoiceCreateParamsInvoiceContents {\n");
            sb.Append("  AccountItemId: ").Append(AccountItemId).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ItemId: ").Append(ItemId).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  Qty: ").Append(Qty).Append("\n");
            sb.Append("  SectionId: ").Append(SectionId).Append("\n");
            sb.Append("  Segment1TagId: ").Append(Segment1TagId).Append("\n");
            sb.Append("  Segment2TagId: ").Append(Segment2TagId).Append("\n");
            sb.Append("  Segment3TagId: ").Append(Segment3TagId).Append("\n");
            sb.Append("  TagIds: ").Append(TagIds).Append("\n");
            sb.Append("  TaxCode: ").Append(TaxCode).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Unit: ").Append(Unit).Append("\n");
            sb.Append("  UnitPrice: ").Append(UnitPrice).Append("\n");
            sb.Append("  Vat: ").Append(Vat).Append("\n");
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
            return this.Equals(input as InvoiceCreateParamsInvoiceContents);
        }

        /// <summary>
        /// Returns true if InvoiceCreateParamsInvoiceContents instances are equal
        /// </summary>
        /// <param name="input">Instance of InvoiceCreateParamsInvoiceContents to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InvoiceCreateParamsInvoiceContents input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccountItemId == input.AccountItemId ||
                    this.AccountItemId.Equals(input.AccountItemId)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.ItemId == input.ItemId ||
                    this.ItemId.Equals(input.ItemId)
                ) && 
                (
                    this.Order == input.Order ||
                    this.Order.Equals(input.Order)
                ) && 
                (
                    this.Qty == input.Qty ||
                    this.Qty.Equals(input.Qty)
                ) && 
                (
                    this.SectionId == input.SectionId ||
                    this.SectionId.Equals(input.SectionId)
                ) && 
                (
                    this.Segment1TagId == input.Segment1TagId ||
                    this.Segment1TagId.Equals(input.Segment1TagId)
                ) && 
                (
                    this.Segment2TagId == input.Segment2TagId ||
                    this.Segment2TagId.Equals(input.Segment2TagId)
                ) && 
                (
                    this.Segment3TagId == input.Segment3TagId ||
                    this.Segment3TagId.Equals(input.Segment3TagId)
                ) && 
                (
                    this.TagIds == input.TagIds ||
                    this.TagIds != null &&
                    input.TagIds != null &&
                    this.TagIds.SequenceEqual(input.TagIds)
                ) && 
                (
                    this.TaxCode == input.TaxCode ||
                    this.TaxCode.Equals(input.TaxCode)
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.Unit == input.Unit ||
                    (this.Unit != null &&
                    this.Unit.Equals(input.Unit))
                ) && 
                (
                    this.UnitPrice == input.UnitPrice ||
                    this.UnitPrice.Equals(input.UnitPrice)
                ) && 
                (
                    this.Vat == input.Vat ||
                    (this.Vat != null &&
                    this.Vat.Equals(input.Vat))
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
                hashCode = hashCode * 59 + this.AccountItemId.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                hashCode = hashCode * 59 + this.ItemId.GetHashCode();
                hashCode = hashCode * 59 + this.Order.GetHashCode();
                hashCode = hashCode * 59 + this.Qty.GetHashCode();
                hashCode = hashCode * 59 + this.SectionId.GetHashCode();
                hashCode = hashCode * 59 + this.Segment1TagId.GetHashCode();
                hashCode = hashCode * 59 + this.Segment2TagId.GetHashCode();
                hashCode = hashCode * 59 + this.Segment3TagId.GetHashCode();
                if (this.TagIds != null)
                    hashCode = hashCode * 59 + this.TagIds.GetHashCode();
                hashCode = hashCode * 59 + this.TaxCode.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Unit != null)
                    hashCode = hashCode * 59 + this.Unit.GetHashCode();
                hashCode = hashCode * 59 + this.UnitPrice.GetHashCode();
                if (this.Vat != null)
                    hashCode = hashCode * 59 + this.Vat.GetHashCode();
                return hashCode;
            }
        }

    }

}
