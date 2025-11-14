namespace AssetTool
{
    [JsonAsset("PlaneReflectionCaptureComponent")]
    public class UPlaneReflectionCaptureComponent : UReflectionCaptureComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}