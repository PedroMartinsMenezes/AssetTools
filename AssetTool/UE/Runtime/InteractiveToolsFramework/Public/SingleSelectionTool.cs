namespace AssetTool
{
    [JsonAsset("SingleSelectionTool")]
    public class USingleSelectionTool : UInteractiveTool
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}