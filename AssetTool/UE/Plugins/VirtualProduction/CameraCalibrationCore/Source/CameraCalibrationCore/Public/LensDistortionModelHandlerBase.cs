namespace AssetTool
{
    [JsonAsset("LensDistortionModelHandlerBase")]
    public class ULensDistortionModelHandlerBase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}