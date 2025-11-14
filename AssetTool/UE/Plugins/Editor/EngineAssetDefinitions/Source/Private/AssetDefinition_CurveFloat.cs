namespace AssetTool
{
    [JsonAsset("AssetDefinition_CurveFloat")]
    public class UAssetDefinition_CurveFloat : UAssetDefinition_Curve
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}