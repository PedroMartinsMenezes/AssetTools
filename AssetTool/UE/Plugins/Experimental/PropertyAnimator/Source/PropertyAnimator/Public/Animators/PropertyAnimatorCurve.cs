namespace AssetTool
{
    [JsonAsset("PropertyAnimatorCurve")]
    public class UPropertyAnimatorCurve : UPropertyAnimatorNumericBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}