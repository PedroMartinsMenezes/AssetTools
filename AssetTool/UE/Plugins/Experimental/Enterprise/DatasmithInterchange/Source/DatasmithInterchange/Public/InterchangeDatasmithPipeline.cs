namespace AssetTool
{
    [JsonAsset("InterchangeDatasmithPipeline")]
    public class UInterchangeDatasmithPipeline : UInterchangePipelineBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}