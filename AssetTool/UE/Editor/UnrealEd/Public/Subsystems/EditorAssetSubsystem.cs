namespace AssetTool
{
    [JsonAsset("EditorAssetSubsystem")]
    public class UEditorAssetSubsystem : UEditorSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}