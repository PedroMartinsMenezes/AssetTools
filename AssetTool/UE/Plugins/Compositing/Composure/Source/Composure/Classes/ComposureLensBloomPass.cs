namespace AssetTool
{
    [JsonAsset("ComposureLensBloomPass")]
    public class UComposureLensBloomPass : UComposurePostProcessPass
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ComposureLensBloomPassPolicy")]
    public class UComposureLensBloomPassPolicy : UComposurePostProcessPassPolicy
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}