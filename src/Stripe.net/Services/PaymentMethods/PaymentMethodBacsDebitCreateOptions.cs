namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentMethodBacsDebitCreateOptions : INestedOptions
    {
        [JsonProperty("account_number")]
        public string AccountNumber { get; set; }

        [JsonProperty("sort_code")]
        public string SortCode { get; set; }
    }
}
