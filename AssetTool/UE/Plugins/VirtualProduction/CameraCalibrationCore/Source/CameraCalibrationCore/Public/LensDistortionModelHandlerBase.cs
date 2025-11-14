namespace AssetTool
{
    [JsonAsset("LensDistortionModelHandlerBase")]
    public class ULensDistortionModelHandlerBase : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}