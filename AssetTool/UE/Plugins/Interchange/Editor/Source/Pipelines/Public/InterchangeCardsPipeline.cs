namespace AssetTool
{
    [JsonAsset("InterchangeCardsPipeline")]
    public class UInterchangeCardsPipeline : UInterchangePipelineBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}