namespace AssetTool
{
    [JsonAsset("CommonUISubsystemBase")]
    public class UCommonUISubsystemBase : UGameInstanceSubsystem
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}