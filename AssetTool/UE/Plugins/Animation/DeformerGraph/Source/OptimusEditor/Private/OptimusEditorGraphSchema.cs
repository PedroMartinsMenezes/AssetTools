namespace AssetTool
{
    [JsonAsset("OptimusEditorGraphSchema")]
    public class UOptimusEditorGraphSchema : UEdGraphSchema
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}