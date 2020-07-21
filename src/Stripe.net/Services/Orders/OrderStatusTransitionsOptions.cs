namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class OrderStatusTransitionsOptions : INestedOptions
    {
        [JsonProperty("canceled")]
        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<DateTime?, DateRangeOptions> Canceled { get; set; }

        [JsonProperty("fulfilled")]
        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<DateTime?, DateRangeOptions> Fulfilled { get; set; }

        [JsonProperty("paid")]
        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<DateTime?, DateRangeOptions> Paid { get; set; }

        [JsonProperty("returned")]
        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<DateTime?, DateRangeOptions> Returned { get; set; }
    }
}
