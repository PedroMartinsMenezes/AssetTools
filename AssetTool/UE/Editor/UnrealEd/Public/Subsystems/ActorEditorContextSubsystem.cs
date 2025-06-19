namespace AssetTool
{
    [JsonAsset("ActorEditorContextSubsystem")]
    public class UActorEditorContextSubsystem : UEditorSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}