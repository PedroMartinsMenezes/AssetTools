namespace AssetTool
{
    [JsonAsset("PropertyAnimatorWaveCurve")]
    public class UPropertyAnimatorWaveCurve : UCurveFloat
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}