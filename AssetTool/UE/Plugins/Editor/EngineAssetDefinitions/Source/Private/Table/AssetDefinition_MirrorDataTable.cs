namespace AssetTool
{
    [JsonAsset("AssetDefinition_MirrorDataTable")]
    public class UAssetDefinition_MirrorDataTable : UAssetDefinition_DataTable
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}