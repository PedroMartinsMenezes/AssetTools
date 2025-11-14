namespace AssetTool
{
    [JsonAsset("PropertyAnimatorCurve")]
    public class UPropertyAnimatorCurve : UPropertyAnimatorNumericBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}