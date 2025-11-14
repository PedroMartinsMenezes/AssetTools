namespace AssetTool
{
    [JsonAsset("PropertyAnimatorWaveCurve")]
    public class UPropertyAnimatorWaveCurve : UCurveFloat
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}