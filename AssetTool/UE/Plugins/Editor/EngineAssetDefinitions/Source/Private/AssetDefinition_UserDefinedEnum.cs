namespace AssetTool
{
    [JsonAsset("AssetDefinition_UserDefinedEnum")]
    public class UAssetDefinition_UserDefinedEnum : UAssetDefinitionDefault
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}