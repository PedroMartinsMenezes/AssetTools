namespace AssetTool
{
    [JsonAsset("SearchUserSettings")]
    public class USearchUserSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}