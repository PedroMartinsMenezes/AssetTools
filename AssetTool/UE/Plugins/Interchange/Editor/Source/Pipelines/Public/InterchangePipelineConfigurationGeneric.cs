namespace AssetTool
{
    [JsonAsset("InterchangePipelineConfigurationGeneric")]
    public class UInterchangePipelineConfigurationGeneric : UInterchangePipelineConfigurationBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}