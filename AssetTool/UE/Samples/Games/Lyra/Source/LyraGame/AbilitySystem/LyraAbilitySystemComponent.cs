namespace AssetTool
{
    [JsonAsset("LyraAbilitySystemComponent")]
    public class ULyraAbilitySystemComponent : UAbilitySystemComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}