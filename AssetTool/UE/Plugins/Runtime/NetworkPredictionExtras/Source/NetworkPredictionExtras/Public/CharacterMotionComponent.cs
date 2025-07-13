namespace AssetTool
{
    [JsonAsset("CharacterMotionComponent")]
    public class UCharacterMotionComponent : UBaseMovementComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}