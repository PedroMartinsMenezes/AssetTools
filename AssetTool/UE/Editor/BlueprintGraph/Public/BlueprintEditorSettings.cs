namespace AssetTool
{
    [JsonAsset("BlueprintEditorSettings")]
    public class UBlueprintEditorSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}