namespace AssetTool
{
    [JsonAsset("MrcGarbageMatteCaptureComponent")]
    public class UMrcGarbageMatteCaptureComponent : USceneCaptureComponent2D
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MrcGarbageMatteActor")]
    public class AMrcGarbageMatteActor : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}