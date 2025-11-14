namespace AssetTool
{
    [JsonAsset("SceneCaptureComponent")]
    public class USceneCaptureComponent : USceneComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}