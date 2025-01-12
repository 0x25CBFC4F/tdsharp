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
        /// Returns pending join requests in a chat
        /// </summary>
        public class GetChatJoinRequests : Function<ChatJoinRequests>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "getChatJoinRequests";

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

            /// <summary>
            /// Invite link for which to return join requests. If empty, all join requests will be returned. Requires administrator privileges and can_invite_users right in the chat for own links and owner privileges for other links
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("invite_link")]
            public string InviteLink { get; set; }

            /// <summary>
            /// A query to search for in the first names, last names and usernames of the users to return
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("query")]
            public string Query { get; set; }

            /// <summary>
            /// A chat join request from which to return next requests; pass null to get results from the beginning
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("offset_request")]
            public ChatJoinRequest OffsetRequest { get; set; }

            /// <summary>
            /// The maximum number of chat join requests to return
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("limit")]
            public int Limit { get; set; }
        }

        /// <summary>
        /// Returns pending join requests in a chat
        /// </summary>
        public static Task<ChatJoinRequests> GetChatJoinRequestsAsync(
            this Client client, long chatId = default, string inviteLink = default, string query = default,
            ChatJoinRequest offsetRequest = default, int limit = default)
        {
            return client.ExecuteAsync(new GetChatJoinRequests
            {
                ChatId = chatId, InviteLink = inviteLink, Query = query, OffsetRequest = offsetRequest, Limit = limit
            });
        }
    }
}