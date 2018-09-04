using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public partial class InputMessageContent : Object
        {
            public class InputMessageText : InputMessageContent
            {
                [JsonProperty("@type")] public override string DataType { get; set; } = "inputMessageText";

                [JsonProperty("@extra")] public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("text")]
                public FormattedText Text { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("disable_web_page_preview")]
                public bool DisableWebPagePreview { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("clear_draft")]
                public bool ClearDraft { get; set; }
            }
        }
    }
}