namespace AssetTool
{
    [JsonAsset("PhysicalAnimationComponent")]
    public class UPhysicalAnimationComponent : UActorComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}