namespace AssetTool
{
    [JsonAsset("EditorActorSubsystem")]
    public class UEditorActorSubsystem : UEditorSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}