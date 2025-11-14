namespace AssetTool
{
    [JsonAsset("EnhancedInputDeveloperSettings")]
    public class UEnhancedInputDeveloperSettings : UDeveloperSettingsBackedByCVars
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}