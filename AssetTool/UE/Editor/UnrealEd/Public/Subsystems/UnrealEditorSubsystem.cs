namespace AssetTool
{
    [JsonAsset("UnrealEditorSubsystem")]
    public class UUnrealEditorSubsystem : UEditorSubsystem
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}