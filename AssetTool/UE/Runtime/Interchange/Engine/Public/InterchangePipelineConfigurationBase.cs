namespace AssetTool
{
    [JsonAsset("InterchangePipelineConfigurationBase")]
    public class UInterchangePipelineConfigurationBase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}