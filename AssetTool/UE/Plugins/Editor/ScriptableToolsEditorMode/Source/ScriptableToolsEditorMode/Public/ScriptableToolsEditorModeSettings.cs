namespace AssetTool
{
    [JsonAsset("ScriptableToolsModeCustomizationSettings")]
    public class UScriptableToolsModeCustomizationSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}