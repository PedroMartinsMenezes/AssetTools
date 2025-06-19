namespace AssetTool
{
    [JsonAsset("ComposureLensBloomPass")]
    public class UComposureLensBloomPass : UComposurePostProcessPass
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ComposureLensBloomPassPolicy")]
    public class UComposureLensBloomPassPolicy : UComposurePostProcessPassPolicy
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}