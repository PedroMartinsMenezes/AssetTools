namespace AssetTool
{
    [JsonAsset("AssetDefinition_LidarPointCloud")]
    public class UAssetDefinition_LidarPointCloud : UAssetDefinitionDefault
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}