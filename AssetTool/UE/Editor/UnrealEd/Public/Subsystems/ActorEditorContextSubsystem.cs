namespace AssetTool
{
    [JsonAsset("ActorEditorContextSubsystem")]
    public class UActorEditorContextSubsystem : UEditorSubsystem
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}