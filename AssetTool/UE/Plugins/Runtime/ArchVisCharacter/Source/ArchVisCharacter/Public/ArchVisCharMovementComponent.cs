namespace AssetTool
{
    [JsonAsset("ArchVisCharMovementComponent")]
    public class UArchVisCharMovementComponent : UCharacterMovementComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}