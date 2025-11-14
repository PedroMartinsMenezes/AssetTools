namespace AssetTool
{
    [JsonAsset("SingleClickToolBuilder")]
    public class USingleClickToolBuilder : UInteractiveToolBuilder
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SingleClickTool")]
    public class USingleClickTool : UInteractiveTool
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}