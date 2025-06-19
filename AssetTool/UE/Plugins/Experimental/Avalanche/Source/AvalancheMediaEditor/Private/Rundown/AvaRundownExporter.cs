namespace AssetTool
{
    [JsonAsset("AvaRundownExporter")]
    public class UAvaRundownExporter : UExporter
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}