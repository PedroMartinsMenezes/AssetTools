namespace AssetTool
{
    [JsonAsset("ActorElementEditorSelectionInterface")]
    public class UActorElementEditorSelectionInterface : UActorElementSelectionInterface
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}