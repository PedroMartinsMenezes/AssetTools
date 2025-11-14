namespace AssetTool
{
    [JsonAsset("OnlinePIESettings")]
    public class UOnlinePIESettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}