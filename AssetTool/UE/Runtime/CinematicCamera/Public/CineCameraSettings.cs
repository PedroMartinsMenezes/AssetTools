namespace AssetTool
{
    [JsonAsset("CineCameraSettings")]
    public class UCineCameraSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}