namespace AssetTool
{
    [JsonAsset("MetaSoundQualityHelper")]
    public class UMetaSoundQualityHelper : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetaSoundSettings")]
    public class UMetaSoundSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}