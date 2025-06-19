namespace AssetTool
{
    [JsonAsset("MetaSoundSettings")]
    public class UMetaSoundSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}