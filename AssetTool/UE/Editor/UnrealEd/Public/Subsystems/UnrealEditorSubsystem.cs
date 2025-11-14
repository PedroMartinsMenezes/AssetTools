namespace AssetTool
{
    [JsonAsset("UnrealEditorSubsystem")]
    public class UUnrealEditorSubsystem : UEditorSubsystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}