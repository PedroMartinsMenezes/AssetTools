namespace AssetTool
{
    [JsonAsset("PaperFlipbookActorFactory")]
    public class UPaperFlipbookActorFactory : UActorFactory
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}