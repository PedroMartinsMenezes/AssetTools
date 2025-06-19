namespace AssetTool
{
    [JsonAsset("OptimusEditorGraphSchema")]
    public class UOptimusEditorGraphSchema : UEdGraphSchema
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}