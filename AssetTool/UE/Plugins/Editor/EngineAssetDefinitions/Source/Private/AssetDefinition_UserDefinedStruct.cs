namespace AssetTool
{
    [JsonAsset("AssetDefinition_UserDefinedStruct")]
    public class UAssetDefinition_UserDefinedStruct : UAssetDefinitionDefault
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}