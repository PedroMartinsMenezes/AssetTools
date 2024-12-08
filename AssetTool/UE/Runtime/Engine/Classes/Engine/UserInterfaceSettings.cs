namespace AssetTool
{
    [JsonAsset("UserInterfaceSettings")]
    public class UUserInterfaceSettings : UDeveloperSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}