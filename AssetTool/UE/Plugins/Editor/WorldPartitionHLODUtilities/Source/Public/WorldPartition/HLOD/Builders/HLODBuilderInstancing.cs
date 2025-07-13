namespace AssetTool
{
    [JsonAsset("HLODBuilderInstancingSettings")]
    public class UHLODBuilderInstancingSettings : UHLODBuilderSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("HLODBuilderInstancing")]
    public class UHLODBuilderInstancing : UHLODBuilder
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}