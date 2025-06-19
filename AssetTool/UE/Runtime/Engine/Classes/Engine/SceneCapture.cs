namespace AssetTool
{
    [JsonAsset("SceneCapture")]
    public class ASceneCapture : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}