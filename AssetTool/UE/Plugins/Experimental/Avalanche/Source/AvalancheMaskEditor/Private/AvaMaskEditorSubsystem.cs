namespace AssetTool
{
    [JsonAsset("AvaMaskEditorWorldSubsystem")]
    public class UAvaMaskEditorWorldSubsystem : UWorldSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AvaMaskEditorSubsystem")]
    public class UAvaMaskEditorSubsystem : UEditorSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}