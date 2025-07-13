namespace AssetTool
{
    [JsonAsset("OnlinePIESettings")]
    public class UOnlinePIESettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}