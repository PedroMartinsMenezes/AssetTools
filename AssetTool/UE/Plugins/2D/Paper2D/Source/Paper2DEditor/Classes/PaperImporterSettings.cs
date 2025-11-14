namespace AssetTool
{
    [JsonAsset("PaperImporterSettings")]
    public class UPaperImporterSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}