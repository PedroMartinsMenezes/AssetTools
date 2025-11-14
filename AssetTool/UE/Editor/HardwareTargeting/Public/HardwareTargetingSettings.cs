namespace AssetTool
{
    [JsonAsset("HardwareTargetingSettings")]
    public class UHardwareTargetingSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}