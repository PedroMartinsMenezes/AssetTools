namespace AssetTool
{
    [JsonAsset("GameplayAbilitiesDeveloperSettings")]
    public class UGameplayAbilitiesDeveloperSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("GameplayAbilitiesEditorDeveloperSettings")]
    public class UGameplayAbilitiesEditorDeveloperSettings : UDeveloperSettingsBackedByCVars
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}