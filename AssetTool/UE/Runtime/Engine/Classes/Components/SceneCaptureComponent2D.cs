namespace AssetTool
{
    [JsonAsset("SceneCaptureComponent2D")]
    public class USceneCaptureComponent2D : USceneCaptureComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}