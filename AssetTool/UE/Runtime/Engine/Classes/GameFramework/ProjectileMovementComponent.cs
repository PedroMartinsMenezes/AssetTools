namespace AssetTool
{
    [JsonAsset("ProjectileMovementComponent")]
    public class UProjectileMovementComponent : UMovementComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}