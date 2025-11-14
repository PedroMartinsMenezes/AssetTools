namespace AssetTool
{
    [JsonAsset("OptimusClothDataInterface")]
    public class UOptimusClothDataInterface : UOptimusComputeDataInterface
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("OptimusClothDataProvider")]
    public class UOptimusClothDataProvider : UComputeDataProvider
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}