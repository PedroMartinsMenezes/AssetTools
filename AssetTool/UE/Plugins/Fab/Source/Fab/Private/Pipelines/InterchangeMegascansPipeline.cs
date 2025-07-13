namespace AssetTool
{
    [JsonAsset("MegascansMaterialParentSettings")]
    public class UMegascansMaterialParentSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("InterchangeMegascansPipeline")]
    public class UInterchangeMegascansPipeline : UInterchangePipelineBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}