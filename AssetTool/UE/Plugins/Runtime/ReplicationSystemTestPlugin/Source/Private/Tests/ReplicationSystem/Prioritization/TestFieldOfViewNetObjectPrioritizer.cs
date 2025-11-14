namespace AssetTool
{
    [JsonAsset("FieldOfViewNetObjectPrioritizerTestConfig")]
    public class UFieldOfViewNetObjectPrioritizerTestConfig : UFieldOfViewNetObjectPrioritizerConfig
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("FieldOfViewNetObjectPrioritizerForConeTestConfig")]
    public class UFieldOfViewNetObjectPrioritizerForConeTestConfig : UFieldOfViewNetObjectPrioritizerConfig
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}