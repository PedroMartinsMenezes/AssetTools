namespace AssetTool
{
    [JsonAsset("Exporter")]
    public class UExporter : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}