namespace AssetTool
{
    [JsonAsset("InterchangeGenericAssetsPipeline")]
    public class UInterchangeGenericAssetsPipeline : UInterchangePipelineBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}