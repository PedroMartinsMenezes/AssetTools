namespace AssetTool
{
    [TransferableStruct("GameplayEffectModifierMagnitude")]
    public class FGameplayEffectModifierMagnitude : ITransferable
    {
        public ITransferable Move(Transfer transfer)
        {
            return null;
        }
    }

    [TransferableStruct("GameplayEffectVersion")]
    public class FGameplayEffectVersion : ITransferable
    {
        public EGameplayEffectVersion CurrentVersion;

        [Location("bool FGameplayEffectVersion::Serialize(FStructuredArchive::FSlot Slot)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.MoveEnum(ref CurrentVersion);
            return this;
        }
    }

    public enum EGameplayEffectVersion : uint8
    {
        Monolithic,
        Modular53,
        AbilitiesComponent53,
        Current = AbilitiesComponent53
    }
}