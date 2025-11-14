namespace AssetTool
{
    [JsonAsset("PropertyAnimatorWiggle")]
    public class UPropertyAnimatorWiggle : UPropertyAnimatorNumericBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}