namespace AssetTool
{
    [JsonAsset("GameplayAbilityBlueprint")]
    public class UGameplayAbilityBlueprint : UBlueprint
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}