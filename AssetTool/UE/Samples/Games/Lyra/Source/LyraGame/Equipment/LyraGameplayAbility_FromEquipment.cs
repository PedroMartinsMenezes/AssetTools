namespace AssetTool
{
    [JsonAsset("LyraGameplayAbility_FromEquipment")]
    public class ULyraGameplayAbility_FromEquipment : ULyraGameplayAbility
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}