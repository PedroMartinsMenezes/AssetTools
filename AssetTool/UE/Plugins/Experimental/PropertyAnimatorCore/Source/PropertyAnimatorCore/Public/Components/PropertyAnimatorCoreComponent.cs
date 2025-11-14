namespace AssetTool
{
    [JsonAsset("PropertyAnimatorCoreComponent")]
    public class UPropertyAnimatorCoreComponent : UActorComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}