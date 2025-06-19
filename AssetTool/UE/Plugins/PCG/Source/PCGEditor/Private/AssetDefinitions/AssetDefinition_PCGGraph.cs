namespace AssetTool
{
    [JsonAsset("AssetDefinition_PCGGraph")]
    public class UAssetDefinition_PCGGraph : UAssetDefinition_PCGGraphInterface
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}