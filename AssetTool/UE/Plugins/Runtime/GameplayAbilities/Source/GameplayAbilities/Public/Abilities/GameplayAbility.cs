namespace AssetTool
{
    [JsonAsset("GameplayAbility")]
    public class UGameplayAbility : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}