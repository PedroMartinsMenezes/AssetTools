namespace AssetTool
{
    [JsonAsset("ActorElementEditorWorldInterface")]
    public class UActorElementEditorWorldInterface : UActorElementWorldInterface
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}