namespace AssetTool
{
    [JsonAsset("PaperSpriteSheetReimportFactory")]
    public class UPaperSpriteSheetReimportFactory : UPaperSpriteSheetImportFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}