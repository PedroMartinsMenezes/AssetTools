namespace AssetTool
{
    [JsonAsset("DisplayClusterConfiguratorFactory")]
    public class UDisplayClusterConfiguratorFactory : UFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DisplayClusterConfiguratorReimportFactory")]
    public class UDisplayClusterConfiguratorReimportFactory : UDisplayClusterConfiguratorFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}