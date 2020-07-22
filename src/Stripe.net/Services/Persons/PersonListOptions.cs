namespace Stripe
{
    using Newtonsoft.Json;

    public class PersonListOptions : ListOptions
    {
        [JsonProperty("relationship")]
        public PersonRelationshipOptions Relationship { get; set; }
    }
}
