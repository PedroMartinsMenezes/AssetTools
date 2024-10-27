namespace AssetTool
{
    [JsonAsset("SceneCaptureComponent")]
    public class USceneCaptureComponent : USceneComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}