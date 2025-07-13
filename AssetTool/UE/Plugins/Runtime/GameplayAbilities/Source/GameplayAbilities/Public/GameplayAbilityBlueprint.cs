namespace AssetTool
{
    [JsonAsset("GameplayAbilityBlueprint")]
    public class UGameplayAbilityBlueprint : UBlueprint
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}