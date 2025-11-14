namespace AssetTool
{
    [JsonAsset("LyraAbilitySystemGlobals")]
    public class ULyraAbilitySystemGlobals : UAbilitySystemGlobals
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}