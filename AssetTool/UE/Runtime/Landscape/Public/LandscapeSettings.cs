namespace AssetTool
{
    [JsonAsset("LandscapeSettings")]
    public class ULandscapeSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}