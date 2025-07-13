namespace AssetTool
{
    [JsonAsset("GameplayAbilityGraph")]
    public class UGameplayAbilityGraph : UEdGraph
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}