namespace AssetTool
{
    [JsonAsset("MetasoundEditorGraphBase")]
    public class UMetasoundEditorGraphBase : UEdGraph
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetaSoundPatch")]
    public class UMetaSoundPatch : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}