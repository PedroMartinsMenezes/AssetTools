namespace AssetTool
{
    [JsonAsset("PaperSpriteActorFactory")]
    public class UPaperSpriteActorFactory : UActorFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}