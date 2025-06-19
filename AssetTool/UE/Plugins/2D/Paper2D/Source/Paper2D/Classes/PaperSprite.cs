namespace AssetTool
{
    [JsonAsset("PaperSprite")]
    public class UPaperSprite : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}