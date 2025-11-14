namespace AssetTool
{
    [JsonAsset("EditorActorSubsystem")]
    public class UEditorActorSubsystem : UEditorSubsystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}