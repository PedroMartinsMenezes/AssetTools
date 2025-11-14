namespace AssetTool
{
    [JsonAsset("LyraGameplayAbility_RangedWeapon")]
    public class ULyraGameplayAbility_RangedWeapon : ULyraGameplayAbility_FromEquipment
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}