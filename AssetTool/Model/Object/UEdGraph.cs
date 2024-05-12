using System.ComponentModel;

namespace AssetTool
{
    [Description("void UEdGraph::Serialize(FStructuredArchiveRecord Record)")]
    public class UEdGraph : UObject
    {
        public const string TypeName = "EdGraph";

        public UEdGraph Read(BinaryReader reader)
        {
            base.Move(GlobalObjects.Transfer);
            return this;
        }
        public void Write(BinaryWriter writer)
        {
            base.Move(GlobalObjects.Transfer);
        }
    }
}
