namespace AssetTool
{
    [JsonAsset("BlueprintEditorProjectSettings")]
    public class UBlueprintEditorProjectSettings : UDeveloperSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}