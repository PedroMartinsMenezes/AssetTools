namespace AssetTool
{
    [JsonAsset("PaperFlipbookActor")]
    public class APaperFlipbookActor : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}