namespace AssetTool
{
    [JsonAsset("UserInterfaceSettings")]
    public class UUserInterfaceSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}