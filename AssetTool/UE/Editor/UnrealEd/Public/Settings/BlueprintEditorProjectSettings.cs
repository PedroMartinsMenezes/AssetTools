namespace AssetTool
{
    [JsonAsset("BlueprintEditorProjectSettings")]
    public class UBlueprintEditorProjectSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}