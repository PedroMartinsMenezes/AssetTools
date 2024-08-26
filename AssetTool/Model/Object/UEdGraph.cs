using System.ComponentModel;

namespace AssetTool
{
    [Description("void UEdGraph::Serialize(FStructuredArchiveRecord Record)")]
    [JsonAsset]
    public class UEdGraph : UObject
    {
        public const string TypeName = "EdGraph";
    }
}
