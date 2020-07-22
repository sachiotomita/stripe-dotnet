namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class ExternalAccountCreateOptions : BaseOptions, IHasMetadata
    {
        [JsonProperty("default_for_currency")]
        public bool? DefaultForCurrency { get; set; }

        [JsonProperty("external_account")]
        public string ExternalAccount { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
    }
}
