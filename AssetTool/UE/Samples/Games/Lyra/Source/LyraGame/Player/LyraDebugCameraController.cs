namespace AssetTool
{
    [JsonAsset("LyraDebugCameraController")]
    public class ALyraDebugCameraController : ADebugCameraController
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}