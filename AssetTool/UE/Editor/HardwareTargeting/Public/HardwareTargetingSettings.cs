namespace AssetTool
{
    [JsonAsset("HardwareTargetingSettings")]
    public class UHardwareTargetingSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}