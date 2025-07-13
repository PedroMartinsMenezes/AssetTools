namespace AssetTool
{
    [JsonAsset("PropertyAnimatorWiggle")]
    public class UPropertyAnimatorWiggle : UPropertyAnimatorNumericBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}