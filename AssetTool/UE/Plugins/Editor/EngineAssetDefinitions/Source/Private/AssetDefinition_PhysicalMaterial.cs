namespace AssetTool
{
    [JsonAsset("AssetDefinition_PhysicalMaterial")]
    public class UAssetDefinition_PhysicalMaterial : UAssetDefinitionDefault
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}