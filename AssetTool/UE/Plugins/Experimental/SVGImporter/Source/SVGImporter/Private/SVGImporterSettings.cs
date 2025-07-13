namespace AssetTool
{
    [JsonAsset("SVGImporterSettings")]
    public class USVGImporterSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}