namespace AssetTool
{
    [JsonAsset("ActorElementEditorSelectionInterface")]
    public class UActorElementEditorSelectionInterface : UActorElementSelectionInterface
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}