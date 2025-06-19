namespace AssetTool
{
    [JsonAsset("ActorModifierCoreEditorSubsystem")]
    public class UActorModifierCoreEditorSubsystem : UEditorSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}