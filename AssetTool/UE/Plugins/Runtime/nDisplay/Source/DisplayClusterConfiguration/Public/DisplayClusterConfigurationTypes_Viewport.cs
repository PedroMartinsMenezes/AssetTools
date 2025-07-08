namespace AssetTool
{
    [JsonAsset("DisplayClusterConfigurationViewport")]
    public class UDisplayClusterConfigurationViewport : UDisplayClusterConfigurationData_Base
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}