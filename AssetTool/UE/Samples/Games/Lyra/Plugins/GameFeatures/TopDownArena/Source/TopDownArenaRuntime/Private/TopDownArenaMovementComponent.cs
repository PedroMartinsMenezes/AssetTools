namespace AssetTool
{
    [JsonAsset("TopDownArenaMovementComponent")]
    public class UTopDownArenaMovementComponent : ULyraCharacterMovementComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}