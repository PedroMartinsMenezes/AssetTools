namespace AssetTool
{
    [JsonAsset("UnrealEditorSubsystem")]
    public class UUnrealEditorSubsystem : UEditorSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}