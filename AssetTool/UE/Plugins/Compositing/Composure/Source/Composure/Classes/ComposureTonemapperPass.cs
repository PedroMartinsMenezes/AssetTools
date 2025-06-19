namespace AssetTool
{
    [JsonAsset("ComposureTonemapperPass")]
    public class UComposureTonemapperPass : UComposurePostProcessPass
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ComposureTonemapperPassPolicy")]
    public class UComposureTonemapperPassPolicy : UComposurePostProcessPassPolicy
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}