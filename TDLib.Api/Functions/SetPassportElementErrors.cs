using System;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        /// <summary>
        /// Informs the user that some of the elements in their Telegram Passport contain errors; for bots only. The user will not be able to resend the elements, until the errors are fixed
        /// </summary>
        public class SetPassportElementErrors : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "setPassportElementErrors";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// User identifier
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("user_id")]
            public long UserId { get; set; }

            /// <summary>
            /// The errors
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("errors")]
            public InputPassportElementError[] Errors { get; set; }
        }

        /// <summary>
        /// Informs the user that some of the elements in their Telegram Passport contain errors; for bots only. The user will not be able to resend the elements, until the errors are fixed
        /// </summary>
        public static Task<Ok> SetPassportElementErrorsAsync(
            this Client client, long userId = default, InputPassportElementError[] errors = default)
        {
            return client.ExecuteAsync(new SetPassportElementErrors
            {
                UserId = userId, Errors = errors
            });
        }
    }
}