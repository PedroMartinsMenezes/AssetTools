namespace AssetTool
{
    [JsonAsset("VREditorFloatingCameraUI")]
    public class AVREditorFloatingCameraUI : AVREditorFloatingUI
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}