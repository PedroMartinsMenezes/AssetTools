namespace AssetTool
{
    [JsonAsset("AvaEaseCurve")]
    public class UAvaEaseCurve : UCurveFloat
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}