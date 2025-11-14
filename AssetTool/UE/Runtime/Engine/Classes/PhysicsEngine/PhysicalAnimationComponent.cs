namespace AssetTool
{
    [JsonAsset("PhysicalAnimationComponent")]
    public class UPhysicalAnimationComponent : UActorComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}