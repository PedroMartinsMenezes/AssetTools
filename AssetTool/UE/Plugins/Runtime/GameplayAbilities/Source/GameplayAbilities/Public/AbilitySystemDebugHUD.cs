namespace AssetTool
{
    [JsonAsset("AbilitySystemDebugHUDExtension")]
    public class UAbilitySystemDebugHUDExtension : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AbilitySystemDebugHUDExtension_Tags")]
    public class UAbilitySystemDebugHUDExtension_Tags : UAbilitySystemDebugHUDExtension
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AbilitySystemDebugHUDExtension_Attributes")]
    public class UAbilitySystemDebugHUDExtension_Attributes : UAbilitySystemDebugHUDExtension
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AbilitySystemDebugHUDExtension_BlockedAbilityTags")]
    public class UAbilitySystemDebugHUDExtension_BlockedAbilityTags : UAbilitySystemDebugHUDExtension
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AbilitySystemDebugHUD")]
    public class AAbilitySystemDebugHUD : AHUD
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}