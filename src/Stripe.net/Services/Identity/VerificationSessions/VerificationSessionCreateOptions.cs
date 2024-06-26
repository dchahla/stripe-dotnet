// File generated from our OpenAPI spec
namespace Stripe.Identity
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class VerificationSessionCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// A string to reference this user. This can be a customer ID, a session ID, or similar,
        /// and can be used to reconcile this verification with your internal systems.
        /// </summary>
        [JsonProperty("client_reference_id")]
        public string ClientReferenceId { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// A set of options for the session’s verification checks.
        /// </summary>
        [JsonProperty("options")]
        public VerificationSessionOptionsOptions Options { get; set; }

        /// <summary>
        /// Details provided about the user being verified. These details may be shown to the user.
        /// </summary>
        [JsonProperty("provided_details")]
        public VerificationSessionProvidedDetailsOptions ProvidedDetails { get; set; }

        /// <summary>
        /// The URL that the user will be redirected to upon completing the verification flow.
        /// </summary>
        [JsonProperty("return_url")]
        public string ReturnUrl { get; set; }

        /// <summary>
        /// The type of <a href="https://stripe.com/docs/identity/verification-checks">verification
        /// check</a> to be performed.
        /// One of: <c>document</c>, or <c>id_number</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// The ID of a Verification Flow from the Dashboard.
        /// </summary>
        [JsonProperty("verification_flow")]
        public string VerificationFlow { get; set; }
    }
}
