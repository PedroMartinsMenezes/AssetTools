namespace AssetTool
{
    [JsonAsset("MetaSoundSettings")]
    public class UMetaSoundSettings : UDeveloperSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}