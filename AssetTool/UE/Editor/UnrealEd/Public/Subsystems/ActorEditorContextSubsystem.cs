namespace AssetTool
{
    [JsonAsset("ActorEditorContextSubsystem")]
    public class UActorEditorContextSubsystem : UEditorSubsystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}