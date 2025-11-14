namespace AssetTool
{
    [JsonAsset("PaperFlipbookActor")]
    public class APaperFlipbookActor : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}