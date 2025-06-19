namespace AssetTool
{
    [JsonAsset("BoxReflectionCaptureComponent")]
    public class UBoxReflectionCaptureComponent : UReflectionCaptureComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}