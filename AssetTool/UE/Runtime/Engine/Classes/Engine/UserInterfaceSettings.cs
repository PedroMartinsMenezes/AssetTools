namespace AssetTool
{
    [JsonAsset("UserInterfaceSettings")]
    public class UUserInterfaceSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}