namespace AssetTool
{
    [JsonAsset("AssetDefinition_PCGGraphInstance")]
    public class UAssetDefinition_PCGGraphInstance : UAssetDefinition_PCGGraphInterface
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}