namespace AssetTool
{
    [JsonAsset("CameraBlockingVolume")]
    public class ACameraBlockingVolume : AVolume
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}