namespace AssetTool
{
    [JsonAsset("CineCameraSettings")]
    public class UCineCameraSettings : UDeveloperSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}