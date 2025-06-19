namespace AssetTool
{
    [JsonAsset("ComposurePostProcessPassPolicy")]
    public class UComposurePostProcessPassPolicy : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ComposurePostProcessingPassProxy")]
    public class UComposurePostProcessingPassProxy : UComposurePostProcessPass
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}