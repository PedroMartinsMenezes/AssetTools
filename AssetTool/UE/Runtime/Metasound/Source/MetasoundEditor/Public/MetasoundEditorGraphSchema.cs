namespace AssetTool
{
    [JsonAsset("MetasoundEditorGraphSchema")]
    public class UMetasoundEditorGraphSchema : UEdGraphSchema
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}