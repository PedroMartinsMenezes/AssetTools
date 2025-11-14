namespace AssetTool
{
    [JsonAsset("AssetDefinition_CompositeCurveTable")]
    public class UAssetDefinition_CompositeCurveTable : UAssetDefinition_CurveTable
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}