namespace AssetTool
{
    [JsonAsset("BlueprintEditorSettings")]
    public class UBlueprintEditorSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}