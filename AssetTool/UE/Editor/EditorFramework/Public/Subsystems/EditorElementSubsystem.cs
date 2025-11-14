namespace AssetTool
{
    [JsonAsset("EditorElementSubsystem")]
    public class UEditorElementSubsystem : UEditorSubsystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}