namespace AssetTool
{
    [JsonAsset("InterchangePipelineStackOverride")]
    public class UInterchangePipelineStackOverride : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("InterchangeManager")]
    public class UInterchangeManager : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}