namespace AssetTool
{
    [JsonAsset("MixedRealityCaptureComponent")]
    public class UMixedRealityCaptureComponent : USceneCaptureComponent2D
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}