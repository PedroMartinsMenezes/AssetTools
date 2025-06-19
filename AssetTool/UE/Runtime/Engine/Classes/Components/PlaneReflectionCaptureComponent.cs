namespace AssetTool
{
    [JsonAsset("PlaneReflectionCaptureComponent")]
    public class UPlaneReflectionCaptureComponent : UReflectionCaptureComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}