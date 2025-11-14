namespace AssetTool
{
    [JsonAsset("PropertyAnimatorTime")]
    public class UPropertyAnimatorTime : UPropertyAnimatorNumericBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}