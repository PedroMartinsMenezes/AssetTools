namespace AssetTool
{
    [JsonAsset("AvaMaskEditorWorldSubsystem")]
    public class UAvaMaskEditorWorldSubsystem : UWorldSubsystem
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AvaMaskEditorSubsystem")]
    public class UAvaMaskEditorSubsystem : UEditorSubsystem
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}