namespace AssetTool
{
    [JsonAsset("OptimusSceneDataInterface")]
    public class UOptimusSceneDataInterface : UOptimusComputeDataInterface
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("OptimusSceneDataProvider")]
    public class UOptimusSceneDataProvider : UComputeDataProvider
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}