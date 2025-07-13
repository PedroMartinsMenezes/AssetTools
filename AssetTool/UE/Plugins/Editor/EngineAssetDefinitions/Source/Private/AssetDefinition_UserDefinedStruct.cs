namespace AssetTool
{
    [JsonAsset("AssetDefinition_UserDefinedStruct")]
    public class UAssetDefinition_UserDefinedStruct : UAssetDefinitionDefault
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}