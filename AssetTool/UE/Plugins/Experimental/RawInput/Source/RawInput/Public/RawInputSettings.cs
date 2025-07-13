namespace AssetTool
{
    [JsonAsset("RawInputSettings")]
    public class URawInputSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}