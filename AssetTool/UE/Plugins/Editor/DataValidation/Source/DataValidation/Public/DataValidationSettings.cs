namespace AssetTool
{
    [JsonAsset("DataValidationSettings")]
    public class UDataValidationSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}