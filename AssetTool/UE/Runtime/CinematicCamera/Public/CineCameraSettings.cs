namespace AssetTool
{
    [JsonAsset("CineCameraSettings")]
    public class UCineCameraSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}