namespace AssetTool
{
    [JsonAsset("OptimusEditorGraphSchema")]
    public class UOptimusEditorGraphSchema : UEdGraphSchema
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}