namespace AssetTool
{
    [JsonAsset("FieldOfViewNetObjectPrioritizerTestConfig")]
    public class UFieldOfViewNetObjectPrioritizerTestConfig : UFieldOfViewNetObjectPrioritizerConfig
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("FieldOfViewNetObjectPrioritizerForConeTestConfig")]
    public class UFieldOfViewNetObjectPrioritizerForConeTestConfig : UFieldOfViewNetObjectPrioritizerConfig
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}