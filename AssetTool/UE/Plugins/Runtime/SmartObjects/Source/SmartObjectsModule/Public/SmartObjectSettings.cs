namespace AssetTool
{
    [JsonAsset("SmartObjectSettings")]
    public class USmartObjectSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}