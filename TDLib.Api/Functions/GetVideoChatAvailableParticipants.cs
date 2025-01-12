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
        /// Returns list of participant identifiers, which can be used to join video chats in a chat
        /// </summary>
        public class GetVideoChatAvailableParticipants : Function<MessageSenders>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "getVideoChatAvailableParticipants";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Chat identifier
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("chat_id")]
            public long ChatId { get; set; }
        }

        /// <summary>
        /// Returns list of participant identifiers, which can be used to join video chats in a chat
        /// </summary>
        public static Task<MessageSenders> GetVideoChatAvailableParticipantsAsync(
            this Client client, long chatId = default)
        {
            return client.ExecuteAsync(new GetVideoChatAvailableParticipants
            {
                ChatId = chatId
            });
        }
    }
}