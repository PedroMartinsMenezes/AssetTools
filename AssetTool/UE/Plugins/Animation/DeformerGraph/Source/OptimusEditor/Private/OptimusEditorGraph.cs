namespace AssetTool
{
    [JsonAsset("OptimusEditorGraph")]
    public class UOptimusEditorGraph : UEdGraph
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}