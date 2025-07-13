namespace AssetTool
{
    [JsonAsset("AssetDefinition_CustomizableObjectInstance")]
    public class UAssetDefinition_CustomizableObjectInstance : UAssetDefinitionDefault
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}