using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public partial class TextEntityType : Object
        {
            public class TextEntityTypeHashtag : TextEntityType
            {
                [JsonProperty("@type")] public override string DataType { get; set; } = "textEntityTypeHashtag";

                [JsonProperty("@extra")] public override string Extra { get; set; }
            }
        }
    }
}