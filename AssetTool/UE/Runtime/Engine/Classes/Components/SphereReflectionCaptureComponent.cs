namespace AssetTool
{
    [JsonAsset("SphereReflectionCaptureComponent")]
    public class USphereReflectionCaptureComponent : UReflectionCaptureComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}