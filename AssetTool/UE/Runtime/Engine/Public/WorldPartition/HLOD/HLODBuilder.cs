namespace AssetTool
{
    [JsonAsset("HLODBuilderSettings")]
    public class UHLODBuilderSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("HLODBuilder")]
    public class UHLODBuilder : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NullHLODBuilder")]
    public class UNullHLODBuilder : UHLODBuilder
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}