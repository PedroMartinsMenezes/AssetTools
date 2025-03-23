namespace AssetTool
{
    [JsonAsset("PreviewPlayerCameraManager")]
    public class APreviewPlayerCameraManager : APlayerCameraManager
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}