namespace AssetTool
{
    [JsonAsset("PhysicalAnimationComponent")]
    public class UPhysicalAnimationComponent : UActorComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}