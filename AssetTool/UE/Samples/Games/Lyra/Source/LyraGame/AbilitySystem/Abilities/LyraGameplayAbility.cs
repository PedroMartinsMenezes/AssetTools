namespace AssetTool
{
    [JsonAsset("LyraGameplayAbility")]
    public class ULyraGameplayAbility : UGameplayAbility
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}