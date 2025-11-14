namespace AssetTool
{
    [JsonAsset("PreviewPlayerCameraManager")]
    public class APreviewPlayerCameraManager : APlayerCameraManager
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}