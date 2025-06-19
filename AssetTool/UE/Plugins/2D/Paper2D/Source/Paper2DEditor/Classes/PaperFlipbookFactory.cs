namespace AssetTool
{
    [JsonAsset("PaperFlipbookFactory")]
    public class UPaperFlipbookFactory : UFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}