namespace AssetTool
{
    [JsonAsset("AssetDefinition_CurveVector")]
    public class UAssetDefinition_CurveVector : UAssetDefinition_Curve
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}