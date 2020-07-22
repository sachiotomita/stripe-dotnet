namespace Stripe
{
    using Newtonsoft.Json;

    public class ChargePaymentMethodDetails : StripeEntity<ChargePaymentMethodDetails>
    {
        [JsonProperty("ach_credit_transfer")]
        public ChargePaymentMethodDetailsAchCreditTransfer AchCreditTransfer { get; set; }

        [JsonProperty("ach_debit")]
        public ChargePaymentMethodDetailsAchDebit AchDebit { get; set; }

        [JsonProperty("acss_debit")]
        public ChargePaymentMethodDetailsAcssDebit AcssDebit { get; set; }

        [JsonProperty("alipay")]
        public ChargePaymentMethodDetailsAlipay Alipay { get; set; }

        [JsonProperty("au_becs_debit")]
        public ChargePaymentMethodDetailsAuBecsDebit AuBecsDebit { get; set; }

        [JsonProperty("bacs_debit")]
        public ChargePaymentMethodDetailsBacsDebit BacsDebit { get; set; }

        [JsonProperty("bancontact")]
        public ChargePaymentMethodDetailsBancontact Bancontact { get; set; }

        [JsonProperty("card")]
        public ChargePaymentMethodDetailsCard Card { get; set; }

        [JsonProperty("card_present")]
        public ChargePaymentMethodDetailsCardPresent CardPresent { get; set; }

        [JsonProperty("eps")]
        public ChargePaymentMethodDetailsEps Eps { get; set; }

        [JsonProperty("fpx")]
        public ChargePaymentMethodDetailsFpx Fpx { get; set; }

        [JsonProperty("giropay")]
        public ChargePaymentMethodDetailsGiropay Giropay { get; set; }

        [JsonProperty("ideal")]
        public ChargePaymentMethodDetailsIdeal Ideal { get; set; }

        [JsonProperty("interac_present")]
        public ChargePaymentMethodDetailsInteracPresent InteracPresent { get; set; }

        [JsonProperty("klarna")]
        public ChargePaymentMethodDetailsKlarna Klarna { get; set; }

        [JsonProperty("multibanco")]
        public ChargePaymentMethodDetailsMultibanco Multibanco { get; set; }

        [JsonProperty("p24")]
        public ChargePaymentMethodDetailsP24 P24 { get; set; }

        [JsonProperty("sepa_debit")]
        public ChargePaymentMethodDetailsSepaDebit SepaDebit { get; set; }

        [JsonProperty("stripe_account")]
        public ChargePaymentMethodDetailsStripeAccount StripeAccount { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("wechat")]
        public ChargePaymentMethodDetailsWechat Wechat { get; set; }
    }
}
