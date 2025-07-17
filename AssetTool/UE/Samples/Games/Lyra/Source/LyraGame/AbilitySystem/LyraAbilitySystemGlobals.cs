namespace AssetTool
{
    [JsonAsset("LyraAbilitySystemGlobals")]
    public class ULyraAbilitySystemGlobals : UAbilitySystemGlobals
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}