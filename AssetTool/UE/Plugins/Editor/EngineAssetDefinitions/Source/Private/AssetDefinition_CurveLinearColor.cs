namespace AssetTool
{
    [JsonAsset("AssetDefinition_CurveLinearColor")]
    public class UAssetDefinition_CurveLinearColor : UAssetDefinition_Curve
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}