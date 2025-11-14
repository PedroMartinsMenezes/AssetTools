namespace AssetTool
{
    [JsonAsset("CharacterMotionComponent")]
    public class UCharacterMotionComponent : UBaseMovementComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}