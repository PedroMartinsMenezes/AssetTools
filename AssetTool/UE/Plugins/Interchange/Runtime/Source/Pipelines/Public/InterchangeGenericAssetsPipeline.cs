namespace AssetTool
{
    [JsonAsset("InterchangeGenericAssetsPipeline")]
    public class UInterchangeGenericAssetsPipeline : UInterchangePipelineBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}