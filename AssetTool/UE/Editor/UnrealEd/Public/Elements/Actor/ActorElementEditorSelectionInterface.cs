namespace AssetTool
{
    [JsonAsset("ActorElementEditorSelectionInterface")]
    public class UActorElementEditorSelectionInterface : UActorElementSelectionInterface
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}