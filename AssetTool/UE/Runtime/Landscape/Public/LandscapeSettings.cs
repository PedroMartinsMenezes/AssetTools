namespace AssetTool
{
    [JsonAsset("LandscapeSettings")]
    public class ULandscapeSettings : UDeveloperSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}