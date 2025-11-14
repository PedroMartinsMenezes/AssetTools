namespace AssetTool
{
    [JsonAsset("SphereReflectionCaptureComponent")]
    public class USphereReflectionCaptureComponent : UReflectionCaptureComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}