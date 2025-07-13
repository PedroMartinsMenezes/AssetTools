namespace AssetTool
{
    [JsonAsset("AssetDefinition_CustomizableObject")]
    public class UAssetDefinition_CustomizableObject : UAssetDefinitionDefault
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}