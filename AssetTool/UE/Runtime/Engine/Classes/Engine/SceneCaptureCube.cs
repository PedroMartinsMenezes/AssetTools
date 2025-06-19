namespace AssetTool
{
    [JsonAsset("SceneCaptureCube")]
    public class ASceneCaptureCube : ASceneCapture
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}