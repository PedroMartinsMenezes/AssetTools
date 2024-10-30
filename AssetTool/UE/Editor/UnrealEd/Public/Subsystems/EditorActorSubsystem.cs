namespace AssetTool
{
    [JsonAsset("EditorActorSubsystem")]
    public class UEditorActorSubsystem : UEditorSubsystem
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}