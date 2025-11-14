namespace AssetTool
{
    [JsonAsset("DataValidationSettings")]
    public class UDataValidationSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}