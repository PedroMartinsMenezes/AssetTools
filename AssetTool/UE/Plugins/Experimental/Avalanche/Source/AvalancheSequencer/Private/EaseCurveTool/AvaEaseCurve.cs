namespace AssetTool
{
    [JsonAsset("AvaEaseCurve")]
    public class UAvaEaseCurve : UCurveFloat
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}