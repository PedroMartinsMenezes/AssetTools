namespace AssetTool
{
    [JsonAsset("AssetDefinition_LidarPointCloud")]
    public class UAssetDefinition_LidarPointCloud : UAssetDefinitionDefault
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}