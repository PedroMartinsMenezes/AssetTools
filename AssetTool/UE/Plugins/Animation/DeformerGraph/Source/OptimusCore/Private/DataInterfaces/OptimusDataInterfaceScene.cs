namespace AssetTool
{
    [JsonAsset("OptimusSceneDataInterface")]
    public class UOptimusSceneDataInterface : UOptimusComputeDataInterface
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("OptimusSceneDataProvider")]
    public class UOptimusSceneDataProvider : UComputeDataProvider
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}