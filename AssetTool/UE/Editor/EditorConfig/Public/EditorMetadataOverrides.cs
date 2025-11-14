namespace AssetTool
{
    [JsonAsset("EditorMetadataOverrides")]
    public class UEditorMetadataOverrides : UEditorSubsystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}