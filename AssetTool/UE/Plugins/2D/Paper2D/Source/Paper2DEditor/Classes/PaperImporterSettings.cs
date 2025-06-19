namespace AssetTool
{
    [JsonAsset("PaperImporterSettings")]
    public class UPaperImporterSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}