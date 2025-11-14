namespace AssetTool
{
    [JsonAsset("TopDownArenaMovementComponent")]
    public class UTopDownArenaMovementComponent : ULyraCharacterMovementComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}