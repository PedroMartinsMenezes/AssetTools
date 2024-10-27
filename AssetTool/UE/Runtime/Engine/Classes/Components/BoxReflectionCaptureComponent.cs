namespace AssetTool
{
    [JsonAsset("BoxReflectionCaptureComponent")]
    public class UBoxReflectionCaptureComponent : UReflectionCaptureComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}