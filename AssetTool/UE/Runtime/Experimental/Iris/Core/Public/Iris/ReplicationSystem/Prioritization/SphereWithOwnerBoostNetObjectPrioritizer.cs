namespace AssetTool
{
    [JsonAsset("SphereWithOwnerBoostNetObjectPrioritizerConfig")]
    public class USphereWithOwnerBoostNetObjectPrioritizerConfig : USphereNetObjectPrioritizerConfig
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SphereWithOwnerBoostNetObjectPrioritizer")]
    public class USphereWithOwnerBoostNetObjectPrioritizer : USphereNetObjectPrioritizer
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}