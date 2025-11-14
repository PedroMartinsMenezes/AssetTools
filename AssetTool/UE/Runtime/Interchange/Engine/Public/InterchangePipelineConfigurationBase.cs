namespace AssetTool
{
    [JsonAsset("InterchangePipelineConfigurationBase")]
    public class UInterchangePipelineConfigurationBase : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}