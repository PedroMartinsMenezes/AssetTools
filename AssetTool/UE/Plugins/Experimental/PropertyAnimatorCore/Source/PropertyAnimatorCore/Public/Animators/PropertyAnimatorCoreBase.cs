namespace AssetTool
{
    [JsonAsset("PropertyAnimatorCoreBase")]
    public class UPropertyAnimatorCoreBase : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}