namespace AssetTool
{
    [JsonAsset("AssetDefinition_DataTable")]
    public class UAssetDefinition_DataTable : UAssetDefinitionDefault
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}