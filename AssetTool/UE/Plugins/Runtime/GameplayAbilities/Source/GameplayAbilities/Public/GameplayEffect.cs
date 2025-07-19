namespace AssetTool
{
    [TransferibleStruct("GameplayEffectModifierMagnitude")]
    public class FGameplayEffectModifierMagnitude : ITransferible
    {
        public ITransferible Move(Transfer transfer)
        {
            return null;
        }
    }

    [TransferibleStruct("GameplayEffectVersion")]
    public class FGameplayEffectVersion : ITransferible
    {
        public EGameplayEffectVersion CurrentVersion;

        [Location("bool FGameplayEffectVersion::Serialize(FStructuredArchive::FSlot Slot)")]
        public ITransferible Move(Transfer transfer)
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