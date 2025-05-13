namespace AssetTool
{
    [JsonAsset("ComposurePostProcessPassPolicy")]
    public class UComposurePostProcessPassPolicy : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ComposurePostProcessingPassProxy")]
    public class UComposurePostProcessingPassProxy : UComposurePostProcessPass
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}