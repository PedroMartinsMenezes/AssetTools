namespace AssetTool
{
    [JsonAsset("BlueprintEditorProjectSettings")]
    public class UBlueprintEditorProjectSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}