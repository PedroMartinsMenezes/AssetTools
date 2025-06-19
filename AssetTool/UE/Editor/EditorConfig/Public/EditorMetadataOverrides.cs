namespace AssetTool
{
    [JsonAsset("EditorMetadataOverrides")]
    public class UEditorMetadataOverrides : UEditorSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}