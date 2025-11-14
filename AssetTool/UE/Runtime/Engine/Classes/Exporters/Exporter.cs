namespace AssetTool
{
    [JsonAsset("Exporter")]
    public class UExporter : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}