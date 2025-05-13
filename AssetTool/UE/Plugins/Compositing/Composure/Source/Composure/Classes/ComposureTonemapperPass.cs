namespace AssetTool
{
    [JsonAsset("ComposureTonemapperPass")]
    public class UComposureTonemapperPass : UComposurePostProcessPass
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ComposureTonemapperPassPolicy")]
    public class UComposureTonemapperPassPolicy : UComposurePostProcessPassPolicy
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}