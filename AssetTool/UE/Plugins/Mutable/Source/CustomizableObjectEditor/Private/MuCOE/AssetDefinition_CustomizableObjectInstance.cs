namespace AssetTool
{
    [JsonAsset("AssetDefinition_CustomizableObjectInstance")]
    public class UAssetDefinition_CustomizableObjectInstance : UAssetDefinitionDefault
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}