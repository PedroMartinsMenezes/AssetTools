namespace AssetTool
{
    [JsonAsset("SVGImporterSettings")]
    public class USVGImporterSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}