namespace AssetTool
{
    [JsonAsset("BlueprintEditorSettings")]
    public class UBlueprintEditorSettings : UDeveloperSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}