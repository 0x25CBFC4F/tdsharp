using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        /// <summary>
        /// Contains the storage usage statistics for a specific chat
        /// </summary>
        public partial class StorageStatisticsByChat : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "storageStatisticsByChat";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Chat identifier; 0 if none
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("chat_id")]
            public long ChatId { get; set; }

            /// <summary>
            /// Total size of the files in the chat, in bytes
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("size")]
            public long Size { get; set; }

            /// <summary>
            /// Total number of files in the chat
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("count")]
            public int Count { get; set; }

            /// <summary>
            /// Statistics split by file types
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("by_file_type")]
            public StorageStatisticsByFileType[] ByFileType { get; set; }
        }
    }
}