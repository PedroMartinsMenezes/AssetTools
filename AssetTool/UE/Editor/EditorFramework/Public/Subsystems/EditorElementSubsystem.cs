namespace AssetTool
{
    [JsonAsset("EditorElementSubsystem")]
    public class UEditorElementSubsystem : UEditorSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}