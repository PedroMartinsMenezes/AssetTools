namespace AssetTool
{
    [JsonAsset("MockCharacterAbilityComponent")]
    public class UMockCharacterAbilityComponent : UCharacterMotionComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}