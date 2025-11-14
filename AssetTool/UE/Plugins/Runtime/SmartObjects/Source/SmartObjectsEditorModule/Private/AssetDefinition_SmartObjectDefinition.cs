namespace AssetTool
{
    [JsonAsset("AssetDefinition_SmartObjectDefinition")]
    public class UAssetDefinition_SmartObjectDefinition : UAssetDefinitionDefault
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}