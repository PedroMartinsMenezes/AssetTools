namespace AssetTool
{
    [JsonAsset("MockCharacterAbilityComponent")]
    public class UMockCharacterAbilityComponent : UCharacterMotionComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}