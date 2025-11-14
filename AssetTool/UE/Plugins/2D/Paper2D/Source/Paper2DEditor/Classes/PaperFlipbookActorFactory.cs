namespace AssetTool
{
    [JsonAsset("PaperFlipbookActorFactory")]
    public class UPaperFlipbookActorFactory : UActorFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}