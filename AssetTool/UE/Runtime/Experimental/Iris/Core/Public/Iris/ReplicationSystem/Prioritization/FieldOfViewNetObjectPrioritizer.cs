namespace AssetTool
{
    [JsonAsset("FieldOfViewNetObjectPrioritizerConfig")]
    public class UFieldOfViewNetObjectPrioritizerConfig : UNetObjectPrioritizerConfig
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("FieldOfViewNetObjectPrioritizer")]
    public class UFieldOfViewNetObjectPrioritizer : ULocationBasedNetObjectPrioritizer
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}