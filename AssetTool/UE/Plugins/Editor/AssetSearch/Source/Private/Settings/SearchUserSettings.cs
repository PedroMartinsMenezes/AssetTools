namespace AssetTool
{
    [JsonAsset("SearchUserSettings")]
    public class USearchUserSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}