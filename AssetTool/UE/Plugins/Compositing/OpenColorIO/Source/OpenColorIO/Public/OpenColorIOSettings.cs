namespace AssetTool
{
    [JsonAsset("OpenColorIOSettings")]
    public class UOpenColorIOSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}