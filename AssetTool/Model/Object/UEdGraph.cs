using System.ComponentModel;

namespace AssetTool
{
    [Description("void UEdGraph::Serialize(FStructuredArchiveRecord Record)")]
    public class UEdGraph : UObject
    {
        public const string TypeName = "EdGraph";

        public new UEdGraph Move(Transfer transfer) => (UEdGraph)base.Move(transfer);
    }
}
