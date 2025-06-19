namespace AssetTool
{
    [JsonAsset("InteractiveToolBuilder")]
    public class UInteractiveToolBuilder : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("InteractiveToolWithToolTargetsBuilder")]
    public class UInteractiveToolWithToolTargetsBuilder : UInteractiveToolBuilder
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}