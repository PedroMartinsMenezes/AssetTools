namespace AssetTool
{
    [JsonAsset("AssetDefinition_CompositeDataTable")]
    public class UAssetDefinition_CompositeDataTable : UAssetDefinition_DataTable
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}