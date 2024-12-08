namespace AssetTool
{
    [JsonAsset("CameraBlockingVolume")]
    public class ACameraBlockingVolume : AVolume
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}