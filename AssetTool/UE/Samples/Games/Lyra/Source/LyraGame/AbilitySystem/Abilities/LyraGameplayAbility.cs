namespace AssetTool
{
    [JsonAsset("LyraGameplayAbility")]
    public class ULyraGameplayAbility : UGameplayAbility
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}