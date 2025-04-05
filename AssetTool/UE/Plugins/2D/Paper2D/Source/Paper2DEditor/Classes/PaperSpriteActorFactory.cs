namespace AssetTool
{
    [JsonAsset("PaperSpriteActorFactory")]
    public class UPaperSpriteActorFactory : UActorFactory
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}