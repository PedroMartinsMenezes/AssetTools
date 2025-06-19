namespace AssetTool
{
    [JsonAsset("EditorSubsystem")]
    public class UEditorSubsystem : UDynamicSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}