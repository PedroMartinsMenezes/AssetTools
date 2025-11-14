namespace AssetTool
{
    [JsonAsset("HLODBuilderInstancingSettings")]
    public class UHLODBuilderInstancingSettings : UHLODBuilderSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("HLODBuilderInstancing")]
    public class UHLODBuilderInstancing : UHLODBuilder
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}