namespace AssetTool
{
    [JsonAsset("NetObjectPrioritizerConfig")]
    public class UNetObjectPrioritizerConfig : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NetObjectPrioritizer")]
    public class UNetObjectPrioritizer : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}