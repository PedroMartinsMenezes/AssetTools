namespace AssetTool
{
    [JsonAsset("ProjectileMovementComponent")]
    public class UProjectileMovementComponent : UMovementComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}