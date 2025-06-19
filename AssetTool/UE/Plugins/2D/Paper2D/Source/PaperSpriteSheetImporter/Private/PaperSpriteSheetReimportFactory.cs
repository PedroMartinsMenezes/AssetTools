namespace AssetTool
{
    [JsonAsset("PaperSpriteSheetReimportFactory")]
    public class UPaperSpriteSheetReimportFactory : UPaperSpriteSheetImportFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}