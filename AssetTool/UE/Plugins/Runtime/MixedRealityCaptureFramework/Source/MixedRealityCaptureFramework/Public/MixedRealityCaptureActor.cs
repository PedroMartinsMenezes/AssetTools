namespace AssetTool
{
    [JsonAsset("MixedRealityCaptureActor")]
    public class AMixedRealityCaptureActor : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}