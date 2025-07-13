namespace AssetTool
{
    [JsonAsset("AssetDefinition_PhysicalMaterial")]
    public class UAssetDefinition_PhysicalMaterial : UAssetDefinitionDefault
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}