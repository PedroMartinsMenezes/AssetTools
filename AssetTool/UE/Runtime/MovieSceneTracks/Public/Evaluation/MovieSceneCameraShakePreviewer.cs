namespace AssetTool
{
    [JsonAsset("PreviewPlayerCameraManager")]
    public class APreviewPlayerCameraManager : APlayerCameraManager
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}