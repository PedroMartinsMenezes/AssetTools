namespace AssetTool
{
    [JsonAsset("EditorAssetSubsystem")]
    public class UEditorAssetSubsystem : UEditorSubsystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}