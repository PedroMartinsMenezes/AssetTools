namespace AssetTool
{
    [JsonAsset("ActorElementEditorWorldInterface")]
    public class UActorElementEditorWorldInterface : UActorElementWorldInterface
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}