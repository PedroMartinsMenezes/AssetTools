namespace AssetTool
{
    [JsonAsset("AssetDefinition_MaterialInstanceDynamic")]
    public class UAssetDefinition_MaterialInstanceDynamic : UAssetDefinition_MaterialInterface
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}