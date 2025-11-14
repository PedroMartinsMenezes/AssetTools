namespace AssetTool
{
    [JsonAsset("BoxReflectionCaptureComponent")]
    public class UBoxReflectionCaptureComponent : UReflectionCaptureComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}