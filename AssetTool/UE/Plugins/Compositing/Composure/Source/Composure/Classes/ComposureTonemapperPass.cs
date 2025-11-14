namespace AssetTool
{
    [JsonAsset("ComposureTonemapperPass")]
    public class UComposureTonemapperPass : UComposurePostProcessPass
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ComposureTonemapperPassPolicy")]
    public class UComposureTonemapperPassPolicy : UComposurePostProcessPassPolicy
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}