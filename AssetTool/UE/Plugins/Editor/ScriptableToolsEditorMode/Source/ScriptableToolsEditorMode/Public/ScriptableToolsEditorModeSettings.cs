namespace AssetTool
{
    [JsonAsset("ScriptableToolsModeCustomizationSettings")]
    public class UScriptableToolsModeCustomizationSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}