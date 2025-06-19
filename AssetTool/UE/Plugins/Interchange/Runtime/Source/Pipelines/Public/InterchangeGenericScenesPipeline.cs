namespace AssetTool
{
    [JsonAsset("InterchangeGenericLevelPipeline")]
    public class UInterchangeGenericLevelPipeline : UInterchangePipelineBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}