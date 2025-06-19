namespace AssetTool
{
    [JsonAsset("HLODBuilderSettings")]
    public class UHLODBuilderSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("HLODBuilder")]
    public class UHLODBuilder : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NullHLODBuilder")]
    public class UNullHLODBuilder : UHLODBuilder
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}