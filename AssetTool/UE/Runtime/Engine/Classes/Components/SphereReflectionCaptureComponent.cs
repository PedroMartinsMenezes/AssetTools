namespace AssetTool
{
    [JsonAsset("SphereReflectionCaptureComponent")]
    public class USphereReflectionCaptureComponent : UReflectionCaptureComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}