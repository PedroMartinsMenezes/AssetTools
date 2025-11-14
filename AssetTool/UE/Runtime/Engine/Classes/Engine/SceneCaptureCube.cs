namespace AssetTool
{
    [JsonAsset("SceneCaptureCube")]
    public class ASceneCaptureCube : ASceneCapture
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}