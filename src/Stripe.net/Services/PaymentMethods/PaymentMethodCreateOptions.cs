namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class PaymentMethodCreateOptions : BaseOptions, IHasMetadata
    {
        [JsonProperty("au_becs_debit")]
        public PaymentMethodAuBecsDebitOptions AuBecsDebit { get; set; }

        [JsonProperty("bacs_debit")]
        public PaymentMethodBacsDebitOptions BacsDebit { get; set; }

        [JsonProperty("bancontact")]
        public PaymentMethodBancontactOptions Bancontact { get; set; }

        [JsonProperty("billing_details")]
        public BillingDetailsOptions BillingDetails { get; set; }

        [JsonProperty("card")]
        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<PaymentMethodCard1Options, PaymentMethodCard2Options> Card { get; set; }

        [JsonProperty("customer")]
        public string Customer { get; set; }

        [JsonProperty("eps")]
        public PaymentMethodEpsOptions Eps { get; set; }

        [JsonProperty("fpx")]
        public PaymentMethodFpxOptions Fpx { get; set; }

        [JsonProperty("giropay")]
        public PaymentMethodGiropayOptions Giropay { get; set; }

        [JsonProperty("ideal")]
        public PaymentMethodIdealOptions Ideal { get; set; }

        [JsonProperty("interac_present")]
        public PaymentMethodInteracPresentOptions InteracPresent { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("p24")]
        public PaymentMethodP24Options P24 { get; set; }

        [JsonProperty("payment_method")]
        public string PaymentMethod { get; set; }

        [JsonProperty("sepa_debit")]
        public PaymentMethodSepaDebitOptions SepaDebit { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
