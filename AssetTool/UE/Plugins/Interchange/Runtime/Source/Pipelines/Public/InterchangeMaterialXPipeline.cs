namespace AssetTool
{
    [JsonAsset("MaterialXPipelineSettings")]
    public class UMaterialXPipelineSettings : UDeveloperSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("InterchangeMaterialXPipeline")]
    public class UInterchangeMaterialXPipeline : UInterchangePipelineBase
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}