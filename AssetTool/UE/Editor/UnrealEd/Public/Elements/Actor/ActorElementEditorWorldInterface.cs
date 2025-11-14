namespace AssetTool
{
    [JsonAsset("ActorElementEditorWorldInterface")]
    public class UActorElementEditorWorldInterface : UActorElementWorldInterface
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}