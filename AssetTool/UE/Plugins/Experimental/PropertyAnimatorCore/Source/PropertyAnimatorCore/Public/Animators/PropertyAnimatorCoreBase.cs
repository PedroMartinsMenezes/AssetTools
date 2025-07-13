namespace AssetTool
{
    [JsonAsset("PropertyAnimatorCoreBase")]
    public class UPropertyAnimatorCoreBase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}