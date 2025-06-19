namespace AssetTool
{
    [JsonAsset("InterchangeDatasmithLevelPipeline")]
    public class UInterchangeDatasmithLevelPipeline : UInterchangeGenericLevelPipeline
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}