namespace AssetTool
{
    [JsonAsset("SceneCaptureComponent")]
    public class USceneCaptureComponent : USceneComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}