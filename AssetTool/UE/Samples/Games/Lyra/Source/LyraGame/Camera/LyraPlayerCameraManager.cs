namespace AssetTool
{
    [JsonAsset("LyraPlayerCameraManager")]
    public class ALyraPlayerCameraManager : APlayerCameraManager
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}