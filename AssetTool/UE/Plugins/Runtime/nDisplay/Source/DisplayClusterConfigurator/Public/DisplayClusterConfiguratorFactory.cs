namespace AssetTool
{
    [JsonAsset("DisplayClusterConfiguratorFactory")]
    public class UDisplayClusterConfiguratorFactory : UFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DisplayClusterConfiguratorReimportFactory")]
    public class UDisplayClusterConfiguratorReimportFactory : UDisplayClusterConfiguratorFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}