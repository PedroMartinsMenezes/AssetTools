namespace AssetTool
{
    [JsonAsset("HLODBuilderSettings")]
    public class UHLODBuilderSettings : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("HLODBuilder")]
    public class UHLODBuilder : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NullHLODBuilder")]
    public class UNullHLODBuilder : UHLODBuilder
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}