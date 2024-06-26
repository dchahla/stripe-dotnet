// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountController : StripeEntity<AccountController>
    {
        [JsonProperty("fees")]
        public AccountControllerFees Fees { get; set; }

        /// <summary>
        /// <c>true</c> if the Connect application retrieving the resource controls the account and
        /// can therefore exercise <a
        /// href="https://stripe.com/docs/connect/platform-controls-for-standard-accounts">platform
        /// controls</a>. Otherwise, this field is null.
        /// </summary>
        [JsonProperty("is_controller")]
        public bool IsController { get; set; }

        [JsonProperty("losses")]
        public AccountControllerLosses Losses { get; set; }

        /// <summary>
        /// A value indicating responsibility for collecting requirements on this account. Only
        /// returned when the Connect application retrieving the resource controls the account.
        /// One of: <c>application</c>, or <c>stripe</c>.
        /// </summary>
        [JsonProperty("requirement_collection")]
        public string RequirementCollection { get; set; }

        [JsonProperty("stripe_dashboard")]
        public AccountControllerStripeDashboard StripeDashboard { get; set; }

        /// <summary>
        /// The controller type. Can be <c>application</c>, if a Connect application controls the
        /// account, or <c>account</c>, if the account controls itself.
        /// One of: <c>account</c>, or <c>application</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
