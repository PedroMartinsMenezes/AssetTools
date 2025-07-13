namespace AssetTool
{
    [JsonAsset("AssetDefinition_MaterialInterface")]
    public class UAssetDefinition_MaterialInterface : UAssetDefinitionDefault
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}