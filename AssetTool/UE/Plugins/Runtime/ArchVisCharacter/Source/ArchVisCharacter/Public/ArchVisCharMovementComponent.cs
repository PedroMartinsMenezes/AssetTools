namespace AssetTool
{
    [JsonAsset("ArchVisCharMovementComponent")]
    public class UArchVisCharMovementComponent : UCharacterMovementComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}