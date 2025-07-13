namespace AssetTool
{
    [JsonAsset("AssetDefinition_InstancedFoliageSettings")]
    public class UAssetDefinition_InstancedFoliageSettings : UAssetDefinitionDefault
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}