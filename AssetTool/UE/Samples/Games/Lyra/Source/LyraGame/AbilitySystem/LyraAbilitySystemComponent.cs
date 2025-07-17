namespace AssetTool
{
    [JsonAsset("LyraAbilitySystemComponent")]
    public class ULyraAbilitySystemComponent : UAbilitySystemComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}