namespace AssetTool
{
    [JsonAsset("PropertyAnimatorEaseCurve")]
    public class UPropertyAnimatorEaseCurve : UCurveFloat
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}