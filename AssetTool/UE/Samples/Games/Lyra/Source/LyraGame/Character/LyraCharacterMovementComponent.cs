namespace AssetTool
{
    [JsonAsset("LyraCharacterMovementComponent")]
    public class ULyraCharacterMovementComponent : UCharacterMovementComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}