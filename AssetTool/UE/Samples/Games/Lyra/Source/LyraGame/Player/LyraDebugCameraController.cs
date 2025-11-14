namespace AssetTool
{
    [JsonAsset("LyraDebugCameraController")]
    public class ALyraDebugCameraController : ADebugCameraController
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}