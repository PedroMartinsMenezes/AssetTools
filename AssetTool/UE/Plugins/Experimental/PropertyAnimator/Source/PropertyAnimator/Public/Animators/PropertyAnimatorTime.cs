namespace AssetTool
{
    [JsonAsset("PropertyAnimatorTime")]
    public class UPropertyAnimatorTime : UPropertyAnimatorNumericBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}