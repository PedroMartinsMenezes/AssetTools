namespace AssetTool
{
    [JsonAsset("PaperFlipbook")]
    public class UPaperFlipbook : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}