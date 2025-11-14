namespace AssetTool
{
    [JsonAsset("LyraPlayerCameraManager")]
    public class ALyraPlayerCameraManager : APlayerCameraManager
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}