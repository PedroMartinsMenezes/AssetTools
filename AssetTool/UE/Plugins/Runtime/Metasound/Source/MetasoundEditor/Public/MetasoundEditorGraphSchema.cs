namespace AssetTool
{
    [JsonAsset("MetasoundEditorGraphSchema")]
    public class UMetasoundEditorGraphSchema : UEdGraphSchema
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}