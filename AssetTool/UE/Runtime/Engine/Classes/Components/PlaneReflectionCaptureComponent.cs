namespace AssetTool
{
    [JsonAsset("PlaneReflectionCaptureComponent")]
    public class UPlaneReflectionCaptureComponent : UReflectionCaptureComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}