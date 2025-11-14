namespace AssetTool
{
    [JsonAsset("GameplayAbilityGraphSchema")]
    public class UGameplayAbilityGraphSchema : UEdGraphSchema_K2
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}