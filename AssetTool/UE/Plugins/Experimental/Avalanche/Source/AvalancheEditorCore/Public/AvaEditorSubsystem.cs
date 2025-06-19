namespace AssetTool
{
    [JsonAsset("AvaEditorSubsystem")]
    public class UAvaEditorSubsystem : UWorldSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}