namespace AssetTool
{
    [JsonAsset("PropertyAnimatorEaseCurve")]
    public class UPropertyAnimatorEaseCurve : UCurveFloat
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}