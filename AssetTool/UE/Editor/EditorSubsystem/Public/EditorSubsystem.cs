namespace AssetTool
{
    [JsonAsset("EditorSubsystem")]
    public class UEditorSubsystem : UDynamicSubsystem
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}