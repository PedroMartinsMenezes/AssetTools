namespace AssetTool
{
    [JsonAsset("PaperFlipbookActorFactory")]
    public class UPaperFlipbookActorFactory : UActorFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}