namespace AssetTool
{
    [JsonAsset("CommonUISubsystemBase")]
    public class UCommonUISubsystemBase : UGameInstanceSubsystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}