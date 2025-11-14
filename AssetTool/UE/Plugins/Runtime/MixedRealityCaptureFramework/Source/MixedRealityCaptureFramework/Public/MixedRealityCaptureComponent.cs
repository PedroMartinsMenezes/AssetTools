namespace AssetTool
{
    [JsonAsset("MixedRealityCaptureComponent")]
    public class UMixedRealityCaptureComponent : USceneCaptureComponent2D
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}