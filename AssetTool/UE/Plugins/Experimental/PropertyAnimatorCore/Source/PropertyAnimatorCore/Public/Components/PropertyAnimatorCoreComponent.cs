namespace AssetTool
{
    [JsonAsset("PropertyAnimatorCoreComponent")]
    public class UPropertyAnimatorCoreComponent : UActorComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}