namespace AssetTool
{
    [JsonAsset("ProjectileMovementComponent")]
    public class UProjectileMovementComponent : UMovementComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}