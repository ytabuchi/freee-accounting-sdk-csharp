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
    /// CompanyUpdateResponseCompanyFiscalYears
    /// </summary>
    [DataContract]
    public partial class CompanyUpdateResponseCompanyFiscalYears :  IEquatable<CompanyUpdateResponseCompanyFiscalYears>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyUpdateResponseCompanyFiscalYears" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CompanyUpdateResponseCompanyFiscalYears() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyUpdateResponseCompanyFiscalYears" /> class.
        /// </summary>
        /// <param name="accountingPeriod">期.</param>
        /// <param name="depreciationRecordMethod">月次償却（0: しない、1: する） (required).</param>
        /// <param name="endDate">期末日.</param>
        /// <param name="indirectWriteOffMethod">固定資産の控除法（true: 間接控除法、false: 直接控除法） (required).</param>
        /// <param name="indirectWriteOffMethodType">間接控除時の累計額（true: 資産分類別、false: 共通） (required).</param>
        /// <param name="returnCode">不動産所得使用区分（0: 一般、3: 一般/不動産） ※個人事業主のみ設定可能 (required).</param>
        /// <param name="salesTaxBusinessCode">簡易課税用事業区分（0: 第一種：卸売業、1: 第二種：小売業、2: 第三種：農林水産業、工業、建設業、製造業など、3: 第四種：飲食店業など、4: 第五種：金融・保険業、運輸通信業、サービス業など、5: 第六種：不動産業など (required).</param>
        /// <param name="startDate">期首日.</param>
        /// <param name="taxAccountMethod">消費税経理処理方法（0: 税込経理、1: 旧税抜経理、2: 税抜経理） (required).</param>
        /// <param name="taxFraction">消費税端数処理方法（0: 切り捨て、1: 切り上げ、2: 四捨五入） (required).</param>
        /// <param name="taxMethod">課税区分（0: 免税、1: 簡易課税、2: 本則課税（個別対応方式）、3: 本則課税（一括比例配分方式）、4: 本則課税（全額控除）） (required).</param>
        /// <param name="useIndustryTemplate">製造業向け機能（true: 使用する、false: 使用しない） (required).</param>
        public CompanyUpdateResponseCompanyFiscalYears(int accountingPeriod = default(int), int depreciationRecordMethod = default(int), string endDate = default(string), bool indirectWriteOffMethod = default(bool), bool indirectWriteOffMethodType = default(bool), int returnCode = default(int), int salesTaxBusinessCode = default(int), string startDate = default(string), int taxAccountMethod = default(int), int taxFraction = default(int), int taxMethod = default(int), bool useIndustryTemplate = default(bool))
        {
            this.DepreciationRecordMethod = depreciationRecordMethod;
            this.IndirectWriteOffMethod = indirectWriteOffMethod;
            this.IndirectWriteOffMethodType = indirectWriteOffMethodType;
            this.ReturnCode = returnCode;
            this.SalesTaxBusinessCode = salesTaxBusinessCode;
            this.TaxAccountMethod = taxAccountMethod;
            this.TaxFraction = taxFraction;
            this.TaxMethod = taxMethod;
            this.UseIndustryTemplate = useIndustryTemplate;
            this.AccountingPeriod = accountingPeriod;
            this.EndDate = endDate;
            this.StartDate = startDate;
        }
        
        /// <summary>
        /// 期
        /// </summary>
        /// <value>期</value>
        [DataMember(Name="accounting_period", EmitDefaultValue=false)]
        public int AccountingPeriod { get; set; }

        /// <summary>
        /// 月次償却（0: しない、1: する）
        /// </summary>
        /// <value>月次償却（0: しない、1: する）</value>
        [DataMember(Name="depreciation_record_method", EmitDefaultValue=false)]
        public int DepreciationRecordMethod { get; set; }

        /// <summary>
        /// 期末日
        /// </summary>
        /// <value>期末日</value>
        [DataMember(Name="end_date", EmitDefaultValue=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// 固定資産の控除法（true: 間接控除法、false: 直接控除法）
        /// </summary>
        /// <value>固定資産の控除法（true: 間接控除法、false: 直接控除法）</value>
        [DataMember(Name="indirect_write_off_method", EmitDefaultValue=false)]
        public bool IndirectWriteOffMethod { get; set; }

        /// <summary>
        /// 間接控除時の累計額（true: 資産分類別、false: 共通）
        /// </summary>
        /// <value>間接控除時の累計額（true: 資産分類別、false: 共通）</value>
        [DataMember(Name="indirect_write_off_method_type", EmitDefaultValue=false)]
        public bool IndirectWriteOffMethodType { get; set; }

        /// <summary>
        /// 不動産所得使用区分（0: 一般、3: 一般/不動産） ※個人事業主のみ設定可能
        /// </summary>
        /// <value>不動産所得使用区分（0: 一般、3: 一般/不動産） ※個人事業主のみ設定可能</value>
        [DataMember(Name="return_code", EmitDefaultValue=false)]
        public int ReturnCode { get; set; }

        /// <summary>
        /// 簡易課税用事業区分（0: 第一種：卸売業、1: 第二種：小売業、2: 第三種：農林水産業、工業、建設業、製造業など、3: 第四種：飲食店業など、4: 第五種：金融・保険業、運輸通信業、サービス業など、5: 第六種：不動産業など
        /// </summary>
        /// <value>簡易課税用事業区分（0: 第一種：卸売業、1: 第二種：小売業、2: 第三種：農林水産業、工業、建設業、製造業など、3: 第四種：飲食店業など、4: 第五種：金融・保険業、運輸通信業、サービス業など、5: 第六種：不動産業など</value>
        [DataMember(Name="sales_tax_business_code", EmitDefaultValue=false)]
        public int SalesTaxBusinessCode { get; set; }

        /// <summary>
        /// 期首日
        /// </summary>
        /// <value>期首日</value>
        [DataMember(Name="start_date", EmitDefaultValue=false)]
        public string StartDate { get; set; }

        /// <summary>
        /// 消費税経理処理方法（0: 税込経理、1: 旧税抜経理、2: 税抜経理）
        /// </summary>
        /// <value>消費税経理処理方法（0: 税込経理、1: 旧税抜経理、2: 税抜経理）</value>
        [DataMember(Name="tax_account_method", EmitDefaultValue=false)]
        public int TaxAccountMethod { get; set; }

        /// <summary>
        /// 消費税端数処理方法（0: 切り捨て、1: 切り上げ、2: 四捨五入）
        /// </summary>
        /// <value>消費税端数処理方法（0: 切り捨て、1: 切り上げ、2: 四捨五入）</value>
        [DataMember(Name="tax_fraction", EmitDefaultValue=false)]
        public int TaxFraction { get; set; }

        /// <summary>
        /// 課税区分（0: 免税、1: 簡易課税、2: 本則課税（個別対応方式）、3: 本則課税（一括比例配分方式）、4: 本則課税（全額控除））
        /// </summary>
        /// <value>課税区分（0: 免税、1: 簡易課税、2: 本則課税（個別対応方式）、3: 本則課税（一括比例配分方式）、4: 本則課税（全額控除））</value>
        [DataMember(Name="tax_method", EmitDefaultValue=false)]
        public int TaxMethod { get; set; }

        /// <summary>
        /// 製造業向け機能（true: 使用する、false: 使用しない）
        /// </summary>
        /// <value>製造業向け機能（true: 使用する、false: 使用しない）</value>
        [DataMember(Name="use_industry_template", EmitDefaultValue=false)]
        public bool UseIndustryTemplate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CompanyUpdateResponseCompanyFiscalYears {\n");
            sb.Append("  AccountingPeriod: ").Append(AccountingPeriod).Append("\n");
            sb.Append("  DepreciationRecordMethod: ").Append(DepreciationRecordMethod).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  IndirectWriteOffMethod: ").Append(IndirectWriteOffMethod).Append("\n");
            sb.Append("  IndirectWriteOffMethodType: ").Append(IndirectWriteOffMethodType).Append("\n");
            sb.Append("  ReturnCode: ").Append(ReturnCode).Append("\n");
            sb.Append("  SalesTaxBusinessCode: ").Append(SalesTaxBusinessCode).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  TaxAccountMethod: ").Append(TaxAccountMethod).Append("\n");
            sb.Append("  TaxFraction: ").Append(TaxFraction).Append("\n");
            sb.Append("  TaxMethod: ").Append(TaxMethod).Append("\n");
            sb.Append("  UseIndustryTemplate: ").Append(UseIndustryTemplate).Append("\n");
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
            return this.Equals(input as CompanyUpdateResponseCompanyFiscalYears);
        }

        /// <summary>
        /// Returns true if CompanyUpdateResponseCompanyFiscalYears instances are equal
        /// </summary>
        /// <param name="input">Instance of CompanyUpdateResponseCompanyFiscalYears to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CompanyUpdateResponseCompanyFiscalYears input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccountingPeriod == input.AccountingPeriod ||
                    this.AccountingPeriod.Equals(input.AccountingPeriod)
                ) && 
                (
                    this.DepreciationRecordMethod == input.DepreciationRecordMethod ||
                    this.DepreciationRecordMethod.Equals(input.DepreciationRecordMethod)
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.IndirectWriteOffMethod == input.IndirectWriteOffMethod ||
                    this.IndirectWriteOffMethod.Equals(input.IndirectWriteOffMethod)
                ) && 
                (
                    this.IndirectWriteOffMethodType == input.IndirectWriteOffMethodType ||
                    this.IndirectWriteOffMethodType.Equals(input.IndirectWriteOffMethodType)
                ) && 
                (
                    this.ReturnCode == input.ReturnCode ||
                    this.ReturnCode.Equals(input.ReturnCode)
                ) && 
                (
                    this.SalesTaxBusinessCode == input.SalesTaxBusinessCode ||
                    this.SalesTaxBusinessCode.Equals(input.SalesTaxBusinessCode)
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.TaxAccountMethod == input.TaxAccountMethod ||
                    this.TaxAccountMethod.Equals(input.TaxAccountMethod)
                ) && 
                (
                    this.TaxFraction == input.TaxFraction ||
                    this.TaxFraction.Equals(input.TaxFraction)
                ) && 
                (
                    this.TaxMethod == input.TaxMethod ||
                    this.TaxMethod.Equals(input.TaxMethod)
                ) && 
                (
                    this.UseIndustryTemplate == input.UseIndustryTemplate ||
                    this.UseIndustryTemplate.Equals(input.UseIndustryTemplate)
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
                hashCode = hashCode * 59 + this.AccountingPeriod.GetHashCode();
                hashCode = hashCode * 59 + this.DepreciationRecordMethod.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                hashCode = hashCode * 59 + this.IndirectWriteOffMethod.GetHashCode();
                hashCode = hashCode * 59 + this.IndirectWriteOffMethodType.GetHashCode();
                hashCode = hashCode * 59 + this.ReturnCode.GetHashCode();
                hashCode = hashCode * 59 + this.SalesTaxBusinessCode.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                hashCode = hashCode * 59 + this.TaxAccountMethod.GetHashCode();
                hashCode = hashCode * 59 + this.TaxFraction.GetHashCode();
                hashCode = hashCode * 59 + this.TaxMethod.GetHashCode();
                hashCode = hashCode * 59 + this.UseIndustryTemplate.GetHashCode();
                return hashCode;
            }
        }

    }

}
