namespace AssetTool
{
    [JsonAsset("InterchangePipelineConfigurationBase")]
    public class UInterchangePipelineConfigurationBase : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}