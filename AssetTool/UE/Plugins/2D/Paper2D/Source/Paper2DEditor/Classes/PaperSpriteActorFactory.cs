namespace AssetTool
{
    [JsonAsset("PaperSpriteActorFactory")]
    public class UPaperSpriteActorFactory : UActorFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}