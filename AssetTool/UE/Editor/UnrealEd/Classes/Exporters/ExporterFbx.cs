namespace AssetTool
{
    [JsonAsset("ExporterFBX")]
    public class UExporterFBX : UExporter
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}