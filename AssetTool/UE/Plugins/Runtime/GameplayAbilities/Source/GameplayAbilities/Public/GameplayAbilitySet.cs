namespace AssetTool
{
    [JsonAsset("GameplayAbilitySet")]
    public class UGameplayAbilitySet : UDataAsset
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}