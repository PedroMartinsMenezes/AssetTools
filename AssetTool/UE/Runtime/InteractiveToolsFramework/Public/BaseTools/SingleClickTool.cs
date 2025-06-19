namespace AssetTool
{
    [JsonAsset("SingleClickToolBuilder")]
    public class USingleClickToolBuilder : UInteractiveToolBuilder
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SingleClickTool")]
    public class USingleClickTool : UInteractiveTool
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}