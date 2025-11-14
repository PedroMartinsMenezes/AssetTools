namespace AssetTool
{
    [JsonAsset("AvaMaskEditorWorldSubsystem")]
    public class UAvaMaskEditorWorldSubsystem : UWorldSubsystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AvaMaskEditorSubsystem")]
    public class UAvaMaskEditorSubsystem : UEditorSubsystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}