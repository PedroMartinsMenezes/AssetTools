namespace AssetTool
{
    [JsonAsset("CameraBlockingVolume")]
    public class ACameraBlockingVolume : AVolume
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}