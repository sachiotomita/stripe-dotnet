namespace Stripe
{
    using Newtonsoft.Json;

    public class SubscriptionScheduleDefaultSettingsOptions : INestedOptions
    {
        [JsonProperty("billing_cycle_anchor")]
        public string BillingCycleAnchor { get; set; }

        [JsonProperty("billing_thresholds")]
        public SubscriptionBillingThresholdsOptions BillingThresholds { get; set; }

        [JsonProperty("collection_method")]
        public string CollectionMethod { get; set; }

        [JsonProperty("default_payment_method")]
        public string DefaultPaymentMethod { get; set; }

        [JsonProperty("invoice_settings")]
        public SubscriptionScheduleInvoiceSettingsOptions InvoiceSettings { get; set; }

        [JsonProperty("transfer_data")]
        public SubscriptionTransferDataOptions TransferData { get; set; }
    }
}
