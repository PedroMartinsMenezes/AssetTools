namespace AssetTool
{
    [JsonAsset("SceneCapture")]
    public class ASceneCapture : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}