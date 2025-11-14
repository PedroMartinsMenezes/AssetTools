namespace AssetTool
{
    [JsonAsset("SphereNetObjectPrioritizerConfig")]
    public class USphereNetObjectPrioritizerConfig : UNetObjectPrioritizerConfig
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SphereNetObjectPrioritizer")]
    public class USphereNetObjectPrioritizer : ULocationBasedNetObjectPrioritizer
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}