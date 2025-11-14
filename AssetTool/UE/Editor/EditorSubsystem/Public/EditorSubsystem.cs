namespace AssetTool
{
    [JsonAsset("EditorSubsystem")]
    public class UEditorSubsystem : UDynamicSubsystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}