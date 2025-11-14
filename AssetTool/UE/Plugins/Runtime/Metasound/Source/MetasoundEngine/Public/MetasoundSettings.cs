namespace AssetTool
{
    [JsonAsset("MetaSoundQualityHelper")]
    public class UMetaSoundQualityHelper : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetaSoundSettings")]
    public class UMetaSoundSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}