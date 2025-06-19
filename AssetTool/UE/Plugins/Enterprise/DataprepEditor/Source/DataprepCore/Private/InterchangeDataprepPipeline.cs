namespace AssetTool
{
    [JsonAsset("InterchangeDataprepLevelPipeline")]
    public class UInterchangeDataprepLevelPipeline : UInterchangePipelineBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}