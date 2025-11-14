namespace AssetTool
{
    [JsonAsset("LyraCharacterMovementComponent")]
    public class ULyraCharacterMovementComponent : UCharacterMovementComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}