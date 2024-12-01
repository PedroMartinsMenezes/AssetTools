namespace AssetTool
{
    [JsonAsset("MetasoundEditorGraphBase")]
    public class UMetasoundEditorGraphBase : UEdGraph
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetaSoundPatch")]
    public class UMetaSoundPatch : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}