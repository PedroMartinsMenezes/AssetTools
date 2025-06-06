namespace AssetTool
{
    [JsonAsset("EditorMetadataOverrides")]
    public class UEditorMetadataOverrides : UEditorSubsystem
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}