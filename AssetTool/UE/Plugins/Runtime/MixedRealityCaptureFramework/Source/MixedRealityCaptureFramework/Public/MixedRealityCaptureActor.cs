namespace AssetTool
{
    [JsonAsset("MixedRealityCaptureActor")]
    public class AMixedRealityCaptureActor : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}