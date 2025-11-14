namespace AssetTool
{
    [JsonAsset("MetasoundEditorGraphSchema")]
    public class UMetasoundEditorGraphSchema : UEdGraphSchema
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}