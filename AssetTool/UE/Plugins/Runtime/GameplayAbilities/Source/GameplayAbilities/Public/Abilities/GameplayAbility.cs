namespace AssetTool
{
    [JsonAsset("GameplayAbility")]
    public class UGameplayAbility : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}