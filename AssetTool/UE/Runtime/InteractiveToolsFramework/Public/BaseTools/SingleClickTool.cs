namespace AssetTool
{
    [JsonAsset("SingleClickToolBuilder")]
    public class USingleClickToolBuilder : UInteractiveToolBuilder
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SingleClickTool")]
    public class USingleClickTool : UInteractiveTool
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}